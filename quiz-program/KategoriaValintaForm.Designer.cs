﻿namespace quiz_program
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
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioNappi1
            // 
            this.radioNappi1.AutoSize = true;
            this.radioNappi1.Location = new System.Drawing.Point(3, 4);
            this.radioNappi1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioNappi1.Name = "radioNappi1";
            this.radioNappi1.Size = new System.Drawing.Size(73, 24);
            this.radioNappi1.TabIndex = 0;
            this.radioNappi1.Text = "Tiede";
            this.radioNappi1.UseVisualStyleBackColor = true;
            // 
            // radioNappi2
            // 
            this.radioNappi2.AutoSize = true;
            this.radioNappi2.Location = new System.Drawing.Point(172, 4);
            this.radioNappi2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioNappi2.Name = "radioNappi2";
            this.radioNappi2.Size = new System.Drawing.Size(155, 24);
            this.radioNappi2.TabIndex = 1;
            this.radioNappi2.Text = "Luonto ja eläimet";
            this.radioNappi2.UseVisualStyleBackColor = true;
            // 
            // radioNappi3
            // 
            this.radioNappi3.AutoSize = true;
            this.radioNappi3.Location = new System.Drawing.Point(3, 66);
            this.radioNappi3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioNappi3.Name = "radioNappi3";
            this.radioNappi3.Size = new System.Drawing.Size(105, 24);
            this.radioNappi3.TabIndex = 2;
            this.radioNappi3.Text = "Maantieto";
            this.radioNappi3.UseVisualStyleBackColor = true;
            // 
            // radioNappi4
            // 
            this.radioNappi4.AutoSize = true;
            this.radioNappi4.Checked = true;
            this.radioNappi4.Location = new System.Drawing.Point(172, 66);
            this.radioNappi4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioNappi4.Name = "radioNappi4";
            this.radioNappi4.Size = new System.Drawing.Size(150, 24);
            this.radioNappi4.TabIndex = 3;
            this.radioNappi4.TabStop = true;
            this.radioNappi4.Text = "Kaikki kategoriat";
            this.radioNappi4.UseVisualStyleBackColor = true;
            // 
            // pelaajaNimiBox
            // 
            this.pelaajaNimiBox.Location = new System.Drawing.Point(304, 215);
            this.pelaajaNimiBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pelaajaNimiBox.Name = "pelaajaNimiBox";
            this.pelaajaNimiBox.Size = new System.Drawing.Size(292, 26);
            this.pelaajaNimiBox.TabIndex = 4;
            // 
            // pelaaNappi
            // 
            this.pelaaNappi.Location = new System.Drawing.Point(394, 466);
            this.pelaaNappi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pelaaNappi.Name = "pelaaNappi";
            this.pelaaNappi.Size = new System.Drawing.Size(112, 38);
            this.pelaaNappi.TabIndex = 5;
            this.pelaaNappi.Text = "Pelaa peliä";
            this.pelaaNappi.UseVisualStyleBackColor = true;
            this.pelaaNappi.Click += new System.EventHandler(this.pelaaNappi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Anna nimimerkki:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.radioNappi1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.radioNappi2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.radioNappi3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.radioNappi4, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(281, 318);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(338, 125);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Valitse kategoria:";
            // 
            // KategoriaValintaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 566);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pelaaNappi);
            this.Controls.Add(this.pelaajaNimiBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "KategoriaValintaForm";
            this.Text = "KategoriaValintaForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
    }
}