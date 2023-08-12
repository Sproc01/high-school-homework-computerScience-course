namespace ffdprVerifica3e_visuale
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
            this.components = new System.ComponentModel.Container();
            this.txtinput = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnclose = new System.Windows.Forms.Button();
            this.btncalcola = new System.Windows.Forms.Button();
            this.txtFrequenze = new System.Windows.Forms.TextBox();
            this.labeltesto = new System.Windows.Forms.Label();
            this.labelfrequenza = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtinput
            // 
            this.txtinput.Location = new System.Drawing.Point(2, 25);
            this.txtinput.Name = "txtinput";
            this.txtinput.Size = new System.Drawing.Size(185, 20);
            this.txtinput.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(180, 226);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(92, 23);
            this.btnclose.TabIndex = 2;
            this.btnclose.Text = "close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btncalcola
            // 
            this.btncalcola.Location = new System.Drawing.Point(193, 23);
            this.btncalcola.Name = "btncalcola";
            this.btncalcola.Size = new System.Drawing.Size(75, 23);
            this.btncalcola.TabIndex = 3;
            this.btncalcola.Text = "calcola";
            this.btncalcola.UseVisualStyleBackColor = true;
            this.btncalcola.Click += new System.EventHandler(this.btncalcola_Click);
            // 
            // txtFrequenze
            // 
            this.txtFrequenze.Location = new System.Drawing.Point(2, 75);
            this.txtFrequenze.Multiline = true;
            this.txtFrequenze.Name = "txtFrequenze";
            this.txtFrequenze.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFrequenze.Size = new System.Drawing.Size(171, 141);
            this.txtFrequenze.TabIndex = 4;
            // 
            // labeltesto
            // 
            this.labeltesto.AutoSize = true;
            this.labeltesto.Location = new System.Drawing.Point(-1, 9);
            this.labeltesto.Name = "labeltesto";
            this.labeltesto.Size = new System.Drawing.Size(34, 13);
            this.labeltesto.TabIndex = 5;
            this.labeltesto.Text = "Testo";
            this.labeltesto.Click += new System.EventHandler(this.labeltesto_Click);
            // 
            // labelfrequenza
            // 
            this.labelfrequenza.AutoSize = true;
            this.labelfrequenza.Location = new System.Drawing.Point(-1, 59);
            this.labelfrequenza.Name = "labelfrequenza";
            this.labelfrequenza.Size = new System.Drawing.Size(57, 13);
            this.labelfrequenza.TabIndex = 6;
            this.labelfrequenza.Text = "Frequenza";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.labelfrequenza);
            this.Controls.Add(this.labeltesto);
            this.Controls.Add(this.txtFrequenze);
            this.Controls.Add(this.btncalcola);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.txtinput);
            this.Name = "Form1";
            this.Text = "Frequenza";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtinput;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btncalcola;
        private System.Windows.Forms.TextBox txtFrequenze;
        private System.Windows.Forms.Label labeltesto;
        private System.Windows.Forms.Label labelfrequenza;
    }
}

