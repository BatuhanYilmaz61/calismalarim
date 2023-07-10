namespace Tiger
{
    partial class Odeme
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
            this.OdemeDtw = new System.Windows.Forms.DataGridView();
            this.denemeDataSet3 = new Tiger.DenemeDataSet3();
            this.ödemelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ödemelerTableAdapter = new Tiger.DenemeDataSet3TableAdapters.ÖdemelerTableAdapter();
            this.Ödemeler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.OdemeDtw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.denemeDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ödemelerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // OdemeDtw
            // 
            this.OdemeDtw.AutoGenerateColumns = false;
            this.OdemeDtw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OdemeDtw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ödemeler});
            this.OdemeDtw.DataSource = this.ödemelerBindingSource;
            this.OdemeDtw.Location = new System.Drawing.Point(156, 41);
            this.OdemeDtw.Name = "OdemeDtw";
            this.OdemeDtw.Size = new System.Drawing.Size(145, 174);
            this.OdemeDtw.TabIndex = 0;
            this.OdemeDtw.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.OdemeDtw_CellMouseDoubleClick);
            // 
            // denemeDataSet3
            // 
            this.denemeDataSet3.DataSetName = "DenemeDataSet3";
            this.denemeDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ödemelerBindingSource
            // 
            this.ödemelerBindingSource.DataMember = "Ödemeler";
            this.ödemelerBindingSource.DataSource = this.denemeDataSet3;
            // 
            // ödemelerTableAdapter
            // 
            this.ödemelerTableAdapter.ClearBeforeFill = true;
            // 
            // Ödemeler
            // 
            this.Ödemeler.DataPropertyName = "Ödemeler";
            this.Ödemeler.HeaderText = "Ödemeler";
            this.Ödemeler.Name = "Ödemeler";
            // 
            // Odeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 253);
            this.Controls.Add(this.OdemeDtw);
            this.Name = "Odeme";
            this.Text = "Odeme";
            this.Load += new System.EventHandler(this.Odeme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OdemeDtw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.denemeDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ödemelerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView OdemeDtw;
        private DenemeDataSet3 denemeDataSet3;
        private System.Windows.Forms.BindingSource ödemelerBindingSource;
        private DenemeDataSet3TableAdapters.ÖdemelerTableAdapter ödemelerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ödemeler;
    }
}