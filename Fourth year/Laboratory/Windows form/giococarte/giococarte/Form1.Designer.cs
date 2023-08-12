namespace giococarte
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
            this.piccomputer = new System.Windows.Forms.PictureBox();
            this.picgio = new System.Windows.Forms.PictureBox();
            this.btnplay = new System.Windows.Forms.Button();
            this.lbcomputer = new System.Windows.Forms.Label();
            this.lbgio = new System.Windows.Forms.Label();
            this.lbris = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.piccomputer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picgio)).BeginInit();
            this.SuspendLayout();
            // 
            // piccomputer
            // 
            this.piccomputer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.piccomputer.Location = new System.Drawing.Point(29, 48);
            this.piccomputer.Name = "piccomputer";
            this.piccomputer.Size = new System.Drawing.Size(219, 343);
            this.piccomputer.TabIndex = 0;
            this.piccomputer.TabStop = false;
            // 
            // picgio
            // 
            this.picgio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picgio.Location = new System.Drawing.Point(437, 48);
            this.picgio.Name = "picgio";
            this.picgio.Size = new System.Drawing.Size(219, 343);
            this.picgio.TabIndex = 1;
            this.picgio.TabStop = false;
            // 
            // btnplay
            // 
            this.btnplay.Location = new System.Drawing.Point(312, 48);
            this.btnplay.Name = "btnplay";
            this.btnplay.Size = new System.Drawing.Size(75, 23);
            this.btnplay.TabIndex = 2;
            this.btnplay.Text = "Play";
            this.btnplay.UseVisualStyleBackColor = true;
            this.btnplay.Click += new System.EventHandler(this.btnplay_Click);
            // 
            // lbcomputer
            // 
            this.lbcomputer.AutoSize = true;
            this.lbcomputer.Location = new System.Drawing.Point(119, 29);
            this.lbcomputer.Name = "lbcomputer";
            this.lbcomputer.Size = new System.Drawing.Size(0, 13);
            this.lbcomputer.TabIndex = 3;
            // 
            // lbgio
            // 
            this.lbgio.AutoSize = true;
            this.lbgio.Location = new System.Drawing.Point(531, 29);
            this.lbgio.Name = "lbgio";
            this.lbgio.Size = new System.Drawing.Size(0, 13);
            this.lbgio.TabIndex = 4;
            // 
            // lbris
            // 
            this.lbris.AutoSize = true;
            this.lbris.Location = new System.Drawing.Point(299, 78);
            this.lbris.Name = "lbris";
            this.lbris.Size = new System.Drawing.Size(0, 13);
            this.lbris.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 450);
            this.Controls.Add(this.lbris);
            this.Controls.Add(this.lbgio);
            this.Controls.Add(this.lbcomputer);
            this.Controls.Add(this.btnplay);
            this.Controls.Add(this.picgio);
            this.Controls.Add(this.piccomputer);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.piccomputer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picgio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox piccomputer;
        private System.Windows.Forms.PictureBox picgio;
        private System.Windows.Forms.Button btnplay;
        private System.Windows.Forms.Label lbcomputer;
        private System.Windows.Forms.Label lbgio;
        private System.Windows.Forms.Label lbris;
    }
}

