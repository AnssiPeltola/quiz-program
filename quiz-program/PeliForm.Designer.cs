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
            this.kysymysLabel.Location = new System.Drawing.Point(411, 154);
            this.kysymysLabel.Name = "kysymysLabel";
            this.kysymysLabel.Size = new System.Drawing.Size(44, 16);
            this.kysymysLabel.TabIndex = 1;
            this.kysymysLabel.Text = "label1";
            // 
            // VastausNappi1
            // 
            this.VastausNappi1.Location = new System.Drawing.Point(296, 288);
            this.VastausNappi1.Name = "VastausNappi1";
            this.VastausNappi1.Size = new System.Drawing.Size(214, 70);
            this.VastausNappi1.TabIndex = 2;
            this.VastausNappi1.Text = "button1";
            this.VastausNappi1.UseVisualStyleBackColor = true;
            this.VastausNappi1.Click += new System.EventHandler(this.AnswerButton_Click);
            // 
            // VastausNappi2
            // 
            this.VastausNappi2.Location = new System.Drawing.Point(606, 284);
            this.VastausNappi2.Name = "VastausNappi2";
            this.VastausNappi2.Size = new System.Drawing.Size(247, 78);
            this.VastausNappi2.TabIndex = 3;
            this.VastausNappi2.Text = "button2";
            this.VastausNappi2.UseVisualStyleBackColor = true;
            this.VastausNappi2.Click += new System.EventHandler(this.AnswerButton_Click);
            // 
            // VastausNappi3
            // 
            this.VastausNappi3.Location = new System.Drawing.Point(296, 417);
            this.VastausNappi3.Name = "VastausNappi3";
            this.VastausNappi3.Size = new System.Drawing.Size(214, 57);
            this.VastausNappi3.TabIndex = 4;
            this.VastausNappi3.Text = "button3";
            this.VastausNappi3.UseVisualStyleBackColor = true;
            this.VastausNappi3.Click += new System.EventHandler(this.AnswerButton_Click);
            // 
            // VastausNappi4
            // 
            this.VastausNappi4.Location = new System.Drawing.Point(606, 417);
            this.VastausNappi4.Name = "VastausNappi4";
            this.VastausNappi4.Size = new System.Drawing.Size(247, 57);
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
            this.timerLabel.Location = new System.Drawing.Point(763, 76);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(114, 41);
            this.timerLabel.TabIndex = 0;
            this.timerLabel.Text = "30 sec";
            // 
            // PeliForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 646);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.VastausNappi4);
            this.Controls.Add(this.VastausNappi3);
            this.Controls.Add(this.VastausNappi2);
            this.Controls.Add(this.VastausNappi1);
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
        private System.Windows.Forms.Button VastausNappi1;
        private System.Windows.Forms.Button VastausNappi2;
        private System.Windows.Forms.Button VastausNappi3;
        private System.Windows.Forms.Button VastausNappi4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timerLabel;
    }
}