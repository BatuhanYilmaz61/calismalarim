using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tiger
{
    public partial class Cari : Form
    {
        public Cari()
        {
            InitializeComponent();
            CariDtw.CellDoubleClick += CariDtw_CellDoubleClick;
            
        }

        public string CName { get; set; }
        public string CKod { get; set; }

        private void Cari_Load(object sender, EventArgs e)
        {
            
            this.cari1TableAdapter.Fill(this.denemeDataSet2.Cari1);
            
            

        }

        private void CariDtw_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            CariKod satis = (CariKod)Application.OpenForms["CariKod"];
            satis.KodCari.Text = CariDtw.Rows[e.RowIndex].Cells["Kod"].Value.ToString();
            satis.UnvanCari.Text = CariDtw.Rows[e.RowIndex].Cells["Unvan"].Value.ToString();
            this.Close();






        }
    }
}
