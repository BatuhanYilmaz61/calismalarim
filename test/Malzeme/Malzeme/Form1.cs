using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Web;
using Malzeme.Models;
using RestSharp;
using Amazon.Auth.AccessControlPolicy;
using Newtonsoft.Json.Linq;
using System.Net;
using Amazon.Runtime.Internal;
using Amazon.Runtime.SharedInterfaces;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Net.Http;
using ServiceStack;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Malzeme.Helpers;
using Dapper;
using System.Diagnostics;

namespace Malzeme
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti;
        private string _connectionString = "Data Source=PC\\BERK;Initial Catalog=Items;Persist Security Info=True;User ID=sa; Password=1";
        private RestHelper _restHelper = new RestHelper();
        public Form1()
        {
            InitializeComponent();
            baglanti = new SqlConnection(_connectionString);
        }

        private void Clear()//Tezt box temizlenmesi
        {
            textBoxId.Clear();
            textBoxName.Clear();
            textBoxCategory.Clear();
            textBoxPrice.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxGuid.Text = System.Guid.NewGuid().ToString();
            //Ekle 
            if (!string.IsNullOrEmpty(textBoxName.Text) && !string.IsNullOrEmpty(textBoxCategory.Text) && textBoxPrice.Text != "" && textBoxGuid.Text != "")
            {
                using (var sqlConnection = new SqlConnection(_connectionString))
                {
                    sqlConnection.Execute
                        (
                            "insert into Items(Name,Category,price,GUID) values (@Name,@Category,@price,@GUID)",
                            new { @Name = textBoxName.Text, @Category = textBoxCategory.Text, @price = int.Parse(textBoxPrice.Text), @GUID = textBoxGuid.Text, }
                        );
                }

                Clear();
                listele();
                MessageBox.Show("Eklendi");
            }
            else
            {
                MessageBox.Show("Boş Bırakılamaz");
            }
        }

        private void listele() // Kayıtların Görüntülenmesi
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                var dataTable = sqlConnection.Query<ListModel>(Properties.Resources.MalzemeListesiGetir);
                dataGridView1.DataSource = dataTable;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxId.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
            textBoxName.Text = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
            textBoxCategory.Text = dataGridView1.CurrentRow.Cells["Category"].Value.ToString();
            textBoxPrice.Text = dataGridView1.CurrentRow.Cells["Price"].Value.ToString();
            textBoxGuid.Text = dataGridView1.CurrentRow.Cells["GUID"].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("DELETE FROM Items WHERE ID=@ID", baglanti);
            if (textBoxId.Text != "")
            {
                komut.Parameters.AddWithValue("@ID", Convert.ToInt32(textBoxId.Text));
                komut.ExecuteNonQuery();
                listele();
                Clear();
            }
            else
            {
                MessageBox.Show("Kayıt Silindi");
            }

            baglanti.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Items where ID=@ID", baglanti);
            komut.Parameters.AddWithValue("ID", int.Parse(textBoxId.Text));
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            baglanti.Close();
            Clear();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxId.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
            textBoxName.Text = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
            textBoxCategory.Text = dataGridView1.CurrentRow.Cells["Category"].Value.ToString();
            textBoxPrice.Text = dataGridView1.CurrentRow.Cells["Price"].Value.ToString();
            textBoxGuid.Text = dataGridView1.CurrentRow.Cells["GUID"].Value?.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var model = GetSeciliDegerler();

            MalzemeyiVeriTabanindaGuncelle(model);
            listele();
            Clear();
        }

        private LogoMalzemeKarti GetSeciliDegerler()
        {
            int.TryParse(dataGridView1.CurrentRow.Cells["LogoRef"].Value?.ToString(), out var logoRef);

            return new LogoMalzemeKarti()
            {
                CARD_TYPE = 1,
                CODE = textBoxName.Text,
                NAME = textBoxCategory.Text,
                GUID = textBoxGuid.Text,
                LOGOREF = logoRef
            };
        }

        private void MalzemeyiVeriTabanindaGuncelle(LogoMalzemeKarti model)
        {
            baglanti.Open();

            int.TryParse(textBoxId.Text, out var id);
            int.TryParse(textBoxPrice.Text, out var price);

            SqlCommand cmd = new SqlCommand("Update Items SET Name=@Name,Category=@Category,price=@price, logoRef = @LogoRef WHERE ID=@ID", baglanti);
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.Parameters.AddWithValue("@Name", textBoxName.Text);
            cmd.Parameters.AddWithValue("@Category", textBoxCategory.Text);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@logoRef", model.LOGOREF);
            cmd.ExecuteNonQuery();

            baglanti.Close();
        }

        private void transfer_Click(object sender, EventArgs e)
        {
            var malzemeKarti = GetSeciliDegerler();

            var accessToken = _restHelper.getAccessToken("http://192.168.1.44:32001", "REST", "REST", "120");

            if (malzemeKarti.LOGOREF > 0)
            {
                malzemeKarti.LOGOREF = _restHelper.updateItem("http://192.168.1.44:32001", "REST", "REST", "120", accessToken, malzemeKarti);

                if (malzemeKarti.LOGOREF > 0)
                    MalzemeyiVeriTabanindaGuncelle(malzemeKarti);
            }
            else
            {
                malzemeKarti.LOGOREF = _restHelper.createItem("http://192.168.1.44:32001", "REST", "REST", "120", accessToken, malzemeKarti);
                MalzemeyiVeriTabanindaGuncelle(malzemeKarti);
            }

            listele();
            

        }
    }
}

