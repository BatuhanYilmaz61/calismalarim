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
    public partial class Ticari : Form
    {
        public Ticari()
        {
            InitializeComponent();
        }

        private void Ticari_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'denemeDataSet4.Ticari_İslem' table. You can move, or remove it, as needed.
            this.ticari_İslemTableAdapter.Fill(this.denemeDataSet4.Ticari_İslem);
            
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CariKod satis = (CariKod)Application.OpenForms["CariKod"];
            satis.TicariText.Text = TicariDtw.Rows[e.RowIndex].Cells["Ticari_İslem"].Value.ToString();
            this.Close();
            
        }
    }
}
