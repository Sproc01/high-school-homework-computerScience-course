namespace ffdprrubrica
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
            this.btninserisci = new System.Windows.Forms.Button();
            this.btnelimina = new System.Windows.Forms.Button();
            this.btnricerca = new System.Windows.Forms.Button();
            this.btnmodifica = new System.Windows.Forms.Button();
            this.txtoutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.txtNumTelefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnvisualizza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btninserisci
            // 
            this.btninserisci.Location = new System.Drawing.Point(13, 74);
            this.btninserisci.Name = "btninserisci";
            this.btninserisci.Size = new System.Drawing.Size(78, 47);
            this.btninserisci.TabIndex = 0;
            this.btninserisci.Text = "Inserisci";
            this.btninserisci.UseVisualStyleBackColor = true;
            this.btninserisci.Click += new System.EventHandler(this.btninserisci_Click);
            // 
            // btnelimina
            // 
            this.btnelimina.Location = new System.Drawing.Point(320, 76);
            this.btnelimina.Name = "btnelimina";
            this.btnelimina.Size = new System.Drawing.Size(75, 47);
            this.btnelimina.TabIndex = 1;
            this.btnelimina.Text = "Elimina";
            this.btnelimina.UseVisualStyleBackColor = true;
            this.btnelimina.Click += new System.EventHandler(this.btnelimina_Click);
            // 
            // btnricerca
            // 
            this.btnricerca.Location = new System.Drawing.Point(238, 76);
            this.btnricerca.Name = "btnricerca";
            this.btnricerca.Size = new System.Drawing.Size(76, 47);
            this.btnricerca.TabIndex = 2;
            this.btnricerca.Text = "Ricerca";
            this.btnricerca.UseVisualStyleBackColor = true;
            this.btnricerca.Click += new System.EventHandler(this.btnricerca_Click);
            // 
            // btnmodifica
            // 
            this.btnmodifica.Location = new System.Drawing.Point(96, 74);
            this.btnmodifica.Name = "btnmodifica";
            this.btnmodifica.Size = new System.Drawing.Size(68, 47);
            this.btnmodifica.TabIndex = 3;
            this.btnmodifica.Text = "Modifica Numero";
            this.btnmodifica.UseVisualStyleBackColor = true;
            this.btnmodifica.Click += new System.EventHandler(this.btnmodifica_Click);
            // 
            // txtoutput
            // 
            this.txtoutput.Location = new System.Drawing.Point(12, 150);
            this.txtoutput.Multiline = true;
            this.txtoutput.Name = "txtoutput";
            this.txtoutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtoutput.Size = new System.Drawing.Size(383, 217);
            this.txtoutput.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Output";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(13, 50);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 8;
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(151, 50);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(100, 20);
            this.txtCognome.TabIndex = 9;
            // 
            // txtNumTelefono
            // 
            this.txtNumTelefono.Location = new System.Drawing.Point(280, 50);
            this.txtNumTelefono.Name = "txtNumTelefono";
            this.txtNumTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtNumTelefono.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cognome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Numero di telefono";
            // 
            // btnvisualizza
            // 
            this.btnvisualizza.Location = new System.Drawing.Point(170, 76);
            this.btnvisualizza.Name = "btnvisualizza";
            this.btnvisualizza.Size = new System.Drawing.Size(62, 45);
            this.btnvisualizza.TabIndex = 14;
            this.btnvisualizza.Text = "Visualizza";
            this.btnvisualizza.UseVisualStyleBackColor = true;
            this.btnvisualizza.Click += new System.EventHandler(this.btnvisualizza_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 389);
            this.Controls.Add(this.btnvisualizza);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumTelefono);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtoutput);
            this.Controls.Add(this.btnmodifica);
            this.Controls.Add(this.btnricerca);
            this.Controls.Add(this.btnelimina);
            this.Controls.Add(this.btninserisci);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btninserisci;
        private System.Windows.Forms.Button btnelimina;
        private System.Windows.Forms.Button btnricerca;
        private System.Windows.Forms.Button btnmodifica;
        private System.Windows.Forms.TextBox txtoutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.TextBox txtNumTelefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnvisualizza;
    }
}

