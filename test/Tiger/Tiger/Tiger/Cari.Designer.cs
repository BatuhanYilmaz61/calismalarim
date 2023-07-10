namespace Tiger
{
    partial class Cari
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
            this.CariDtw = new System.Windows.Forms.DataGridView();
            this.denemeDataSet2 = new Tiger.DenemeDataSet2();
            this.cari1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cari1TableAdapter = new Tiger.DenemeDataSet2TableAdapters.Cari1TableAdapter();
            this.Kod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unvan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.CariDtw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.denemeDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cari1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CariDtw
            // 
            this.CariDtw.AutoGenerateColumns = false;
            this.CariDtw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CariDtw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kod,
            this.Unvan,
            this.adresDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.tCDataGridViewTextBoxColumn});
            this.CariDtw.DataSource = this.cari1BindingSource;
            this.CariDtw.Location = new System.Drawing.Point(102, 95);
            this.CariDtw.Name = "CariDtw";
            this.CariDtw.Size = new System.Drawing.Size(539, 250);
            this.CariDtw.TabIndex = 0;
            this.CariDtw.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CariDtw_CellDoubleClick);
            // 
            // denemeDataSet2
            // 
            this.denemeDataSet2.DataSetName = "DenemeDataSet2";
            this.denemeDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cari1BindingSource
            // 
            this.cari1BindingSource.DataMember = "Cari1";
            this.cari1BindingSource.DataSource = this.denemeDataSet2;
            // 
            // cari1TableAdapter
            // 
            this.cari1TableAdapter.ClearBeforeFill = true;
            // 
            // Kod
            // 
            this.Kod.DataPropertyName = "Kod";
            this.Kod.HeaderText = "Kod";
            this.Kod.Name = "Kod";
            // 
            // Unvan
            // 
            this.Unvan.DataPropertyName = "Unvan";
            this.Unvan.HeaderText = "Unvan";
            this.Unvan.Name = "Unvan";
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "Adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "Mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            // 
            // tCDataGridViewTextBoxColumn
            // 
            this.tCDataGridViewTextBoxColumn.DataPropertyName = "TC";
            this.tCDataGridViewTextBoxColumn.HeaderText = "TC";
            this.tCDataGridViewTextBoxColumn.Name = "tCDataGridViewTextBoxColumn";
            // 
            // Cari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CariDtw);
            this.Name = "Cari";
            this.Text = "Cari";
            this.Load += new System.EventHandler(this.Cari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CariDtw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.denemeDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cari1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CariDtw;
        private DenemeDataSet2 denemeDataSet2;
        private System.Windows.Forms.BindingSource cari1BindingSource;
        private DenemeDataSet2TableAdapters.Cari1TableAdapter cari1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unvan;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCDataGridViewTextBoxColumn;
    }
}