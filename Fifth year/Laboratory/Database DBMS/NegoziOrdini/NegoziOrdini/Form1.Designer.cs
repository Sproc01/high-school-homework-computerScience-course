namespace NegoziOrdini
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
            this.dtNegozi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtOrdini = new System.Windows.Forms.DataGridView();
            this.btnAggiorna = new System.Windows.Forms.Button();
            this.labeldtnegozi = new System.Windows.Forms.Label();
            this.labeldtordini = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtNegozi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtOrdini)).BeginInit();
            this.SuspendLayout();
            // 
            // dtNegozi
            // 
            this.dtNegozi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtNegozi.Location = new System.Drawing.Point(23, 36);
            this.dtNegozi.Name = "dtNegozi";
            this.dtNegozi.Size = new System.Drawing.Size(592, 222);
            this.dtNegozi.TabIndex = 0;
            this.dtNegozi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtNegozi_CellClick);
            this.dtNegozi.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dtNegozi_UserDeletedRow);
            this.dtNegozi.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dtNegozi_UserDeletingRow);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Negozi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ordini";
            // 
            // dtOrdini
            // 
            this.dtOrdini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtOrdini.Location = new System.Drawing.Point(23, 292);
            this.dtOrdini.Name = "dtOrdini";
            this.dtOrdini.Size = new System.Drawing.Size(592, 222);
            this.dtOrdini.TabIndex = 3;
            this.dtOrdini.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtOrdini_CellClick);
            // 
            // btnAggiorna
            // 
            this.btnAggiorna.Location = new System.Drawing.Point(23, 539);
            this.btnAggiorna.Name = "btnAggiorna";
            this.btnAggiorna.Size = new System.Drawing.Size(592, 23);
            this.btnAggiorna.TabIndex = 4;
            this.btnAggiorna.Text = "Aggiorna database";
            this.btnAggiorna.UseVisualStyleBackColor = true;
            this.btnAggiorna.Click += new System.EventHandler(this.btnAggiorna_Click);
            // 
            // labeldtnegozi
            // 
            this.labeldtnegozi.AutoSize = true;
            this.labeldtnegozi.Location = new System.Drawing.Point(635, 106);
            this.labeldtnegozi.Name = "labeldtnegozi";
            this.labeldtnegozi.Size = new System.Drawing.Size(0, 13);
            this.labeldtnegozi.TabIndex = 5;
            // 
            // labeldtordini
            // 
            this.labeldtordini.AutoSize = true;
            this.labeldtordini.Location = new System.Drawing.Point(635, 376);
            this.labeldtordini.Name = "labeldtordini";
            this.labeldtordini.Size = new System.Drawing.Size(0, 13);
            this.labeldtordini.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 574);
            this.Controls.Add(this.labeldtordini);
            this.Controls.Add(this.labeldtnegozi);
            this.Controls.Add(this.btnAggiorna);
            this.Controls.Add(this.dtOrdini);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtNegozi);
            this.Name = "Form1";
            this.Text = "Negozi-Ordini";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtNegozi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtOrdini)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtNegozi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtOrdini;
        private System.Windows.Forms.Button btnAggiorna;
        private System.Windows.Forms.Label labeldtnegozi;
        private System.Windows.Forms.Label labeldtordini;
    }
}

