namespace RubricaModale
{
    partial class Rubrica
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inserisciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RicercaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VisualizzaStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cancellaArchivioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.setupRubricaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(12, 29);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(505, 212);
            this.listBox.TabIndex = 0;
            this.listBox.DoubleClick += new System.EventHandler(this.listBox_DoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserisciToolStripMenuItem,
            this.RicercaToolStripMenuItem,
            this.eliminaToolStripMenuItem,
            this.modificaToolStripMenuItem,
            this.VisualizzaStripMenuItem1,
            this.cancellaArchivioToolStripMenuItem1,
            this.setupRubricaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(529, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inserisciToolStripMenuItem
            // 
            this.inserisciToolStripMenuItem.Name = "inserisciToolStripMenuItem";
            this.inserisciToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.inserisciToolStripMenuItem.Text = "Inserisci";
            this.inserisciToolStripMenuItem.Click += new System.EventHandler(this.inserisciToolStripMenuItem_Click);
            // 
            // RicercaToolStripMenuItem
            // 
            this.RicercaToolStripMenuItem.Name = "RicercaToolStripMenuItem";
            this.RicercaToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.RicercaToolStripMenuItem.Text = "Ricerca";
            this.RicercaToolStripMenuItem.Click += new System.EventHandler(this.RicercaToolStripMenuItem_Click);
            // 
            // eliminaToolStripMenuItem
            // 
            this.eliminaToolStripMenuItem.Name = "eliminaToolStripMenuItem";
            this.eliminaToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.eliminaToolStripMenuItem.Text = "Elimina";
            this.eliminaToolStripMenuItem.Click += new System.EventHandler(this.eliminaToolStripMenuItem_Click);
            // 
            // modificaToolStripMenuItem
            // 
            this.modificaToolStripMenuItem.Name = "modificaToolStripMenuItem";
            this.modificaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.modificaToolStripMenuItem.Text = "Modifica";
            this.modificaToolStripMenuItem.Click += new System.EventHandler(this.modificaToolStripMenuItem_Click);
            // 
            // VisualizzaStripMenuItem1
            // 
            this.VisualizzaStripMenuItem1.Name = "VisualizzaStripMenuItem1";
            this.VisualizzaStripMenuItem1.Size = new System.Drawing.Size(69, 20);
            this.VisualizzaStripMenuItem1.Text = "Visualizza";
            this.VisualizzaStripMenuItem1.Click += new System.EventHandler(this.VisualizzaStripMenuItem1_Click);
            // 
            // cancellaArchivioToolStripMenuItem1
            // 
            this.cancellaArchivioToolStripMenuItem1.Name = "cancellaArchivioToolStripMenuItem1";
            this.cancellaArchivioToolStripMenuItem1.Size = new System.Drawing.Size(111, 20);
            this.cancellaArchivioToolStripMenuItem1.Text = "Cancella Archivio";
            this.cancellaArchivioToolStripMenuItem1.Click += new System.EventHandler(this.cancellaArchivioToolStripMenuItem1_Click);
            // 
            // setupRubricaToolStripMenuItem
            // 
            this.setupRubricaToolStripMenuItem.Name = "setupRubricaToolStripMenuItem";
            this.setupRubricaToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.setupRubricaToolStripMenuItem.Text = "Setup Rubrica";
            this.setupRubricaToolStripMenuItem.Click += new System.EventHandler(this.setupRubricaToolStripMenuItem_Click);
            // 
            // Rubrica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 261);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Rubrica";
            this.Text = "Rubrica";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inserisciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RicercaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VisualizzaStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cancellaArchivioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem setupRubricaToolStripMenuItem;
    }
}

