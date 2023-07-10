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
using Tiger.Properties;

namespace Tiger
{
    public partial class CariKod : Form
    {
        string connection = "Data Source=PC\\BERK;Initial Catalog=Deneme;Persist Security Info=True;User ID=sa; Password=1";
        public CariKod()
        {
            InitializeComponent();

        }



        private void Form1_Load(object sender, EventArgs e)
        {

            this.ambarTableAdapter.Fill(this.denemeDataSet.Ambar);

            Tarih.Text = DateTime.Now.ToShortDateString();
            Zaman.Text = DateTime.Now.ToString("hh:mm:ss");
            Random rn = new Random();
            Random rn2 = new Random();
            string random = rn2.Next(100000000, 999999999).ToString();
            string rondumnumber = rn.Next(100000000, 900000000).ToString();
            fisNo.Text = rondumnumber;
            BelgeNo.Text = random;
        }


        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();

            
            foreach (DataGridViewRow row in form2.MalzemeDtW.SelectedRows)
            {
                dataGridView1.Rows.Add(row.Cells[0].Value, row.Cells[1].Value, row.Cells[2].Value, row.Cells[3].Value);
            }
            this.Close();


        }

        private void textBox3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Odeme odeme = new Odeme();
            odeme.ShowDialog();
        }



        private void TicariText_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Ticari ticari = new Ticari();
            ticari.ShowDialog();
            
        }

        private void textBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Cari cari = new Cari();
            cari.ShowDialog();


        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.Columns[e.ColumnIndex].Name == "BrimFiyat" ||
                 dataGridView1.Columns[e.ColumnIndex].Name == "Adet" || dataGridView1.Columns[e.ColumnIndex].Name == "KDV")
            {
                double fiyat = 0;
                int adet = 0;
                double kdvOrani = 0;
                double toplam = 0;

                if (dataGridView1.Rows[e.RowIndex].Cells["Adet"].Value != DBNull.Value)
                    adet = Convert.ToInt32(
                        dataGridView1.Rows[e.RowIndex].Cells["Adet"].Value);
                if (dataGridView1.Rows[e.RowIndex].Cells["BrimFiyat"].Value != DBNull.Value)
                    fiyat = Convert.ToDouble(
                        dataGridView1.Rows[e.RowIndex].Cells["BrimFiyat"].Value);
                if (dataGridView1.Rows[e.RowIndex].Cells["KDV"].Value != DBNull.Value)
                    kdvOrani = Convert.ToDouble(
                        dataGridView1.Rows[e.RowIndex].Cells["KDV"].Value);


                kdvOrani = (fiyat * adet / 100) * kdvOrani;
                toplam = fiyat * adet+kdvOrani;

                

                dataGridView1.Rows[e.RowIndex].Cells["Total"].Value = toplam;

            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Sil"].Index)
            {
                Button btndelete = new Button();
                Button btnsave = new Button();
                btndelete.Location = new Point(10, 10);
                btnsave.Location = new Point(10, 10);
                DialogResult dialog = MessageBox.Show("Bu kaydı silmek istediğine emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    if (dataGridView1.Rows[e.RowIndex].IsNewRow == true)
                    {
                        MessageBox.Show("Silinecek kayıt bulunamadı");
                    }
                    else
                    {
                        dataGridView1.Rows.RemoveAt(e.RowIndex);
                    }
                }
            }
            
            
        }
    }

    
}
