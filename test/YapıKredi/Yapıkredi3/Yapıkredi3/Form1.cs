using RestSharp;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;

namespace YapıKredi3
{
    public class CurrencyInfo
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string BuyingRate { get; set; }
        public string SellingRate { get; set; }
        public string LastModified { get; set; }
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var options = new RestClientOptions("https://api.yapikredi.com.tr")
            {
                MaxTimeout = -1,
                FollowRedirects = false,
            };
            var client = new RestClient(options);
            var request = new RestRequest("/api/investmentrates/v1/currencyRates", Method.Get);
            request.AddHeader("Authorization", "Bearer 6b7bf09d-df25-4ae6-9926-1445b3158837");
            RestResponse response = client.Get(request);

            var json = JObject.Parse(response.Content);
            var currencies = json["currencyRates"] as JArray;

            List<CurrencyInfo> currencyList = new List<CurrencyInfo>();

            if (currencies != null)
            {
                foreach (var currency in currencies)
                {
                    if (currency["buyingRate"] != null && currency["sellingRate"] != null)
                    {
                        currencyList.Add(new CurrencyInfo
                        {
                            Code = currency["code"].ToString(),
                            Name = currency["name"].ToString(),
                            BuyingRate = currency["buyingRate"].ToString(),
                            SellingRate = currency["sellingRate"].ToString(),
                            LastModified = currency["lastModified"].ToString()
                        });
                    }
                }
            }

            

            TextBox tbCode = new TextBox();
            TextBox tbName = new TextBox();
            TextBox tbBuyingRate = new TextBox();
            TextBox tbSellingRate = new TextBox();
            TextBox tbLastModified = new TextBox();

            Controls.Add(tbCode);
            Controls.Add(tbName);
            Controls.Add(tbBuyingRate);
            Controls.Add(tbSellingRate);
            Controls.Add(tbLastModified);

            if (currencyList != null)
            {
                foreach (var currency in currencyList)
                {
                    tbCode.Text = currency.Code;
                    tbName.Text = currency.Name;
                    tbBuyingRate.Text = currency.BuyingRate;
                    tbSellingRate.Text = currency.SellingRate;
                    tbLastModified.Text = currency.LastModified;
                }
            }

            // JSON'a dönüştürme
            string jsonCurrencyList = JsonConvert.SerializeObject(currencyList, Formatting.Indented);
            Console.WriteLine(jsonCurrencyList);
        }
    }
}