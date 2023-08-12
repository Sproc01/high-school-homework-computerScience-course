namespace DataGridViewInRelazione
{
    partial class Form1
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
            this.grpbAuto = new System.Windows.Forms.GroupBox();
            this.dgvNegozi = new System.Windows.Forms.DataGridView();
            this.grpbModelli = new System.Windows.Forms.GroupBox();
            this.dgvOrdini = new System.Windows.Forms.DataGridView();
            this.btnAgg = new System.Windows.Forms.Button();
            this.grpbAuto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNegozi)).BeginInit();
            this.grpbModelli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdini)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbAuto
            // 
            this.grpbAuto.Controls.Add(this.dgvNegozi);
            this.grpbAuto.Location = new System.Drawing.Point(5, 16);
            this.grpbAuto.Margin = new System.Windows.Forms.Padding(4);
            this.grpbAuto.Name = "grpbAuto";
            this.grpbAuto.Padding = new System.Windows.Forms.Padding(4);
            this.grpbAuto.Size = new System.Drawing.Size(344, 306);
            this.grpbAuto.TabIndex = 0;
            this.grpbAuto.TabStop = false;
            this.grpbAuto.Text = "Agenti";
            // 
            // dgvNegozi
            // 
            this.dgvNegozi.BackgroundColor = System.Drawing.Color.White;
            this.dgvNegozi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNegozi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNegozi.Location = new System.Drawing.Point(4, 19);
            this.dgvNegozi.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNegozi.Name = "dgvNegozi";
            this.dgvNegozi.Size = new System.Drawing.Size(336, 283);
            this.dgvNegozi.TabIndex = 0;
            // 
            // grpbModelli
            // 
            this.grpbModelli.Controls.Add(this.dgvOrdini);
            this.grpbModelli.Location = new System.Drawing.Point(357, 15);
            this.grpbModelli.Margin = new System.Windows.Forms.Padding(4);
            this.grpbModelli.Name = "grpbModelli";
            this.grpbModelli.Padding = new System.Windows.Forms.Padding(4);
            this.grpbModelli.Size = new System.Drawing.Size(909, 308);
            this.grpbModelli.TabIndex = 1;
            this.grpbModelli.TabStop = false;
            this.grpbModelli.Text = "Vendite";
            // 
            // dgvOrdini
            // 
            this.dgvOrdini.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrdini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdini.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrdini.Location = new System.Drawing.Point(4, 19);
            this.dgvOrdini.Margin = new System.Windows.Forms.Padding(4);
            this.dgvOrdini.Name = "dgvOrdini";
            this.dgvOrdini.Size = new System.Drawing.Size(901, 285);
            this.dgvOrdini.TabIndex = 0;
            // 
            // btnAgg
            // 
            this.btnAgg.Location = new System.Drawing.Point(1152, 330);
            this.btnAgg.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgg.Name = "btnAgg";
            this.btnAgg.Size = new System.Drawing.Size(100, 28);
            this.btnAgg.TabIndex = 2;
            this.btnAgg.Text = "Aggiorna";
            this.btnAgg.UseVisualStyleBackColor = true;
            this.btnAgg.Click += new System.EventHandler(this.btnAgg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 367);
            this.Controls.Add(this.btnAgg);
            this.Controls.Add(this.grpbModelli);
            this.Controls.Add(this.grpbAuto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenti_Vendite";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpbAuto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNegozi)).EndInit();
            this.grpbModelli.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdini)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbAuto;
        private System.Windows.Forms.GroupBox grpbModelli;
        private System.Windows.Forms.DataGridView dgvNegozi;
        private System.Windows.Forms.DataGridView dgvOrdini;
        private System.Windows.Forms.Button btnAgg;
    }
}

