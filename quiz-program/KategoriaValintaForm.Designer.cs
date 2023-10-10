namespace quiz_program
{
    partial class KategoriaValintaForm
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
            this.radioNappi1 = new System.Windows.Forms.RadioButton();
            this.radioNappi2 = new System.Windows.Forms.RadioButton();
            this.radioNappi3 = new System.Windows.Forms.RadioButton();
            this.radioNappi4 = new System.Windows.Forms.RadioButton();
            this.pelaajaNimiBox = new System.Windows.Forms.TextBox();
            this.pelaaNappi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioNappi1
            // 
            this.radioNappi1.AutoSize = true;
            this.radioNappi1.Location = new System.Drawing.Point(275, 250);
            this.radioNappi1.Name = "radioNappi1";
            this.radioNappi1.Size = new System.Drawing.Size(64, 20);
            this.radioNappi1.TabIndex = 0;
            this.radioNappi1.TabStop = true;
            this.radioNappi1.Text = "Tiede";
            this.radioNappi1.UseVisualStyleBackColor = true;
            // 
            // radioNappi2
            // 
            this.radioNappi2.AutoSize = true;
            this.radioNappi2.Location = new System.Drawing.Point(380, 250);
            this.radioNappi2.Name = "radioNappi2";
            this.radioNappi2.Size = new System.Drawing.Size(129, 20);
            this.radioNappi2.TabIndex = 1;
            this.radioNappi2.TabStop = true;
            this.radioNappi2.Text = "Luonto ja eläimet";
            this.radioNappi2.UseVisualStyleBackColor = true;
            // 
            // radioNappi3
            // 
            this.radioNappi3.AutoSize = true;
            this.radioNappi3.Location = new System.Drawing.Point(271, 296);
            this.radioNappi3.Name = "radioNappi3";
            this.radioNappi3.Size = new System.Drawing.Size(87, 20);
            this.radioNappi3.TabIndex = 2;
            this.radioNappi3.TabStop = true;
            this.radioNappi3.Text = "Maantieto";
            this.radioNappi3.UseVisualStyleBackColor = true;
            // 
            // radioNappi4
            // 
            this.radioNappi4.AutoSize = true;
            this.radioNappi4.Location = new System.Drawing.Point(396, 296);
            this.radioNappi4.Name = "radioNappi4";
            this.radioNappi4.Size = new System.Drawing.Size(127, 20);
            this.radioNappi4.TabIndex = 3;
            this.radioNappi4.TabStop = true;
            this.radioNappi4.Text = "Kaikki kategoriat";
            this.radioNappi4.UseVisualStyleBackColor = true;
            // 
            // pelaajaNimiBox
            // 
            this.pelaajaNimiBox.Location = new System.Drawing.Point(264, 172);
            this.pelaajaNimiBox.Name = "pelaajaNimiBox";
            this.pelaajaNimiBox.Size = new System.Drawing.Size(259, 22);
            this.pelaajaNimiBox.TabIndex = 4;
            // 
            // pelaaNappi
            // 
            this.pelaaNappi.Location = new System.Drawing.Point(322, 373);
            this.pelaaNappi.Name = "pelaaNappi";
            this.pelaaNappi.Size = new System.Drawing.Size(126, 23);
            this.pelaaNappi.TabIndex = 5;
            this.pelaaNappi.Text = "Pelaa peliä";
            this.pelaaNappi.UseVisualStyleBackColor = true;
            this.pelaaNappi.Click += new System.EventHandler(this.pelaaNappi_Click);
            // 
            // KategoriaValintaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pelaaNappi);
            this.Controls.Add(this.pelaajaNimiBox);
            this.Controls.Add(this.radioNappi4);
            this.Controls.Add(this.radioNappi3);
            this.Controls.Add(this.radioNappi2);
            this.Controls.Add(this.radioNappi1);
            this.Name = "KategoriaValintaForm";
            this.Text = "KategoriaValintaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioNappi1;
        private System.Windows.Forms.RadioButton radioNappi2;
        private System.Windows.Forms.RadioButton radioNappi3;
        private System.Windows.Forms.RadioButton radioNappi4;
        private System.Windows.Forms.TextBox pelaajaNimiBox;
        private System.Windows.Forms.Button pelaaNappi;
    }
}