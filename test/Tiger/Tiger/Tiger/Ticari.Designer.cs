namespace Tiger
{
    partial class Ticari
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
            this.TicariDtw = new System.Windows.Forms.DataGridView();
            this.denemeDataSet4 = new Tiger.DenemeDataSet4();
            this.ticariİslemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticari_İslemTableAdapter = new Tiger.DenemeDataSet4TableAdapters.Ticari_İslemTableAdapter();
            this.Ticari_İslem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TicariDtw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.denemeDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticariİslemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TicariDtw
            // 
            this.TicariDtw.AutoGenerateColumns = false;
            this.TicariDtw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TicariDtw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ticari_İslem});
            this.TicariDtw.DataSource = this.ticariİslemBindingSource;
            this.TicariDtw.Location = new System.Drawing.Point(125, 56);
            this.TicariDtw.Name = "TicariDtw";
            this.TicariDtw.Size = new System.Drawing.Size(143, 236);
            this.TicariDtw.TabIndex = 0;
            this.TicariDtw.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // denemeDataSet4
            // 
            this.denemeDataSet4.DataSetName = "DenemeDataSet4";
            this.denemeDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticariİslemBindingSource
            // 
            this.ticariİslemBindingSource.DataMember = "Ticari_İslem";
            this.ticariİslemBindingSource.DataSource = this.denemeDataSet4;
            // 
            // ticari_İslemTableAdapter
            // 
            this.ticari_İslemTableAdapter.ClearBeforeFill = true;
            // 
            // Ticari_İslem
            // 
            this.Ticari_İslem.DataPropertyName = "Ticari_İslem";
            this.Ticari_İslem.HeaderText = "Ticari_İslem";
            this.Ticari_İslem.Name = "Ticari_İslem";
            // 
            // Ticari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 364);
            this.Controls.Add(this.TicariDtw);
            this.Name = "Ticari";
            this.Text = "Ticari";
            this.Load += new System.EventHandler(this.Ticari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TicariDtw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.denemeDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticariİslemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TicariDtw;
        private DenemeDataSet4 denemeDataSet4;
        private System.Windows.Forms.BindingSource ticariİslemBindingSource;
        private DenemeDataSet4TableAdapters.Ticari_İslemTableAdapter ticari_İslemTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ticari_İslem;
    }
}