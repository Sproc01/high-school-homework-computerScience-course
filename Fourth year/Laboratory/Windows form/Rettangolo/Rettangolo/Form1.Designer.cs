namespace Rettangolo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdarea = new System.Windows.Forms.RadioButton();
            this.rdperimetro = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btncancella = new System.Windows.Forms.Button();
            this.btncalcola = new System.Windows.Forms.Button();
            this.txtbase = new System.Windows.Forms.TextBox();
            this.txtaltezza = new System.Windows.Forms.TextBox();
            this.txtoutput = new System.Windows.Forms.TextBox();
            this.loutput = new System.Windows.Forms.Label();
            this.laltezza = new System.Windows.Forms.Label();
            this.lbase = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdarea);
            this.panel1.Controls.Add(this.rdperimetro);
            this.panel1.Location = new System.Drawing.Point(136, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // rdarea
            // 
            this.rdarea.AutoSize = true;
            this.rdarea.Location = new System.Drawing.Point(21, 62);
            this.rdarea.Name = "rdarea";
            this.rdarea.Size = new System.Drawing.Size(47, 17);
            this.rdarea.TabIndex = 1;
            this.rdarea.Text = "Area";
            this.rdarea.UseVisualStyleBackColor = true;
            // 
            // rdperimetro
            // 
            this.rdperimetro.AutoSize = true;
            this.rdperimetro.Checked = true;
            this.rdperimetro.Location = new System.Drawing.Point(21, 16);
            this.rdperimetro.Name = "rdperimetro";
            this.rdperimetro.Size = new System.Drawing.Size(69, 17);
            this.rdperimetro.TabIndex = 0;
            this.rdperimetro.TabStop = true;
            this.rdperimetro.Text = "Perimetro";
            this.rdperimetro.UseVisualStyleBackColor = true;
            this.rdperimetro.CheckedChanged += new System.EventHandler(this.rdperimetro_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btncancella);
            this.panel2.Controls.Add(this.btncalcola);
            this.panel2.Location = new System.Drawing.Point(136, 152);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 1;
            // 
            // btncancella
            // 
            this.btncancella.Location = new System.Drawing.Point(21, 68);
            this.btncancella.Name = "btncancella";
            this.btncancella.Size = new System.Drawing.Size(75, 23);
            this.btncancella.TabIndex = 1;
            this.btncancella.Text = "Cancella";
            this.btncancella.UseVisualStyleBackColor = true;
            this.btncancella.Click += new System.EventHandler(this.btncancella_Click);
            // 
            // btncalcola
            // 
            this.btncalcola.Location = new System.Drawing.Point(21, 18);
            this.btncalcola.Name = "btncalcola";
            this.btncalcola.Size = new System.Drawing.Size(75, 23);
            this.btncalcola.TabIndex = 0;
            this.btncalcola.Text = "Calcola";
            this.btncalcola.UseVisualStyleBackColor = true;
            this.btncalcola.Click += new System.EventHandler(this.btncalcola_Click);
            // 
            // txtbase
            // 
            this.txtbase.Location = new System.Drawing.Point(13, 44);
            this.txtbase.Name = "txtbase";
            this.txtbase.Size = new System.Drawing.Size(100, 20);
            this.txtbase.TabIndex = 2;
            // 
            // txtaltezza
            // 
            this.txtaltezza.Location = new System.Drawing.Point(13, 108);
            this.txtaltezza.Name = "txtaltezza";
            this.txtaltezza.Size = new System.Drawing.Size(100, 20);
            this.txtaltezza.TabIndex = 3;
            // 
            // txtoutput
            // 
            this.txtoutput.Location = new System.Drawing.Point(12, 171);
            this.txtoutput.Name = "txtoutput";
            this.txtoutput.ReadOnly = true;
            this.txtoutput.Size = new System.Drawing.Size(101, 20);
            this.txtoutput.TabIndex = 4;
            // 
            // loutput
            // 
            this.loutput.AutoSize = true;
            this.loutput.Location = new System.Drawing.Point(13, 152);
            this.loutput.Name = "loutput";
            this.loutput.Size = new System.Drawing.Size(51, 13);
            this.loutput.TabIndex = 5;
            this.loutput.Text = "Perimetro";
            // 
            // laltezza
            // 
            this.laltezza.AutoSize = true;
            this.laltezza.Location = new System.Drawing.Point(12, 89);
            this.laltezza.Name = "laltezza";
            this.laltezza.Size = new System.Drawing.Size(40, 13);
            this.laltezza.TabIndex = 6;
            this.laltezza.Text = "altezza";
            // 
            // lbase
            // 
            this.lbase.AutoSize = true;
            this.lbase.Location = new System.Drawing.Point(13, 28);
            this.lbase.Name = "lbase";
            this.lbase.Size = new System.Drawing.Size(31, 13);
            this.lbase.TabIndex = 7;
            this.lbase.Text = "Base";
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(16, 258);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(111, 49);
            this.btnclose.TabIndex = 8;
            this.btnclose.Text = "Chiudi";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 325);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.lbase);
            this.Controls.Add(this.laltezza);
            this.Controls.Add(this.loutput);
            this.Controls.Add(this.txtoutput);
            this.Controls.Add(this.txtaltezza);
            this.Controls.Add(this.txtbase);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Rettangolo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdarea;
        private System.Windows.Forms.RadioButton rdperimetro;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btncancella;
        private System.Windows.Forms.Button btncalcola;
        private System.Windows.Forms.TextBox txtbase;
        private System.Windows.Forms.TextBox txtaltezza;
        private System.Windows.Forms.TextBox txtoutput;
        private System.Windows.Forms.Label loutput;
        private System.Windows.Forms.Label laltezza;
        private System.Windows.Forms.Label lbase;
        private System.Windows.Forms.Button btnclose;
    }
}

