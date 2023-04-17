namespace RestClient
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GetAccsesToken = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // GetAccsesToken
            // 
            this.GetAccsesToken.Location = new System.Drawing.Point(309, 121);
            this.GetAccsesToken.Name = "GetAccsesToken";
            this.GetAccsesToken.Size = new System.Drawing.Size(127, 53);
            this.GetAccsesToken.TabIndex = 0;
            this.GetAccsesToken.Text = "GetAccsesToken";
            this.GetAccsesToken.UseVisualStyleBackColor = true;
            this.GetAccsesToken.Click += new System.EventHandler(this.GetAccsesToken_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(202, 180);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(351, 160);
            this.textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.GetAccsesToken);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button GetAccsesToken;
        private TextBox textBox1;
    }
}