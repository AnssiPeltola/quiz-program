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
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(379, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tietovisakisa";
            // 
            // pelaaNappi
            // 
            this.pelaaNappi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.pelaaNappi.Location = new System.Drawing.Point(80, 283);
            this.pelaaNappi.Name = "pelaaNappi";
            this.pelaaNappi.Size = new System.Drawing.Size(400, 130);
            this.pelaaNappi.TabIndex = 1;
            this.pelaaNappi.Text = "Pelaa peliä";
            this.pelaaNappi.UseVisualStyleBackColor = true;
            this.pelaaNappi.Click += new System.EventHandler(this.pelaaNappi_Click);
            // 
            // pistetauluNappi
            // 
            this.pistetauluNappi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.pistetauluNappi.Location = new System.Drawing.Point(520, 283);
            this.pistetauluNappi.Name = "pistetauluNappi";
            this.pistetauluNappi.Size = new System.Drawing.Size(400, 130);
            this.pistetauluNappi.TabIndex = 2;
            this.pistetauluNappi.Text = "Näytä pistetaulu";
            this.pistetauluNappi.UseVisualStyleBackColor = true;
            this.pistetauluNappi.Click += new System.EventHandler(this.pistetauluNappi_Click);
            // 
            // suljeNappi
            // 
            this.suljeNappi.Location = new System.Drawing.Point(896, 511);
            this.suljeNappi.Name = "suljeNappi";
            this.suljeNappi.Size = new System.Drawing.Size(74, 30);
            this.suljeNappi.TabIndex = 3;
            this.suljeNappi.Text = "Sulje";
            this.suljeNappi.UseVisualStyleBackColor = true;
            this.suljeNappi.Click += new System.EventHandler(this.suljeNappi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(458, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kysymykset loi ChatGPT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.suljeNappi);
            this.Controls.Add(this.pistetauluNappi);
            this.Controls.Add(this.pelaaNappi);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Tietovisakisa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button pelaaNappi;
        private System.Windows.Forms.Button pistetauluNappi;
        private System.Windows.Forms.Button suljeNappi;
        private System.Windows.Forms.Label label2;
    }
}

