namespace Rettangolo
{
    partial class Rettangolo
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
            this.txtBase = new System.Windows.Forms.TextBox();
            this.txtAltezza = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRisultato = new System.Windows.Forms.Label();
            this.txtRisultato = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdPerimetro = new System.Windows.Forms.RadioButton();
            this.rdArea = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancella = new System.Windows.Forms.Button();
            this.btnCalcola = new System.Windows.Forms.Button();
            this.btnChiudi = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Base";
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(16, 30);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(100, 20);
            this.txtBase.TabIndex = 1;
            // 
            // txtAltezza
            // 
            this.txtAltezza.Location = new System.Drawing.Point(16, 91);
            this.txtAltezza.Name = "txtAltezza";
            this.txtAltezza.Size = new System.Drawing.Size(100, 20);
            this.txtAltezza.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Altezza";
            // 
            // lblRisultato
            // 
            this.lblRisultato.AutoSize = true;
            this.lblRisultato.Location = new System.Drawing.Point(13, 136);
            this.lblRisultato.Name = "lblRisultato";
            this.lblRisultato.Size = new System.Drawing.Size(51, 13);
            this.lblRisultato.TabIndex = 4;
            this.lblRisultato.Text = "Perimetro";
            // 
            // txtRisultato
            // 
            this.txtRisultato.Location = new System.Drawing.Point(16, 152);
            this.txtRisultato.Name = "txtRisultato";
            this.txtRisultato.Size = new System.Drawing.Size(100, 20);
            this.txtRisultato.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.rdPerimetro);
            this.panel1.Controls.Add(this.rdArea);
            this.panel1.Location = new System.Drawing.Point(182, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(90, 74);
            this.panel1.TabIndex = 6;
            // 
            // rdPerimetro
            // 
            this.rdPerimetro.AutoSize = true;
            this.rdPerimetro.Checked = true;
            this.rdPerimetro.Location = new System.Drawing.Point(3, 41);
            this.rdPerimetro.Name = "rdPerimetro";
            this.rdPerimetro.Size = new System.Drawing.Size(69, 17);
            this.rdPerimetro.TabIndex = 1;
            this.rdPerimetro.TabStop = true;
            this.rdPerimetro.Text = "Perimetro";
            this.rdPerimetro.UseVisualStyleBackColor = true;
            this.rdPerimetro.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdArea
            // 
            this.rdArea.AutoSize = true;
            this.rdArea.Location = new System.Drawing.Point(4, 4);
            this.rdArea.Name = "rdArea";
            this.rdArea.Size = new System.Drawing.Size(47, 17);
            this.rdArea.TabIndex = 0;
            this.rdArea.Text = "Area";
            this.rdArea.UseVisualStyleBackColor = true;
            this.rdArea.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.btnCancella);
            this.panel2.Controls.Add(this.btnCalcola);
            this.panel2.Location = new System.Drawing.Point(182, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(90, 74);
            this.panel2.TabIndex = 7;
            // 
            // btnCancella
            // 
            this.btnCancella.Location = new System.Drawing.Point(4, 33);
            this.btnCancella.Name = "btnCancella";
            this.btnCancella.Size = new System.Drawing.Size(75, 23);
            this.btnCancella.TabIndex = 1;
            this.btnCancella.Text = "Cancella";
            this.btnCancella.UseVisualStyleBackColor = true;
            // 
            // btnCalcola
            // 
            this.btnCalcola.Location = new System.Drawing.Point(4, 4);
            this.btnCalcola.Name = "btnCalcola";
            this.btnCalcola.Size = new System.Drawing.Size(75, 23);
            this.btnCalcola.TabIndex = 0;
            this.btnCalcola.Text = "Calcola";
            this.btnCalcola.UseVisualStyleBackColor = true;
            this.btnCalcola.Click += new System.EventHandler(this.btnCalcola_Click);
            // 
            // btnChiudi
            // 
            this.btnChiudi.Location = new System.Drawing.Point(186, 193);
            this.btnChiudi.Name = "btnChiudi";
            this.btnChiudi.Size = new System.Drawing.Size(75, 23);
            this.btnChiudi.TabIndex = 8;
            this.btnChiudi.Text = "Chiudi";
            this.btnChiudi.UseVisualStyleBackColor = true;
            this.btnChiudi.Click += new System.EventHandler(this.btnChiudi_Click);
            // 
            // Rettangolo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 223);
            this.Controls.Add(this.btnChiudi);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtRisultato);
            this.Controls.Add(this.lblRisultato);
            this.Controls.Add(this.txtAltezza);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.label1);
            this.Name = "Rettangolo";
            this.Text = "Rettangolo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Rettangolo_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.TextBox txtAltezza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRisultato;
        private System.Windows.Forms.TextBox txtRisultato;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdPerimetro;
        private System.Windows.Forms.RadioButton rdArea;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancella;
        private System.Windows.Forms.Button btnCalcola;
        private System.Windows.Forms.Button btnChiudi;
    }
}

