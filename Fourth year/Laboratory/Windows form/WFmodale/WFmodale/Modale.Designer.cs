namespace WFmodale
{
    partial class Modale
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
            this.btnconferma = new System.Windows.Forms.Button();
            this.btnannulla = new System.Windows.Forms.Button();
            this.txtcognome = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnconferma
            // 
            this.btnconferma.Location = new System.Drawing.Point(207, 195);
            this.btnconferma.Name = "btnconferma";
            this.btnconferma.Size = new System.Drawing.Size(75, 23);
            this.btnconferma.TabIndex = 0;
            this.btnconferma.Text = "Conferma";
            this.btnconferma.UseVisualStyleBackColor = true;
            this.btnconferma.Click += new System.EventHandler(this.btnconferma_Click);
            // 
            // btnannulla
            // 
            this.btnannulla.Location = new System.Drawing.Point(207, 226);
            this.btnannulla.Name = "btnannulla";
            this.btnannulla.Size = new System.Drawing.Size(75, 23);
            this.btnannulla.TabIndex = 1;
            this.btnannulla.Text = "Annulla";
            this.btnannulla.UseVisualStyleBackColor = true;
            this.btnannulla.Click += new System.EventHandler(this.btnannulla_Click);
            // 
            // txtcognome
            // 
            this.txtcognome.Location = new System.Drawing.Point(13, 46);
            this.txtcognome.Name = "txtcognome";
            this.txtcognome.Size = new System.Drawing.Size(100, 20);
            this.txtcognome.TabIndex = 2;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(12, 96);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(100, 20);
            this.txtnome.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cognome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome";
            // 
            // Modale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txtcognome);
            this.Controls.Add(this.btnannulla);
            this.Controls.Add(this.btnconferma);
            this.Name = "Modale";
            this.Text = "Modale";
            this.Load += new System.EventHandler(this.Modale_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnconferma;
        private System.Windows.Forms.Button btnannulla;
        private System.Windows.Forms.TextBox txtcognome;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}