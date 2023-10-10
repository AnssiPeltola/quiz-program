namespace quiz_program
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.pelaaNappi = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.suljeNappi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(276, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Päävalikko";
            // 
            // pelaaNappi
            // 
            this.pelaaNappi.Location = new System.Drawing.Point(79, 283);
            this.pelaaNappi.Name = "pelaaNappi";
            this.pelaaNappi.Size = new System.Drawing.Size(422, 129);
            this.pelaaNappi.TabIndex = 1;
            this.pelaaNappi.Text = "Pelaa peliä";
            this.pelaaNappi.UseVisualStyleBackColor = true;
            this.pelaaNappi.Click += new System.EventHandler(this.pelaaNappi_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(609, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(331, 183);
            this.button2.TabIndex = 2;
            this.button2.Text = "Pistetaulu";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // suljeNappi
            // 
            this.suljeNappi.Location = new System.Drawing.Point(426, 502);
            this.suljeNappi.Name = "suljeNappi";
            this.suljeNappi.Size = new System.Drawing.Size(75, 23);
            this.suljeNappi.TabIndex = 3;
            this.suljeNappi.Text = "Sulje";
            this.suljeNappi.UseVisualStyleBackColor = true;
            this.suljeNappi.Click += new System.EventHandler(this.suljeNappi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 565);
            this.Controls.Add(this.suljeNappi);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pelaaNappi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button pelaaNappi;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button suljeNappi;
    }
}

