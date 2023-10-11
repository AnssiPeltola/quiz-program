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
            this.components = new System.ComponentModel.Container();
            this.aloitaNappi = new System.Windows.Forms.Button();
            this.kysymysLabel = new System.Windows.Forms.Label();
            this.VastausNappi1 = new System.Windows.Forms.Button();
            this.VastausNappi2 = new System.Windows.Forms.Button();
            this.VastausNappi3 = new System.Windows.Forms.Button();
            this.VastausNappi4 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerLabel = new System.Windows.Forms.Label();
            this.pisteetLabel = new System.Windows.Forms.Label();
            this.virheetLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // aloitaNappi
            // 
            this.aloitaNappi.Location = new System.Drawing.Point(542, 15);
            this.aloitaNappi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aloitaNappi.Name = "aloitaNappi";
            this.aloitaNappi.Size = new System.Drawing.Size(84, 29);
            this.aloitaNappi.TabIndex = 0;
            this.aloitaNappi.Text = "Aloita";
            this.aloitaNappi.UseVisualStyleBackColor = true;
            this.aloitaNappi.Click += new System.EventHandler(this.aloitaNappi_Click);
            // 
            // kysymysLabel
            // 
            this.kysymysLabel.AutoSize = true;
            this.kysymysLabel.Location = new System.Drawing.Point(462, 192);
            this.kysymysLabel.Name = "kysymysLabel";
            this.kysymysLabel.Size = new System.Drawing.Size(51, 20);
            this.kysymysLabel.TabIndex = 1;
            this.kysymysLabel.Text = "label1";
            // 
            // VastausNappi1
            // 
            this.VastausNappi1.Location = new System.Drawing.Point(333, 360);
            this.VastausNappi1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.VastausNappi1.Name = "VastausNappi1";
            this.VastausNappi1.Size = new System.Drawing.Size(241, 88);
            this.VastausNappi1.TabIndex = 2;
            this.VastausNappi1.Text = "button1";
            this.VastausNappi1.UseVisualStyleBackColor = true;
            this.VastausNappi1.Click += new System.EventHandler(this.AnswerButton_Click);
            // 
            // VastausNappi2
            // 
            this.VastausNappi2.Location = new System.Drawing.Point(682, 355);
            this.VastausNappi2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.VastausNappi2.Name = "VastausNappi2";
            this.VastausNappi2.Size = new System.Drawing.Size(278, 98);
            this.VastausNappi2.TabIndex = 3;
            this.VastausNappi2.Text = "button2";
            this.VastausNappi2.UseVisualStyleBackColor = true;
            this.VastausNappi2.Click += new System.EventHandler(this.AnswerButton_Click);
            // 
            // VastausNappi3
            // 
            this.VastausNappi3.Location = new System.Drawing.Point(333, 521);
            this.VastausNappi3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.VastausNappi3.Name = "VastausNappi3";
            this.VastausNappi3.Size = new System.Drawing.Size(241, 71);
            this.VastausNappi3.TabIndex = 4;
            this.VastausNappi3.Text = "button3";
            this.VastausNappi3.UseVisualStyleBackColor = true;
            this.VastausNappi3.Click += new System.EventHandler(this.AnswerButton_Click);
            // 
            // VastausNappi4
            // 
            this.VastausNappi4.Location = new System.Drawing.Point(682, 521);
            this.VastausNappi4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.VastausNappi4.Name = "VastausNappi4";
            this.VastausNappi4.Size = new System.Drawing.Size(278, 71);
            this.VastausNappi4.TabIndex = 5;
            this.VastausNappi4.Text = "button4";
            this.VastausNappi4.UseVisualStyleBackColor = true;
            this.VastausNappi4.Click += new System.EventHandler(this.AnswerButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerLabel
            // 
            this.timerLabel.Location = new System.Drawing.Point(858, 95);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(128, 51);
            this.timerLabel.TabIndex = 0;
            this.timerLabel.Text = "30 sec";
            // 
            // pisteetLabel
            // 
            this.pisteetLabel.AutoSize = true;
            this.pisteetLabel.Location = new System.Drawing.Point(341, 95);
            this.pisteetLabel.Name = "pisteetLabel";
            this.pisteetLabel.Size = new System.Drawing.Size(62, 20);
            this.pisteetLabel.TabIndex = 6;
            this.pisteetLabel.Text = "Pisteet:";
            // 
            // virheetLabel
            // 
            this.virheetLabel.AutoSize = true;
            this.virheetLabel.Location = new System.Drawing.Point(345, 137);
            this.virheetLabel.Name = "virheetLabel";
            this.virheetLabel.Size = new System.Drawing.Size(142, 20);
            this.virheetLabel.TabIndex = 7;
            this.virheetLabel.Text = "Väärät vastaukset:";
            // 
            // PeliForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 808);
            this.Controls.Add(this.virheetLabel);
            this.Controls.Add(this.pisteetLabel);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.VastausNappi4);
            this.Controls.Add(this.VastausNappi3);
            this.Controls.Add(this.VastausNappi2);
            this.Controls.Add(this.VastausNappi1);
            this.Controls.Add(this.kysymysLabel);
            this.Controls.Add(this.aloitaNappi);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PeliForm";
            this.Text = "PeliForm";
            this.Load += new System.EventHandler(this.PeliForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button aloitaNappi;
        private System.Windows.Forms.Label kysymysLabel;
        private System.Windows.Forms.Button VastausNappi1;
        private System.Windows.Forms.Button VastausNappi2;
        private System.Windows.Forms.Button VastausNappi3;
        private System.Windows.Forms.Button VastausNappi4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Label pisteetLabel;
        private System.Windows.Forms.Label virheetLabel;
    }
}