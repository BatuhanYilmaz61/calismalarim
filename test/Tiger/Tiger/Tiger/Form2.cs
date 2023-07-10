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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tiger
{
    public partial class Form2 : Form
    {
        string T1, T2;
        public static string Code;

        public string urun;
        string connection = "Data Source=PC\\BERK;Initial Catalog=Deneme;Persist Security Info=True;User ID=sa; Password=1";

        public Form2()
        {
            InitializeComponent();
        }

        private void MalzemeDtW_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'denemeDataSet1.Malzeme' table. You can move, or remove it, as needed.
            this.malzemeTableAdapter.Fill(this.denemeDataSet1.Malzeme);
            

        }

       
    }
}
