using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Item
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private ListView listView1;
        SqlConnection baglan = new SqlConnection("Data Source=PC\\BERK;Initial Catalog=Items;Persist Security Info=True;User ID=sa; Password=1");
        private void VerileriGörüntüle()
        {
            listView1.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select*from Items",baglan);
           
            
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["ID"].ToString();
                ekle.SubItems.Add(oku["Name"].ToString());
                ekle.SubItems.Add(oku["Category"].ToString());
                ekle.SubItems.Add(oku["price"].ToString());

                listView1.Items.Add(ekle);
            }

            listView1.Refresh();
            baglan.Close();
        }
      

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            VerileriGörüntüle();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut=new SqlCommand("INSERT INTO Items(ID,Name,Category,price) Values('"+textBox1.Text.ToString()+"','" + textBox2.Text.ToString() + "','"+textBox3.Text.ToString()+ "','" + textBox4.Text.ToString() +"')", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            VerileriGörüntüle();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

        }
        int id = 0;

        private void button3_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Delete From Items where ID=(" + id + ")", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            VerileriGörüntüle();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBox4.Text = listView1.SelectedItems[0].SubItems[3].Text;
        }

        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(93, 243);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(384, 97);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(569, 376);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }
    }
}
