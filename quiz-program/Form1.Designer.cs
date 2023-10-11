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
            this.pistetauluNappi = new System.Windows.Forms.Button();
            this.suljeNappi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(474, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hieno tietovisa!!";
            // 
            // pelaaNappi
            // 
            this.pelaaNappi.Location = new System.Drawing.Point(90, 354);
            this.pelaaNappi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pelaaNappi.Name = "pelaaNappi";
            this.pelaaNappi.Size = new System.Drawing.Size(450, 162);
            this.pelaaNappi.TabIndex = 1;
            this.pelaaNappi.Text = "Pelaa peliä";
            this.pelaaNappi.UseVisualStyleBackColor = true;
            this.pelaaNappi.Click += new System.EventHandler(this.pelaaNappi_Click);
            // 
            // pistetauluNappi
            // 
            this.pistetauluNappi.Location = new System.Drawing.Point(585, 354);
            this.pistetauluNappi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pistetauluNappi.Name = "pistetauluNappi";
            this.pistetauluNappi.Size = new System.Drawing.Size(450, 162);
            this.pistetauluNappi.TabIndex = 2;
            this.pistetauluNappi.Text = "Näytä pistetaulu";
            this.pistetauluNappi.UseVisualStyleBackColor = true;
            this.pistetauluNappi.Click += new System.EventHandler(this.pistetauluNappi_Click);
            // 
            // suljeNappi
            // 
            this.suljeNappi.Location = new System.Drawing.Point(521, 622);
            this.suljeNappi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.suljeNappi.Name = "suljeNappi";
            this.suljeNappi.Size = new System.Drawing.Size(83, 38);
            this.suljeNappi.TabIndex = 3;
            this.suljeNappi.Text = "Sulje";
            this.suljeNappi.UseVisualStyleBackColor = true;
            this.suljeNappi.Click += new System.EventHandler(this.suljeNappi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 691);
            this.Controls.Add(this.suljeNappi);
            this.Controls.Add(this.pistetauluNappi);
            this.Controls.Add(this.pelaaNappi);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button pelaaNappi;
        private System.Windows.Forms.Button pistetauluNappi;
        private System.Windows.Forms.Button suljeNappi;
    }
}

