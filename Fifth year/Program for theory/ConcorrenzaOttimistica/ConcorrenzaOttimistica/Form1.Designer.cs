namespace ConcorrenzaOttimistica
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClicca = new System.Windows.Forms.Button();
            this.Rowcount = new System.Windows.Forms.Label();
            this.Contatore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClicca
            // 
            this.btnClicca.Location = new System.Drawing.Point(32, 134);
            this.btnClicca.Name = "btnClicca";
            this.btnClicca.Size = new System.Drawing.Size(75, 23);
            this.btnClicca.TabIndex = 0;
            this.btnClicca.Text = "Clicca";
            this.btnClicca.UseVisualStyleBackColor = true;
            this.btnClicca.Click += new System.EventHandler(this.btnClicca_Click);
            // 
            // Rowcount
            // 
            this.Rowcount.AutoSize = true;
            this.Rowcount.Location = new System.Drawing.Point(32, 49);
            this.Rowcount.Name = "Rowcount";
            this.Rowcount.Size = new System.Drawing.Size(56, 13);
            this.Rowcount.TabIndex = 1;
            this.Rowcount.Text = "Rowcount";
            // 
            // Contatore
            // 
            this.Contatore.AutoSize = true;
            this.Contatore.Location = new System.Drawing.Point(167, 49);
            this.Contatore.Name = "Contatore";
            this.Contatore.Size = new System.Drawing.Size(53, 13);
            this.Contatore.TabIndex = 2;
            this.Contatore.Text = "Contatore";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 227);
            this.Controls.Add(this.Contatore);
            this.Controls.Add(this.Rowcount);
            this.Controls.Add(this.btnClicca);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClicca;
        private System.Windows.Forms.Label Rowcount;
        private System.Windows.Forms.Label Contatore;
    }
}

