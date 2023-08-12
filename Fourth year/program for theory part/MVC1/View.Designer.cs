namespace MVC1
{
    partial class View
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
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
            this.add1 = new System.Windows.Forms.TextBox();
            this.add2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uguale = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.risultato = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // add1
            // 
            this.add1.Location = new System.Drawing.Point(46, 34);
            this.add1.Name = "add1";
            this.add1.Size = new System.Drawing.Size(81, 20);
            this.add1.TabIndex = 0;
            // 
            // add2
            // 
            this.add2.Location = new System.Drawing.Point(177, 34);
            this.add2.Name = "add2";
            this.add2.Size = new System.Drawing.Size(75, 20);
            this.add2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "+";
            // 
            // uguale
            // 
            this.uguale.Location = new System.Drawing.Point(280, 37);
            this.uguale.Name = "uguale";
            this.uguale.Size = new System.Drawing.Size(46, 20);
            this.uguale.TabIndex = 3;
            this.uguale.Text = "=";
            this.uguale.UseVisualStyleBackColor = true;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(351, 36);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 13);
            this.result.TabIndex = 4;
            // 
            // risultato
            // 
            this.risultato.BackColor = System.Drawing.Color.Red;
            this.risultato.Location = new System.Drawing.Point(46, 111);
            this.risultato.Name = "risultato";
            this.risultato.Size = new System.Drawing.Size(0, 20);
            this.risultato.TabIndex = 5;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 185);
            this.Controls.Add(this.risultato);
            this.Controls.Add(this.result);
            this.Controls.Add(this.uguale);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add2);
            this.Controls.Add(this.add1);
            this.Name = "View";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox add1;
        public System.Windows.Forms.TextBox add2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button uguale;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.TextBox risultato;
    }
}

