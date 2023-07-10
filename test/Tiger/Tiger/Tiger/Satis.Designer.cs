namespace Tiger
{
    partial class CariKod
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.fisNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Zaman = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Tarih = new System.Windows.Forms.TextBox();
            this.BelgeNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.KodCari = new System.Windows.Forms.TextBox();
            this.UnvanCari = new System.Windows.Forms.TextBox();
            this.Odeme = new System.Windows.Forms.TextBox();
            this.TicariText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Cariunvan = new System.Windows.Forms.Label();
            this.CariOdemeler = new System.Windows.Forms.Label();
            this.CariTicari = new System.Windows.Forms.Label();
            this.Cisyeri = new System.Windows.Forms.ComboBox();
            this.Cbolum = new System.Windows.Forms.ComboBox();
            this.Cfabrika = new System.Windows.Forms.ComboBox();
            this.Cambar = new System.Windows.Forms.ComboBox();
            this.ambarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.denemeDataSet = new Tiger.DenemeDataSet();
            this.İşyeri = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ambarTableAdapter = new Tiger.DenemeDataSetTableAdapters.AmbarTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Kod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Malzeme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrimFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sil = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ambarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.denemeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // fisNo
            // 
            this.fisNo.Location = new System.Drawing.Point(143, 39);
            this.fisNo.Margin = new System.Windows.Forms.Padding(4);
            this.fisNo.Name = "fisNo";
            this.fisNo.Size = new System.Drawing.Size(153, 22);
            this.fisNo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(57, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fiş No";
            // 
            // Zaman
            // 
            this.Zaman.Location = new System.Drawing.Point(143, 126);
            this.Zaman.Name = "Zaman";
            this.Zaman.Size = new System.Drawing.Size(153, 22);
            this.Zaman.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tarih";
            // 
            // Tarih
            // 
            this.Tarih.Location = new System.Drawing.Point(143, 80);
            this.Tarih.Name = "Tarih";
            this.Tarih.Size = new System.Drawing.Size(153, 22);
            this.Tarih.TabIndex = 4;
            // 
            // BelgeNo
            // 
            this.BelgeNo.Location = new System.Drawing.Point(143, 170);
            this.BelgeNo.Name = "BelgeNo";
            this.BelgeNo.Size = new System.Drawing.Size(153, 22);
            this.BelgeNo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(57, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Zaman";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(57, 170);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Belge No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(454, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cari Hesap Bilgileri";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // KodCari
            // 
            this.KodCari.Location = new System.Drawing.Point(458, 39);
            this.KodCari.Margin = new System.Windows.Forms.Padding(4);
            this.KodCari.Name = "KodCari";
            this.KodCari.Size = new System.Drawing.Size(153, 22);
            this.KodCari.TabIndex = 9;
            this.KodCari.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseDoubleClick);
            // 
            // UnvanCari
            // 
            this.UnvanCari.Location = new System.Drawing.Point(458, 83);
            this.UnvanCari.Margin = new System.Windows.Forms.Padding(4);
            this.UnvanCari.Name = "UnvanCari";
            this.UnvanCari.Size = new System.Drawing.Size(153, 22);
            this.UnvanCari.TabIndex = 10;
            // 
            // Odeme
            // 
            this.Odeme.Location = new System.Drawing.Point(458, 129);
            this.Odeme.Margin = new System.Windows.Forms.Padding(4);
            this.Odeme.Name = "Odeme";
            this.Odeme.Size = new System.Drawing.Size(153, 22);
            this.Odeme.TabIndex = 11;
            this.Odeme.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textBox3_MouseDoubleClick);
            // 
            // TicariText
            // 
            this.TicariText.Location = new System.Drawing.Point(458, 173);
            this.TicariText.Margin = new System.Windows.Forms.Padding(4);
            this.TicariText.Name = "TicariText";
            this.TicariText.Size = new System.Drawing.Size(153, 22);
            this.TicariText.TabIndex = 12;
            this.TicariText.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TicariText_MouseDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(368, 45);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Kodu";
            // 
            // Cariunvan
            // 
            this.Cariunvan.AutoSize = true;
            this.Cariunvan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Cariunvan.Location = new System.Drawing.Point(368, 86);
            this.Cariunvan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Cariunvan.Name = "Cariunvan";
            this.Cariunvan.Size = new System.Drawing.Size(49, 16);
            this.Cariunvan.TabIndex = 14;
            this.Cariunvan.Text = "Ünvanı";
            // 
            // CariOdemeler
            // 
            this.CariOdemeler.AutoSize = true;
            this.CariOdemeler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CariOdemeler.Location = new System.Drawing.Point(357, 132);
            this.CariOdemeler.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CariOdemeler.Name = "CariOdemeler";
            this.CariOdemeler.Size = new System.Drawing.Size(67, 16);
            this.CariOdemeler.TabIndex = 15;
            this.CariOdemeler.Text = "Ödemeler";
            // 
            // CariTicari
            // 
            this.CariTicari.AutoSize = true;
            this.CariTicari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CariTicari.Location = new System.Drawing.Point(357, 176);
            this.CariTicari.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CariTicari.Name = "CariTicari";
            this.CariTicari.Size = new System.Drawing.Size(79, 16);
            this.CariTicari.TabIndex = 16;
            this.CariTicari.Text = "Ticari İşlem ";
            // 
            // Cisyeri
            // 
            this.Cisyeri.FormattingEnabled = true;
            this.Cisyeri.Items.AddRange(new object[] {
            "RNET"});
            this.Cisyeri.Location = new System.Drawing.Point(813, 37);
            this.Cisyeri.Name = "Cisyeri";
            this.Cisyeri.Size = new System.Drawing.Size(121, 24);
            this.Cisyeri.TabIndex = 17;
            // 
            // Cbolum
            // 
            this.Cbolum.FormattingEnabled = true;
            this.Cbolum.Items.AddRange(new object[] {
            "Merkez"});
            this.Cbolum.Location = new System.Drawing.Point(813, 80);
            this.Cbolum.Name = "Cbolum";
            this.Cbolum.Size = new System.Drawing.Size(121, 24);
            this.Cbolum.TabIndex = 18;
            // 
            // Cfabrika
            // 
            this.Cfabrika.FormattingEnabled = true;
            this.Cfabrika.Items.AddRange(new object[] {
            "Kıraç"});
            this.Cfabrika.Location = new System.Drawing.Point(813, 124);
            this.Cfabrika.Name = "Cfabrika";
            this.Cfabrika.Size = new System.Drawing.Size(121, 24);
            this.Cfabrika.TabIndex = 19;
            // 
            // Cambar
            // 
            this.Cambar.DataSource = this.ambarBindingSource;
            this.Cambar.DisplayMember = "Ambar";
            this.Cambar.FormattingEnabled = true;
            this.Cambar.Location = new System.Drawing.Point(813, 170);
            this.Cambar.Name = "Cambar";
            this.Cambar.Size = new System.Drawing.Size(121, 24);
            this.Cambar.TabIndex = 20;
            this.Cambar.ValueMember = "Ambar";
            // 
            // ambarBindingSource
            // 
            this.ambarBindingSource.DataMember = "Ambar";
            this.ambarBindingSource.DataSource = this.denemeDataSet;
            // 
            // denemeDataSet
            // 
            this.denemeDataSet.DataSetName = "DenemeDataSet";
            this.denemeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // İşyeri
            // 
            this.İşyeri.AutoSize = true;
            this.İşyeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.İşyeri.Location = new System.Drawing.Point(683, 42);
            this.İşyeri.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.İşyeri.Name = "İşyeri";
            this.İşyeri.Size = new System.Drawing.Size(42, 16);
            this.İşyeri.TabIndex = 21;
            this.İşyeri.Text = "İş yeri";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(683, 88);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "Bölüm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(683, 129);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "Fabrika";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(683, 176);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 16);
            this.label10.TabIndex = 24;
            this.label10.Text = "Ambar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(454, 230);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Malzeme Bilgileri";
            // 
            // ambarTableAdapter
            // 
            this.ambarTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kod,
            this.Malzeme,
            this.Brim,
            this.Stok,
            this.Adet,
            this.BrimFiyat,
            this.KDV,
            this.Total,
            this.Sil});
            this.dataGridView1.Location = new System.Drawing.Point(24, 276);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(993, 150);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // Kod
            // 
            this.Kod.FillWeight = 50F;
            this.Kod.HeaderText = "Kod";
            this.Kod.Name = "Kod";
            this.Kod.Width = 50;
            // 
            // Malzeme
            // 
            this.Malzeme.HeaderText = "Malzeme";
            this.Malzeme.Name = "Malzeme";
            this.Malzeme.Width = 150;
            // 
            // Brim
            // 
            this.Brim.HeaderText = "Brim";
            this.Brim.Name = "Brim";
            this.Brim.ReadOnly = true;
            // 
            // Stok
            // 
            this.Stok.HeaderText = "Stok";
            this.Stok.Name = "Stok";
            this.Stok.ReadOnly = true;
            this.Stok.Width = 150;
            // 
            // Adet
            // 
            this.Adet.HeaderText = "Adet";
            this.Adet.Name = "Adet";
            // 
            // BrimFiyat
            // 
            this.BrimFiyat.HeaderText = "BrimFiyat";
            this.BrimFiyat.Name = "BrimFiyat";
            // 
            // KDV
            // 
            this.KDV.HeaderText = "KDV";
            this.KDV.Name = "KDV";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // Sil
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            this.Sil.DefaultCellStyle = dataGridViewCellStyle2;
            this.Sil.HeaderText = "Sil";
            this.Sil.Name = "Sil";
            // 
            // CariKod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 593);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.İşyeri);
            this.Controls.Add(this.Cambar);
            this.Controls.Add(this.Cfabrika);
            this.Controls.Add(this.Cbolum);
            this.Controls.Add(this.Cisyeri);
            this.Controls.Add(this.CariTicari);
            this.Controls.Add(this.CariOdemeler);
            this.Controls.Add(this.Cariunvan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TicariText);
            this.Controls.Add(this.Odeme);
            this.Controls.Add(this.UnvanCari);
            this.Controls.Add(this.KodCari);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BelgeNo);
            this.Controls.Add(this.Tarih);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Zaman);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fisNo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CariKod";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ambarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.denemeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fisNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Zaman;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tarih;
        private System.Windows.Forms.TextBox BelgeNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Cariunvan;
        private System.Windows.Forms.Label CariOdemeler;
        private System.Windows.Forms.Label CariTicari;
        private System.Windows.Forms.ComboBox Cisyeri;
        private System.Windows.Forms.ComboBox Cbolum;
        private System.Windows.Forms.ComboBox Cfabrika;
        private System.Windows.Forms.ComboBox Cambar;
        private System.Windows.Forms.Label İşyeri;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private DenemeDataSet denemeDataSet;
        private System.Windows.Forms.BindingSource ambarBindingSource;
        private DenemeDataSetTableAdapters.AmbarTableAdapter ambarTableAdapter;
        public System.Windows.Forms.TextBox KodCari;
        public System.Windows.Forms.TextBox UnvanCari;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox Odeme;
        public System.Windows.Forms.TextBox TicariText;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Malzeme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stok;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adet;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrimFiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn KDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewButtonColumn Sil;
    }
}

