namespace WFmodale
{
    partial class Mainform
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
            this.btnvisualizza = new System.Windows.Forms.Button();
            this.btnvisualizza2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btninserisci = new System.Windows.Forms.Button();
            this.btnvisualizza3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnvisualizza
            // 
            this.btnvisualizza.Location = new System.Drawing.Point(197, 12);
            this.btnvisualizza.Name = "btnvisualizza";
            this.btnvisualizza.Size = new System.Drawing.Size(75, 44);
            this.btnvisualizza.TabIndex = 0;
            this.btnvisualizza.Text = "Visualizza modale";
            this.btnvisualizza.UseVisualStyleBackColor = true;
            this.btnvisualizza.Click += new System.EventHandler(this.btnvisualizza_Click);
            // 
            // btnvisualizza2
            // 
            this.btnvisualizza2.Location = new System.Drawing.Point(197, 62);
            this.btnvisualizza2.Name = "btnvisualizza2";
            this.btnvisualizza2.Size = new System.Drawing.Size(75, 44);
            this.btnvisualizza2.TabIndex = 1;
            this.btnvisualizza2.Text = "Visualizza non modale";
            this.btnvisualizza2.UseVisualStyleBackColor = true;
            this.btnvisualizza2.Click += new System.EventHandler(this.btnvisualizza2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 7);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(178, 186);
            this.listBox1.TabIndex = 2;
            // 
            // btninserisci
            // 
            this.btninserisci.Location = new System.Drawing.Point(197, 112);
            this.btninserisci.Name = "btninserisci";
            this.btninserisci.Size = new System.Drawing.Size(75, 44);
            this.btninserisci.TabIndex = 3;
            this.btninserisci.Text = "Inserisci";
            this.btninserisci.UseVisualStyleBackColor = true;
            this.btninserisci.Click += new System.EventHandler(this.btninserisci_Click);
            // 
            // btnvisualizza3
            // 
            this.btnvisualizza3.Location = new System.Drawing.Point(197, 162);
            this.btnvisualizza3.Name = "btnvisualizza3";
            this.btnvisualizza3.Size = new System.Drawing.Size(75, 58);
            this.btnvisualizza3.TabIndex = 4;
            this.btnvisualizza3.Text = "Visualizza dati studente";
            this.btnvisualizza3.UseVisualStyleBackColor = true;
            this.btnvisualizza3.Click += new System.EventHandler(this.btnvisualizza3_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnvisualizza3);
            this.Controls.Add(this.btninserisci);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnvisualizza2);
            this.Controls.Add(this.btnvisualizza);
            this.Name = "Mainform";
            this.Text = "Mainform";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnvisualizza;
        private System.Windows.Forms.Button btnvisualizza2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btninserisci;
        private System.Windows.Forms.Button btnvisualizza3;
    }
}

