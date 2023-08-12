namespace Calcolatrice
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
            this.txt1operando = new System.Windows.Forms.TextBox();
            this.lb1operando = new System.Windows.Forms.Label();
            this.txt2operando = new System.Windows.Forms.TextBox();
            this.lb2operando = new System.Windows.Forms.Label();
            this.lboperazione = new System.Windows.Forms.Label();
            this.txtoperazione = new System.Windows.Forms.TextBox();
            this.lbrisultato = new System.Windows.Forms.Label();
            this.txtrisultato = new System.Windows.Forms.TextBox();
            this.btnsomma = new System.Windows.Forms.Button();
            this.btndifferenza = new System.Windows.Forms.Button();
            this.btnprodotto = new System.Windows.Forms.Button();
            this.btndivisione = new System.Windows.Forms.Button();
            this.btnuguale = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt1operando
            // 
            this.txt1operando.Location = new System.Drawing.Point(13, 26);
            this.txt1operando.Name = "txt1operando";
            this.txt1operando.Size = new System.Drawing.Size(178, 20);
            this.txt1operando.TabIndex = 0;
            this.txt1operando.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1operando_KeyPress);
            // 
            // lb1operando
            // 
            this.lb1operando.AutoSize = true;
            this.lb1operando.Location = new System.Drawing.Point(13, 7);
            this.lb1operando.Name = "lb1operando";
            this.lb1operando.Size = new System.Drawing.Size(83, 13);
            this.lb1operando.TabIndex = 1;
            this.lb1operando.Text = "Primo Operando";
            // 
            // txt2operando
            // 
            this.txt2operando.Location = new System.Drawing.Point(12, 74);
            this.txt2operando.Name = "txt2operando";
            this.txt2operando.Size = new System.Drawing.Size(179, 20);
            this.txt2operando.TabIndex = 2;
            this.txt2operando.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1operando_KeyPress);
            // 
            // lb2operando
            // 
            this.lb2operando.AutoSize = true;
            this.lb2operando.Location = new System.Drawing.Point(10, 58);
            this.lb2operando.Name = "lb2operando";
            this.lb2operando.Size = new System.Drawing.Size(98, 13);
            this.lb2operando.TabIndex = 3;
            this.lb2operando.Text = "Secondo operando";
            // 
            // lboperazione
            // 
            this.lboperazione.AutoSize = true;
            this.lboperazione.Location = new System.Drawing.Point(9, 99);
            this.lboperazione.Name = "lboperazione";
            this.lboperazione.Size = new System.Drawing.Size(61, 13);
            this.lboperazione.TabIndex = 4;
            this.lboperazione.Text = "Operazione";
            // 
            // txtoperazione
            // 
            this.txtoperazione.Location = new System.Drawing.Point(12, 115);
            this.txtoperazione.Multiline = true;
            this.txtoperazione.Name = "txtoperazione";
            this.txtoperazione.ReadOnly = true;
            this.txtoperazione.Size = new System.Drawing.Size(178, 40);
            this.txtoperazione.TabIndex = 5;
            // 
            // lbrisultato
            // 
            this.lbrisultato.AutoSize = true;
            this.lbrisultato.Location = new System.Drawing.Point(9, 197);
            this.lbrisultato.Name = "lbrisultato";
            this.lbrisultato.Size = new System.Drawing.Size(48, 13);
            this.lbrisultato.TabIndex = 6;
            this.lbrisultato.Text = "Risultato";
            // 
            // txtrisultato
            // 
            this.txtrisultato.Location = new System.Drawing.Point(12, 213);
            this.txtrisultato.Name = "txtrisultato";
            this.txtrisultato.ReadOnly = true;
            this.txtrisultato.Size = new System.Drawing.Size(179, 20);
            this.txtrisultato.TabIndex = 7;
            // 
            // btnsomma
            // 
            this.btnsomma.Location = new System.Drawing.Point(197, 12);
            this.btnsomma.Name = "btnsomma";
            this.btnsomma.Size = new System.Drawing.Size(75, 23);
            this.btnsomma.TabIndex = 8;
            this.btnsomma.Text = "+";
            this.btnsomma.UseVisualStyleBackColor = true;
            this.btnsomma.Click += new System.EventHandler(this.btnsomma_Click);
            // 
            // btndifferenza
            // 
            this.btndifferenza.Location = new System.Drawing.Point(197, 41);
            this.btndifferenza.Name = "btndifferenza";
            this.btndifferenza.Size = new System.Drawing.Size(75, 23);
            this.btndifferenza.TabIndex = 9;
            this.btndifferenza.Text = "-";
            this.btndifferenza.UseVisualStyleBackColor = true;
            this.btndifferenza.Click += new System.EventHandler(this.btnsomma_Click);
            // 
            // btnprodotto
            // 
            this.btnprodotto.Location = new System.Drawing.Point(197, 70);
            this.btnprodotto.Name = "btnprodotto";
            this.btnprodotto.Size = new System.Drawing.Size(75, 23);
            this.btnprodotto.TabIndex = 10;
            this.btnprodotto.Text = "*";
            this.btnprodotto.UseVisualStyleBackColor = true;
            this.btnprodotto.Click += new System.EventHandler(this.btnsomma_Click);
            // 
            // btndivisione
            // 
            this.btndivisione.Location = new System.Drawing.Point(197, 99);
            this.btndivisione.Name = "btndivisione";
            this.btndivisione.Size = new System.Drawing.Size(75, 23);
            this.btndivisione.TabIndex = 11;
            this.btndivisione.Text = "/";
            this.btndivisione.UseVisualStyleBackColor = true;
            this.btndivisione.Click += new System.EventHandler(this.btnsomma_Click);
            // 
            // btnuguale
            // 
            this.btnuguale.Location = new System.Drawing.Point(12, 161);
            this.btnuguale.Name = "btnuguale";
            this.btnuguale.Size = new System.Drawing.Size(75, 23);
            this.btnuguale.TabIndex = 12;
            this.btnuguale.Text = "=";
            this.btnuguale.UseVisualStyleBackColor = true;
            this.btnuguale.Click += new System.EventHandler(this.btnuguale_Click);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(197, 226);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 23);
            this.btnclose.TabIndex = 13;
            this.btnclose.Text = "Chiudi";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnuguale);
            this.Controls.Add(this.btndivisione);
            this.Controls.Add(this.btnprodotto);
            this.Controls.Add(this.btndifferenza);
            this.Controls.Add(this.btnsomma);
            this.Controls.Add(this.txtrisultato);
            this.Controls.Add(this.lbrisultato);
            this.Controls.Add(this.txtoperazione);
            this.Controls.Add(this.lboperazione);
            this.Controls.Add(this.lb2operando);
            this.Controls.Add(this.txt2operando);
            this.Controls.Add(this.lb1operando);
            this.Controls.Add(this.txt1operando);
            this.Name = "Form1";
            this.Text = "Calcolatrice";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt1operando;
        private System.Windows.Forms.Label lb1operando;
        private System.Windows.Forms.TextBox txt2operando;
        private System.Windows.Forms.Label lb2operando;
        private System.Windows.Forms.Label lboperazione;
        private System.Windows.Forms.TextBox txtoperazione;
        private System.Windows.Forms.Label lbrisultato;
        private System.Windows.Forms.TextBox txtrisultato;
        private System.Windows.Forms.Button btnsomma;
        private System.Windows.Forms.Button btndifferenza;
        private System.Windows.Forms.Button btnprodotto;
        private System.Windows.Forms.Button btndivisione;
        private System.Windows.Forms.Button btnuguale;
        private System.Windows.Forms.Button btnclose;
    }
}

