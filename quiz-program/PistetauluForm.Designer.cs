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
            this.SuspendLayout();
            // 
            // aloitusvalikkoonNappi
            // 
            this.aloitusvalikkoonNappi.Location = new System.Drawing.Point(606, 80);
            this.aloitusvalikkoonNappi.Name = "aloitusvalikkoonNappi";
            this.aloitusvalikkoonNappi.Size = new System.Drawing.Size(148, 76);
            this.aloitusvalikkoonNappi.TabIndex = 0;
            this.aloitusvalikkoonNappi.Text = "Palaa aloitusvalikkoon";
            this.aloitusvalikkoonNappi.UseVisualStyleBackColor = true;
            this.aloitusvalikkoonNappi.Click += new System.EventHandler(this.aloitusvalikkoonNappi_Click);
            // 
            // tuloksetLabel
            // 
            this.tuloksetLabel.AutoSize = true;
            this.tuloksetLabel.Location = new System.Drawing.Point(176, 80);
            this.tuloksetLabel.Name = "tuloksetLabel";
            this.tuloksetLabel.Size = new System.Drawing.Size(69, 20);
            this.tuloksetLabel.TabIndex = 1;
            this.tuloksetLabel.Text = "Tulokset";
            // 
            // PistetauluForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tuloksetLabel);
            this.Controls.Add(this.aloitusvalikkoonNappi);
            this.Name = "PistetauluForm";
            this.Text = "PistetauluForm";
            this.Load += new System.EventHandler(this.PistetauluForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button aloitusvalikkoonNappi;
        private System.Windows.Forms.Label tuloksetLabel;
    }
}