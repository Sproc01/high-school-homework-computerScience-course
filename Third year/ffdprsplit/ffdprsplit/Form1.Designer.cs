namespace ffdprsplit
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
            this.txtvisualizza = new System.Windows.Forms.TextBox();
            this.txtinput = new System.Windows.Forms.TextBox();
            this.btnsplit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtvisualizza
            // 
            this.txtvisualizza.Location = new System.Drawing.Point(12, 74);
            this.txtvisualizza.Multiline = true;
            this.txtvisualizza.Name = "txtvisualizza";
            this.txtvisualizza.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtvisualizza.Size = new System.Drawing.Size(201, 231);
            this.txtvisualizza.TabIndex = 0;
            // 
            // txtinput
            // 
            this.txtinput.Location = new System.Drawing.Point(12, 25);
            this.txtinput.Name = "txtinput";
            this.txtinput.Size = new System.Drawing.Size(100, 20);
            this.txtinput.TabIndex = 1;
            // 
            // btnsplit
            // 
            this.btnsplit.Location = new System.Drawing.Point(138, 25);
            this.btnsplit.Name = "btnsplit";
            this.btnsplit.Size = new System.Drawing.Size(75, 23);
            this.btnsplit.TabIndex = 2;
            this.btnsplit.Text = "split";
            this.btnsplit.UseVisualStyleBackColor = true;
            this.btnsplit.Click += new System.EventHandler(this.btnsplit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 317);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsplit);
            this.Controls.Add(this.txtinput);
            this.Controls.Add(this.txtvisualizza);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtvisualizza;
        private System.Windows.Forms.TextBox txtinput;
        private System.Windows.Forms.Button btnsplit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

