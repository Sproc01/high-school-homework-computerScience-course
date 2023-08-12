namespace ffdprstringhe
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnVisualizzaindice = new System.Windows.Forms.Button();
            this.btnstringa = new System.Windows.Forms.Button();
            this.txtinput = new System.Windows.Forms.TextBox();
            this.txtvisualizza = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnvisualizzza = new System.Windows.Forms.Button();
            this.btnmodifica = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtposizione = new System.Windows.Forms.TextBox();
            this.txtchar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnvettorestringa = new System.Windows.Forms.Button();
            this.btncontrollachar = new System.Windows.Forms.Button();
            this.btncontrolla = new System.Windows.Forms.Button();
            this.btnsubstringa = new System.Windows.Forms.Button();
            this.btnsubstringa2 = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.btnsplit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Testo";
            // 
            // btnVisualizzaindice
            // 
            this.btnVisualizzaindice.Location = new System.Drawing.Point(523, 8);
            this.btnVisualizzaindice.Name = "btnVisualizzaindice";
            this.btnVisualizzaindice.Size = new System.Drawing.Size(85, 23);
            this.btnVisualizzaindice.TabIndex = 1;
            this.btnVisualizzaindice.Text = "Visualizza2";
            this.btnVisualizzaindice.UseVisualStyleBackColor = true;
            this.btnVisualizzaindice.Click += new System.EventHandler(this.btnVisualizzaindice_Click);
            // 
            // btnstringa
            // 
            this.btnstringa.Location = new System.Drawing.Point(523, 95);
            this.btnstringa.Name = "btnstringa";
            this.btnstringa.Size = new System.Drawing.Size(85, 23);
            this.btnstringa.TabIndex = 2;
            this.btnstringa.Text = "stringavettore";
            this.btnstringa.UseVisualStyleBackColor = true;
            this.btnstringa.Click += new System.EventHandler(this.btnstringa_Click);
            // 
            // txtinput
            // 
            this.txtinput.Location = new System.Drawing.Point(16, 29);
            this.txtinput.Name = "txtinput";
            this.txtinput.Size = new System.Drawing.Size(165, 20);
            this.txtinput.TabIndex = 3;
            // 
            // txtvisualizza
            // 
            this.txtvisualizza.Location = new System.Drawing.Point(16, 80);
            this.txtvisualizza.Multiline = true;
            this.txtvisualizza.Name = "txtvisualizza";
            this.txtvisualizza.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtvisualizza.Size = new System.Drawing.Size(165, 144);
            this.txtvisualizza.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Caratteri Inseriti";
            // 
            // btnvisualizzza
            // 
            this.btnvisualizzza.Location = new System.Drawing.Point(523, 37);
            this.btnvisualizzza.Name = "btnvisualizzza";
            this.btnvisualizzza.Size = new System.Drawing.Size(85, 23);
            this.btnvisualizzza.TabIndex = 6;
            this.btnvisualizzza.Text = "Visualizza";
            this.btnvisualizzza.UseVisualStyleBackColor = true;
            this.btnvisualizzza.Click += new System.EventHandler(this.btnvisualizzza_Click);
            // 
            // btnmodifica
            // 
            this.btnmodifica.Location = new System.Drawing.Point(523, 66);
            this.btnmodifica.Name = "btnmodifica";
            this.btnmodifica.Size = new System.Drawing.Size(85, 23);
            this.btnmodifica.TabIndex = 7;
            this.btnmodifica.Text = "modifica";
            this.btnmodifica.UseVisualStyleBackColor = true;
            this.btnmodifica.Click += new System.EventHandler(this.btnmodifica_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "indice";
            // 
            // txtposizione
            // 
            this.txtposizione.Location = new System.Drawing.Point(232, 98);
            this.txtposizione.Name = "txtposizione";
            this.txtposizione.Size = new System.Drawing.Size(165, 20);
            this.txtposizione.TabIndex = 10;
            // 
            // txtchar
            // 
            this.txtchar.Location = new System.Drawing.Point(232, 204);
            this.txtchar.Name = "txtchar";
            this.txtchar.Size = new System.Drawing.Size(165, 20);
            this.txtchar.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "carattere";
            // 
            // btnvettorestringa
            // 
            this.btnvettorestringa.Location = new System.Drawing.Point(523, 124);
            this.btnvettorestringa.Name = "btnvettorestringa";
            this.btnvettorestringa.Size = new System.Drawing.Size(85, 23);
            this.btnvettorestringa.TabIndex = 13;
            this.btnvettorestringa.Text = "vettorestringa";
            this.btnvettorestringa.UseVisualStyleBackColor = true;
            this.btnvettorestringa.Click += new System.EventHandler(this.btnvettorestringa_Click);
            // 
            // btncontrollachar
            // 
            this.btncontrollachar.Location = new System.Drawing.Point(523, 153);
            this.btncontrollachar.Name = "btncontrollachar";
            this.btncontrollachar.Size = new System.Drawing.Size(85, 36);
            this.btncontrollachar.TabIndex = 14;
            this.btncontrollachar.Text = "Controlla presenza";
            this.btncontrollachar.UseVisualStyleBackColor = true;
            this.btncontrollachar.Click += new System.EventHandler(this.btncontrolla_Click);
            // 
            // btncontrolla
            // 
            this.btncontrolla.Location = new System.Drawing.Point(523, 195);
            this.btncontrolla.Name = "btncontrolla";
            this.btncontrolla.Size = new System.Drawing.Size(85, 23);
            this.btncontrolla.TabIndex = 15;
            this.btncontrolla.Text = "Controllo2";
            this.btncontrolla.UseVisualStyleBackColor = true;
            this.btncontrolla.Click += new System.EventHandler(this.btncontrolla_Click_1);
            // 
            // btnsubstringa
            // 
            this.btnsubstringa.Location = new System.Drawing.Point(523, 224);
            this.btnsubstringa.Name = "btnsubstringa";
            this.btnsubstringa.Size = new System.Drawing.Size(85, 23);
            this.btnsubstringa.TabIndex = 16;
            this.btnsubstringa.Text = "substringa";
            this.btnsubstringa.UseVisualStyleBackColor = true;
            this.btnsubstringa.Click += new System.EventHandler(this.btnsubstringa_Click);
            // 
            // btnsubstringa2
            // 
            this.btnsubstringa2.Location = new System.Drawing.Point(523, 253);
            this.btnsubstringa2.Name = "btnsubstringa2";
            this.btnsubstringa2.Size = new System.Drawing.Size(85, 23);
            this.btnsubstringa2.TabIndex = 17;
            this.btnsubstringa2.Text = "substringa2";
            this.btnsubstringa2.UseVisualStyleBackColor = true;
            this.btnsubstringa2.Click += new System.EventHandler(this.btnsubstringa2_Click);
            // 
            // btnremove
            // 
            this.btnremove.Location = new System.Drawing.Point(523, 282);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(85, 23);
            this.btnremove.TabIndex = 18;
            this.btnremove.Text = "Rimuovi";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // btnsplit
            // 
            this.btnsplit.Location = new System.Drawing.Point(523, 311);
            this.btnsplit.Name = "btnsplit";
            this.btnsplit.Size = new System.Drawing.Size(85, 23);
            this.btnsplit.TabIndex = 19;
            this.btnsplit.Text = "Split";
            this.btnsplit.UseVisualStyleBackColor = true;
            this.btnsplit.Click += new System.EventHandler(this.btnsplit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 359);
            this.Controls.Add(this.btnsplit);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.btnsubstringa2);
            this.Controls.Add(this.btnsubstringa);
            this.Controls.Add(this.btncontrolla);
            this.Controls.Add(this.btncontrollachar);
            this.Controls.Add(this.btnvettorestringa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtchar);
            this.Controls.Add(this.txtposizione);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnmodifica);
            this.Controls.Add(this.btnvisualizzza);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtvisualizza);
            this.Controls.Add(this.txtinput);
            this.Controls.Add(this.btnstringa);
            this.Controls.Add(this.btnVisualizzaindice);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVisualizzaindice;
        private System.Windows.Forms.Button btnstringa;
        private System.Windows.Forms.TextBox txtinput;
        private System.Windows.Forms.TextBox txtvisualizza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnvisualizzza;
        private System.Windows.Forms.Button btnmodifica;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtposizione;
        private System.Windows.Forms.TextBox txtchar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnvettorestringa;
        private System.Windows.Forms.Button btncontrollachar;
        private System.Windows.Forms.Button btncontrolla;
        private System.Windows.Forms.Button btnsubstringa;
        private System.Windows.Forms.Button btnsubstringa2;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Button btnsplit;
    }
}

