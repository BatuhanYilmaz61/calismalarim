using RestSharp;
using System.Data;
using System;
using Newtonsoft.Json.Linq;

using System.Windows.Forms;
using System.Data.SqlClient;

namespace YapıKredi1
{
    public partial class Form1 : Form
    {
        private decimal previousBuyRate;
        private decimal previousSellRate;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshData();

        }

        private void RefreshData()
        {
            var options = new RestClientOptions("https://api.yapikredi.com.tr")
            {
                MaxTimeout = -1,
                FollowRedirects = false,
            };

            var client = new RestClient(options);
            var request = new RestRequest("/api/investmentrates/v1/currencyRates", Method.Get);
            request.AddHeader("Authorization", "Bearer b6d8595c-d403-4a62-832e-97b3b696de83");

            RestResponse response = client.Execute(request);

            var json = JObject.Parse(response.Content);

            var currencies = json["response"]["exchangeRateList"] as JArray;

            DataTable dt = new DataTable();
            dt.Columns.Add("Kur Kodu");
            dt.Columns.Add("Kur Adı");
            dt.Columns.Add("Alış");
            dt.Columns.Add("Satış");
            dt.Columns.Add("En Son Değişim");
            dt.Columns.Add("Değişim Saati");
            dt.Columns.Add("Kur Farkı"); // Yeni sütun: Kur farkı

            if (currencies != null)
            {
                foreach (var currency in currencies)
                {
                    var majorCurrency = currency["majorCurrency"].ToString();
                    var minorCurrency = currency["minorCurrency"].ToString();

                    if ((majorCurrency == "USD" || majorCurrency == "EUR") && minorCurrency == "TL")
                    {
                        if (currency["buyRate"] != null && currency["sellRate"] != null)
                        {
                            var buyRate = decimal.Parse(currency["buyRate"].ToString()); // Alış kurunu decimal olarak al
                            var sellRate = decimal.Parse(currency["sellRate"].ToString()); // Satış kurunu decimal olarak al

                            // Önceki alış ve satış kur değerleri ile karşılaştırarak kur farkını hesapla
                            decimal exchangeRateDifference = 0;
                            if (previousBuyRate != 0 && previousSellRate != 0)
                            {
                                exchangeRateDifference = buyRate - previousBuyRate;
                            }

                            var previousDayAverageRate = currency["previousDayAverageRate"].ToString();
                            var changeTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                            dt.Rows.Add(majorCurrency,
                                        minorCurrency,
                                        buyRate,
                                        sellRate,
                                        previousDayAverageRate,
                                        changeTime,
                                        exchangeRateDifference); // Kur farkı sütununu ekle
                        }
                    }
                }
            }

            dataGridView1.DataSource = dt;
            string connectionString = "Data Source=PC\\BERK;Initial Catalog=Deneme;Persist Security Info=True;User ID=sa; Password=1";
            string tableName = "YapıKredi"; // Hedef tablo adı

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                foreach (DataRow row in dt.Rows)
                {
                    string majorCurrency = row["Kur Kodu"].ToString();
                    string minorCurrency = row["Kur Adı"].ToString();
                    string buyRate = row["Alış"].ToString();
                    string sellRate = row["Satış"].ToString();
                    string previousDayAverageRate = row["En Son Değişim"].ToString();
                    string changeTime = row["Değişim Saati"].ToString();
                    string exchangeRateDifference = row["Kur Farkı"].ToString();

                    string insertQuery = $"INSERT INTO {tableName} (KurKodu, KurAdi, Alis, Satis, EnSonDegisim, DegisimSaati, KurFarki) VALUES (@KurKodu, @KurAdi, @Alis, @Satis, @EnSonDegisim, @DegisimSaati, @KurFarki)";

                    SqlCommand command = new SqlCommand(insertQuery, connection);
                    command.Parameters.AddWithValue("@KurKodu", majorCurrency);
                    command.Parameters.AddWithValue("@KurAdi", minorCurrency);
                    command.Parameters.AddWithValue("@Alis", buyRate);
                    command.Parameters.AddWithValue("@Satis", sellRate);
                    command.Parameters.AddWithValue("@EnSonDegisim", previousDayAverageRate);
                    command.Parameters.AddWithValue("@DegisimSaati", changeTime);
                    command.Parameters.AddWithValue("@KurFarki", exchangeRateDifference);

                    command.ExecuteNonQuery();
                }

                connection.Close();
            }

        }
        




        private void button1_Click(object sender, EventArgs e)
        {
            RefreshData();
          
          
            

        }
        public void Fark()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                decimal currentBuyRate = decimal.Parse(dataGridView1.Rows[0].Cells["Alış"].Value.ToString());
                decimal currentSellRate = decimal.Parse(dataGridView1.Rows[0].Cells["Satış"].Value.ToString());

                if (previousBuyRate != 0 && previousSellRate != 0)
                {
                    decimal buyRateDifference = currentBuyRate - previousBuyRate;
                    decimal sellRateDifference = currentSellRate - previousSellRate;

                    MessageBox.Show("Alış Kur Farkı: " + buyRateDifference.ToString() + "\nSatış Kur Farkı: " + sellRateDifference.ToString());
                }

                previousBuyRate = currentBuyRate;
                previousSellRate = currentSellRate;
            }
        }
    }
}