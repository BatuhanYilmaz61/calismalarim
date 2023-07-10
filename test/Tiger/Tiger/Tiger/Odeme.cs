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
    public partial class Odeme : Form
    {
        public Odeme()
        {
            InitializeComponent();
            
        }

      

        private void Odeme_Load(object sender, EventArgs e)
        {
            
            this.ödemelerTableAdapter.Fill(this.denemeDataSet3.Ödemeler);

        }

        private void OdemeDtw_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CariKod satis= (CariKod)Application.OpenForms["CariKod"];
            satis.Odeme.Text = OdemeDtw.Rows[e.RowIndex].Cells["Ödemeler"].Value.ToString();
            this.Close();
        }
    }
}
