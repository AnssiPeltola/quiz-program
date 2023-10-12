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
            this.kysymysLabel = new System.Windows.Forms.Label();
            this.VastausNappi1 = new System.Windows.Forms.Button();
            this.VastausNappi2 = new System.Windows.Forms.Button();
            this.VastausNappi3 = new System.Windows.Forms.Button();
            this.VastausNappi4 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerLabel = new System.Windows.Forms.Label();
            this.pisteetLabel = new System.Windows.Forms.Label();
            this.virheetLabel = new System.Windows.Forms.Label();
            this.luovutusNappi = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kysymysLabel
            // 
            this.kysymysLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kysymysLabel.AutoSize = true;
            this.kysymysLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.kysymysLabel.Location = new System.Drawing.Point(349, 65);
            this.kysymysLabel.Name = "kysymysLabel";
            this.kysymysLabel.Size = new System.Drawing.Size(88, 25);
            this.kysymysLabel.TabIndex = 1;
            this.kysymysLabel.Text = "kysymys";
            this.kysymysLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VastausNappi1
            // 
            this.VastausNappi1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VastausNappi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.VastausNappi1.Location = new System.Drawing.Point(18, 384);
            this.VastausNappi1.Name = "VastausNappi1";
            this.VastausNappi1.Size = new System.Drawing.Size(442, 155);
            this.VastausNappi1.TabIndex = 2;
            this.VastausNappi1.Text = "vastaus1";
            this.VastausNappi1.UseVisualStyleBackColor = true;
            this.VastausNappi1.Click += new System.EventHandler(this.AnswerButton_Click);
            // 
            // VastausNappi2
            // 
            this.VastausNappi2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VastausNappi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.VastausNappi2.Location = new System.Drawing.Point(500, 384);
            this.VastausNappi2.Name = "VastausNappi2";
            this.VastausNappi2.Size = new System.Drawing.Size(442, 155);
            this.VastausNappi2.TabIndex = 3;
            this.VastausNappi2.Text = "vastaus2";
            this.VastausNappi2.UseVisualStyleBackColor = true;
            this.VastausNappi2.Click += new System.EventHandler(this.AnswerButton_Click);
            // 
            // VastausNappi3
            // 
            this.VastausNappi3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VastausNappi3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.VastausNappi3.Location = new System.Drawing.Point(18, 557);
            this.VastausNappi3.Name = "VastausNappi3";
            this.VastausNappi3.Size = new System.Drawing.Size(442, 155);
            this.VastausNappi3.TabIndex = 4;
            this.VastausNappi3.Text = "vastaus3";
            this.VastausNappi3.UseVisualStyleBackColor = true;
            this.VastausNappi3.Click += new System.EventHandler(this.AnswerButton_Click);
            // 
            // VastausNappi4
            // 
            this.VastausNappi4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VastausNappi4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.VastausNappi4.Location = new System.Drawing.Point(500, 557);
            this.VastausNappi4.Name = "VastausNappi4";
            this.VastausNappi4.Size = new System.Drawing.Size(442, 155);
            this.VastausNappi4.TabIndex = 5;
            this.VastausNappi4.Text = "vastaus4";
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
            this.timerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.timerLabel.Location = new System.Drawing.Point(808, 76);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(71, 41);
            this.timerLabel.TabIndex = 0;
            this.timerLabel.Text = "30 sec";
            // 
            // pisteetLabel
            // 
            this.pisteetLabel.AutoSize = true;
            this.pisteetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.pisteetLabel.Location = new System.Drawing.Point(88, 51);
            this.pisteetLabel.Name = "pisteetLabel";
            this.pisteetLabel.Size = new System.Drawing.Size(93, 25);
            this.pisteetLabel.TabIndex = 6;
            this.pisteetLabel.Text = "Pisteet: 0";
            // 
            // virheetLabel
            // 
            this.virheetLabel.AutoSize = true;
            this.virheetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.virheetLabel.Location = new System.Drawing.Point(88, 95);
            this.virheetLabel.Name = "virheetLabel";
            this.virheetLabel.Size = new System.Drawing.Size(213, 25);
            this.virheetLabel.TabIndex = 7;
            this.virheetLabel.Text = "Väärät vastaukset: 0 /5";
            // 
            // luovutusNappi
            // 
            this.luovutusNappi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.luovutusNappi.Location = new System.Drawing.Point(430, 60);
            this.luovutusNappi.Name = "luovutusNappi";
            this.luovutusNappi.Size = new System.Drawing.Size(140, 60);
            this.luovutusNappi.TabIndex = 8;
            this.luovutusNappi.Text = "Luovutan";
            this.luovutusNappi.UseVisualStyleBackColor = true;
            this.luovutusNappi.Click += new System.EventHandler(this.luovutusNappi_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.kysymysLabel, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(93, 196);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(786, 156);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // PeliForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 724);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.luovutusNappi);
            this.Controls.Add(this.virheetLabel);
            this.Controls.Add(this.pisteetLabel);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.VastausNappi4);
            this.Controls.Add(this.VastausNappi3);
            this.Controls.Add(this.VastausNappi2);
            this.Controls.Add(this.VastausNappi1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PeliForm";
            this.Text = "PeliForm";
            this.Load += new System.EventHandler(this.PeliForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label kysymysLabel;
        private System.Windows.Forms.Button VastausNappi1;
        private System.Windows.Forms.Button VastausNappi2;
        private System.Windows.Forms.Button VastausNappi3;
        private System.Windows.Forms.Button VastausNappi4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Label pisteetLabel;
        private System.Windows.Forms.Label virheetLabel;
        private System.Windows.Forms.Button luovutusNappi;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}