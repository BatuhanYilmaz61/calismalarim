namespace Tiger
{
    partial class Form2
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
            this.MalzemeDtW = new System.Windows.Forms.DataGridView();
            this.kodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malzemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malzemeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.denemeDataSet1 = new Tiger.DenemeDataSet1();
            this.malzemeTableAdapter = new Tiger.DenemeDataSet1TableAdapters.MalzemeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.MalzemeDtW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.malzemeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.denemeDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // MalzemeDtW
            // 
            this.MalzemeDtW.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MalzemeDtW.AutoGenerateColumns = false;
            this.MalzemeDtW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MalzemeDtW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodDataGridViewTextBoxColumn,
            this.malzemeDataGridViewTextBoxColumn,
            this.stokDataGridViewTextBoxColumn,
            this.brimDataGridViewTextBoxColumn});
            this.MalzemeDtW.DataSource = this.malzemeBindingSource;
            this.MalzemeDtW.Location = new System.Drawing.Point(183, 52);
            this.MalzemeDtW.Name = "MalzemeDtW";
            this.MalzemeDtW.Size = new System.Drawing.Size(443, 319);
            this.MalzemeDtW.TabIndex = 0;
            this.MalzemeDtW.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.MalzemeDtW_RowEnter);
            // 
            // kodDataGridViewTextBoxColumn
            // 
            this.kodDataGridViewTextBoxColumn.DataPropertyName = "Kod";
            this.kodDataGridViewTextBoxColumn.HeaderText = "MalzemeKod";
            this.kodDataGridViewTextBoxColumn.Name = "kodDataGridViewTextBoxColumn";
            // 
            // malzemeDataGridViewTextBoxColumn
            // 
            this.malzemeDataGridViewTextBoxColumn.DataPropertyName = "Malzeme";
            this.malzemeDataGridViewTextBoxColumn.HeaderText = "Malzeme";
            this.malzemeDataGridViewTextBoxColumn.Name = "malzemeDataGridViewTextBoxColumn";
            // 
            // stokDataGridViewTextBoxColumn
            // 
            this.stokDataGridViewTextBoxColumn.DataPropertyName = "Stok";
            this.stokDataGridViewTextBoxColumn.HeaderText = "Stok";
            this.stokDataGridViewTextBoxColumn.Name = "stokDataGridViewTextBoxColumn";
            // 
            // brimDataGridViewTextBoxColumn
            // 
            this.brimDataGridViewTextBoxColumn.DataPropertyName = "Brim";
            this.brimDataGridViewTextBoxColumn.HeaderText = "Brim";
            this.brimDataGridViewTextBoxColumn.Name = "brimDataGridViewTextBoxColumn";
            // 
            // malzemeBindingSource
            // 
            this.malzemeBindingSource.DataMember = "Malzeme";
            this.malzemeBindingSource.DataSource = this.denemeDataSet1;
            // 
            // denemeDataSet1
            // 
            this.denemeDataSet1.DataSetName = "DenemeDataSet1";
            this.denemeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // malzemeTableAdapter
            // 
            this.malzemeTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MalzemeDtW);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MalzemeDtW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.malzemeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.denemeDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DenemeDataSet1 denemeDataSet1;
        private System.Windows.Forms.BindingSource malzemeBindingSource;
        private DenemeDataSet1TableAdapters.MalzemeTableAdapter malzemeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn malzemeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brimDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView MalzemeDtW;
    }
}