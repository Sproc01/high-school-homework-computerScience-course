namespace collezioni
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
            this.lbdati = new System.Windows.Forms.Label();
            this.txtinput = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbconta = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btndatasorcenun = new System.Windows.Forms.Button();
            this.btndatasource = new System.Windows.Forms.Button();
            this.btnaddvalue = new System.Windows.Forms.Button();
            this.btnaddrange = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.btnremoveat = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btninsert = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btninsert1 = new System.Windows.Forms.Button();
            this.btnpreleva = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btntext = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbdati
            // 
            this.lbdati.AutoSize = true;
            this.lbdati.Location = new System.Drawing.Point(12, 9);
            this.lbdati.Name = "lbdati";
            this.lbdati.Size = new System.Drawing.Size(24, 13);
            this.lbdati.TabIndex = 0;
            this.lbdati.Text = "dati";
            // 
            // txtinput
            // 
            this.txtinput.Location = new System.Drawing.Point(12, 25);
            this.txtinput.Name = "txtinput";
            this.txtinput.Size = new System.Drawing.Size(100, 20);
            this.txtinput.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 71);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Num elementi";
            // 
            // lbconta
            // 
            this.lbconta.AutoSize = true;
            this.lbconta.Location = new System.Drawing.Point(86, 169);
            this.lbconta.Name = "lbconta";
            this.lbconta.Size = new System.Drawing.Size(0, 13);
            this.lbconta.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.btntext);
            this.groupBox1.Controls.Add(this.btnpreleva);
            this.groupBox1.Controls.Add(this.btndatasorcenun);
            this.groupBox1.Controls.Add(this.btndatasource);
            this.groupBox1.Controls.Add(this.btnaddvalue);
            this.groupBox1.Controls.Add(this.btnaddrange);
            this.groupBox1.Controls.Add(this.btnremove);
            this.groupBox1.Controls.Add(this.btnremoveat);
            this.groupBox1.Controls.Add(this.btnclear);
            this.groupBox1.Controls.Add(this.btninsert);
            this.groupBox1.Location = new System.Drawing.Point(150, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 175);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "listbox";
            // 
            // btndatasorcenun
            // 
            this.btndatasorcenun.Location = new System.Drawing.Point(87, 97);
            this.btndatasorcenun.Name = "btndatasorcenun";
            this.btndatasorcenun.Size = new System.Drawing.Size(105, 23);
            this.btndatasorcenun.TabIndex = 12;
            this.btndatasorcenun.Text = "Data source nun";
            this.btndatasorcenun.UseVisualStyleBackColor = true;
            this.btndatasorcenun.Click += new System.EventHandler(this.btndatasorcenun_Click);
            // 
            // btndatasource
            // 
            this.btndatasource.Location = new System.Drawing.Point(6, 97);
            this.btndatasource.Name = "btndatasource";
            this.btndatasource.Size = new System.Drawing.Size(75, 23);
            this.btndatasource.TabIndex = 8;
            this.btndatasource.Text = "Data source";
            this.btndatasource.UseVisualStyleBackColor = true;
            this.btndatasource.Click += new System.EventHandler(this.btndatasource_Click);
            // 
            // btnaddvalue
            // 
            this.btnaddvalue.Location = new System.Drawing.Point(87, 71);
            this.btnaddvalue.Name = "btnaddvalue";
            this.btnaddvalue.Size = new System.Drawing.Size(75, 23);
            this.btnaddvalue.TabIndex = 11;
            this.btnaddvalue.Text = "addvalue";
            this.btnaddvalue.UseVisualStyleBackColor = true;
            this.btnaddvalue.Click += new System.EventHandler(this.btnaddvalue_Click);
            // 
            // btnaddrange
            // 
            this.btnaddrange.Location = new System.Drawing.Point(6, 71);
            this.btnaddrange.Name = "btnaddrange";
            this.btnaddrange.Size = new System.Drawing.Size(75, 23);
            this.btnaddrange.TabIndex = 10;
            this.btnaddrange.Text = "addrange";
            this.btnaddrange.UseVisualStyleBackColor = true;
            this.btnaddrange.Click += new System.EventHandler(this.btnaddrange_Click);
            // 
            // btnremove
            // 
            this.btnremove.Location = new System.Drawing.Point(87, 42);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(75, 23);
            this.btnremove.TabIndex = 9;
            this.btnremove.Text = "remove";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // btnremoveat
            // 
            this.btnremoveat.Location = new System.Drawing.Point(6, 42);
            this.btnremoveat.Name = "btnremoveat";
            this.btnremoveat.Size = new System.Drawing.Size(75, 23);
            this.btnremoveat.TabIndex = 8;
            this.btnremoveat.Text = "removeat";
            this.btnremoveat.UseVisualStyleBackColor = true;
            this.btnremoveat.Click += new System.EventHandler(this.btnremoveat_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(87, 13);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 7;
            this.btnclear.Text = "Cancella";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(6, 13);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(75, 23);
            this.btninsert.TabIndex = 6;
            this.btninsert.Text = "inserisci";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox2.Controls.Add(this.btninsert1);
            this.groupBox2.Location = new System.Drawing.Point(150, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 56);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista interi";
            // 
            // btninsert1
            // 
            this.btninsert1.Location = new System.Drawing.Point(6, 19);
            this.btninsert1.Name = "btninsert1";
            this.btninsert1.Size = new System.Drawing.Size(75, 23);
            this.btninsert1.TabIndex = 7;
            this.btninsert1.Text = "inserisci";
            this.btninsert1.UseVisualStyleBackColor = true;
            this.btninsert1.Click += new System.EventHandler(this.btninsert1_Click);
            // 
            // btnpreleva
            // 
            this.btnpreleva.Location = new System.Drawing.Point(6, 122);
            this.btnpreleva.Name = "btnpreleva";
            this.btnpreleva.Size = new System.Drawing.Size(186, 23);
            this.btnpreleva.TabIndex = 8;
            this.btnpreleva.Text = "Preleva elemento";
            this.btnpreleva.UseVisualStyleBackColor = true;
            this.btnpreleva.Click += new System.EventHandler(this.btnpreleva_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Elemento:";
            // 
            // btntext
            // 
            this.btntext.Location = new System.Drawing.Point(6, 147);
            this.btntext.Name = "btntext";
            this.btntext.Size = new System.Drawing.Size(75, 23);
            this.btntext.TabIndex = 8;
            this.btntext.Text = "testo";
            this.btntext.UseVisualStyleBackColor = true;
            this.btntext.Click += new System.EventHandler(this.btntext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbconta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtinput);
            this.Controls.Add(this.lbdati);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbdati;
        private System.Windows.Forms.TextBox txtinput;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbconta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Button btnremoveat;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Button btnaddrange;
        private System.Windows.Forms.Button btnaddvalue;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btninsert1;
        private System.Windows.Forms.Button btndatasource;
        private System.Windows.Forms.Button btndatasorcenun;
        private System.Windows.Forms.Button btnpreleva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btntext;
    }
}

