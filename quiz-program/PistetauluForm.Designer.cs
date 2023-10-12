namespace quiz_program
{
    partial class PistetauluForm
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
            this.aloitusvalikkoonNappi = new System.Windows.Forms.Button();
            this.tuloksetLabel = new System.Windows.Forms.Label();
            this.pisteetLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // aloitusvalikkoonNappi
            // 
            this.aloitusvalikkoonNappi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.aloitusvalikkoonNappi.Location = new System.Drawing.Point(306, 173);
            this.aloitusvalikkoonNappi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aloitusvalikkoonNappi.Name = "aloitusvalikkoonNappi";
            this.aloitusvalikkoonNappi.Size = new System.Drawing.Size(181, 97);
            this.aloitusvalikkoonNappi.TabIndex = 0;
            this.aloitusvalikkoonNappi.Text = "Palaa aloitusvalikkoon";
            this.aloitusvalikkoonNappi.UseVisualStyleBackColor = true;
            this.aloitusvalikkoonNappi.Click += new System.EventHandler(this.aloitusvalikkoonNappi_Click);
            // 
            // tuloksetLabel
            // 
            this.tuloksetLabel.AutoSize = true;
            this.tuloksetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.tuloksetLabel.Location = new System.Drawing.Point(29, 22);
            this.tuloksetLabel.Name = "tuloksetLabel";
            this.tuloksetLabel.Size = new System.Drawing.Size(87, 25);
            this.tuloksetLabel.TabIndex = 1;
            this.tuloksetLabel.Text = "Tulokset";
            // 
            // pisteetLabel
            // 
            this.pisteetLabel.AutoSize = true;
            this.pisteetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.pisteetLabel.Location = new System.Drawing.Point(189, 22);
            this.pisteetLabel.Name = "pisteetLabel";
            this.pisteetLabel.Size = new System.Drawing.Size(71, 25);
            this.pisteetLabel.TabIndex = 2;
            this.pisteetLabel.Text = "Pisteet";
            // 
            // PistetauluForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 293);
            this.Controls.Add(this.pisteetLabel);
            this.Controls.Add(this.tuloksetLabel);
            this.Controls.Add(this.aloitusvalikkoonNappi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PistetauluForm";
            this.Text = "PistetauluForm";
            this.Load += new System.EventHandler(this.PistetauluForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button aloitusvalikkoonNappi;
        private System.Windows.Forms.Label tuloksetLabel;
        private System.Windows.Forms.Label pisteetLabel;
    }
}