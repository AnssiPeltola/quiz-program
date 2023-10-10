namespace quiz_program
{
    partial class PeliForm
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
            this.aloitaNappi = new System.Windows.Forms.Button();
            this.kysymysLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // aloitaNappi
            // 
            this.aloitaNappi.Location = new System.Drawing.Point(482, 12);
            this.aloitaNappi.Name = "aloitaNappi";
            this.aloitaNappi.Size = new System.Drawing.Size(75, 23);
            this.aloitaNappi.TabIndex = 0;
            this.aloitaNappi.Text = "Aloita";
            this.aloitaNappi.UseVisualStyleBackColor = true;
            this.aloitaNappi.Click += new System.EventHandler(this.aloitaNappi_Click);
            // 
            // kysymysLabel
            // 
            this.kysymysLabel.AutoSize = true;
            this.kysymysLabel.Location = new System.Drawing.Point(479, 269);
            this.kysymysLabel.Name = "kysymysLabel";
            this.kysymysLabel.Size = new System.Drawing.Size(44, 16);
            this.kysymysLabel.TabIndex = 1;
            this.kysymysLabel.Text = "label1";
            // 
            // PeliForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 646);
            this.Controls.Add(this.kysymysLabel);
            this.Controls.Add(this.aloitaNappi);
            this.Name = "PeliForm";
            this.Text = "PeliForm";
            this.Load += new System.EventHandler(this.PeliForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button aloitaNappi;
        private System.Windows.Forms.Label kysymysLabel;
    }
}