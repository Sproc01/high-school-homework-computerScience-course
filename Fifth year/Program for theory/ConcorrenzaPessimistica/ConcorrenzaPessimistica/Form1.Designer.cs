namespace ConcorrenzaPessimistica
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
            this.Rowcount = new System.Windows.Forms.Label();
            this.Contatore = new System.Windows.Forms.Label();
            this.Btnclicca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Rowcount
            // 
            this.Rowcount.AutoSize = true;
            this.Rowcount.Location = new System.Drawing.Point(35, 55);
            this.Rowcount.Name = "Rowcount";
            this.Rowcount.Size = new System.Drawing.Size(57, 13);
            this.Rowcount.TabIndex = 0;
            this.Rowcount.Text = "RowCount";
            // 
            // Contatore
            // 
            this.Contatore.AutoSize = true;
            this.Contatore.Location = new System.Drawing.Point(164, 55);
            this.Contatore.Name = "Contatore";
            this.Contatore.Size = new System.Drawing.Size(53, 13);
            this.Contatore.TabIndex = 1;
            this.Contatore.Text = "Contatore";
            // 
            // Btnclicca
            // 
            this.Btnclicca.Location = new System.Drawing.Point(90, 110);
            this.Btnclicca.Name = "Btnclicca";
            this.Btnclicca.Size = new System.Drawing.Size(75, 23);
            this.Btnclicca.TabIndex = 2;
            this.Btnclicca.Text = "Clicca";
            this.Btnclicca.UseVisualStyleBackColor = true;
            this.Btnclicca.Click += new System.EventHandler(this.Btnclicca_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 261);
            this.Controls.Add(this.Btnclicca);
            this.Controls.Add(this.Contatore);
            this.Controls.Add(this.Rowcount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Rowcount;
        private System.Windows.Forms.Label Contatore;
        private System.Windows.Forms.Button Btnclicca;
    }
}

