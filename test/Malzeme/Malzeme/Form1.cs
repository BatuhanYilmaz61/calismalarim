using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Malzeme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        private void Clear()//Tezt box temizlenmesi
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=PC\\BERK;Initial Catalog=Items;Persist Security Info=True;User ID=sa; Password=1");
        private void button1_Click(object sender, EventArgs e)
        {//Ekle 
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into Items(Name,Category,price) values (@Name,@Category,@price)", baglanti);
            if (textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")  
            {
               
                cmd.Parameters.AddWithValue("@Name", textBox2.Text);
                cmd.Parameters.AddWithValue("@Category", textBox3.Text);
                cmd.Parameters.AddWithValue("@price", int.Parse(textBox4.Text));
                cmd.ExecuteNonQuery();
                baglanti.Close();
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
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter(Properties.Resources.MalzemeListesiGetir,baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("DELETE FROM Items WHERE ID=@ID", baglanti);
            if (textBox1.Text != "")
            {
                komut.Parameters.AddWithValue("@ID", Convert.ToInt32(textBox1.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();
                listele();
                Clear();


            }
            else { MessageBox.Show("Kayıt Silindi"); }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Update Items SET Name=@Name,Category=@Category,price=@price WHERE ID=@ID", baglanti);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Category", textBox3.Text);
            cmd.Parameters.AddWithValue("@price", int.Parse(textBox4.Text));
            cmd.ExecuteNonQuery();
            baglanti.Close();
            listele();
            Clear();
            MessageBox.Show("Güncellendi");


        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Items where ID=@ID", baglanti);
            komut.Parameters.AddWithValue("ID",int.Parse(textBox1.Text));
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
            Clear();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
    }
}

