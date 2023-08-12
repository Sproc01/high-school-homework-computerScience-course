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
            this.dgvMarche = new System.Windows.Forms.DataGridView();
            this.grpbModelli = new System.Windows.Forms.GroupBox();
            this.dgvModelli = new System.Windows.Forms.DataGridView();
            this.btnAgg = new System.Windows.Forms.Button();
            this.grpbAuto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarche)).BeginInit();
            this.grpbModelli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelli)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbAuto
            // 
            this.grpbAuto.Controls.Add(this.dgvMarche);
            this.grpbAuto.Location = new System.Drawing.Point(4, 13);
            this.grpbAuto.Name = "grpbAuto";
            this.grpbAuto.Size = new System.Drawing.Size(258, 249);
            this.grpbAuto.TabIndex = 0;
            this.grpbAuto.TabStop = false;
            this.grpbAuto.Text = "Marche auto";
            // 
            // dgvMarche
            // 
            this.dgvMarche.BackgroundColor = System.Drawing.Color.White;
            this.dgvMarche.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarche.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMarche.Location = new System.Drawing.Point(3, 16);
            this.dgvMarche.Name = "dgvMarche";
            this.dgvMarche.Size = new System.Drawing.Size(252, 230);
            this.dgvMarche.TabIndex = 0;
            // 
            // grpbModelli
            // 
            this.grpbModelli.Controls.Add(this.dgvModelli);
            this.grpbModelli.Location = new System.Drawing.Point(268, 12);
            this.grpbModelli.Name = "grpbModelli";
            this.grpbModelli.Size = new System.Drawing.Size(682, 250);
            this.grpbModelli.TabIndex = 1;
            this.grpbModelli.TabStop = false;
            this.grpbModelli.Text = "Modelli auto";
            // 
            // dgvModelli
            // 
            this.dgvModelli.BackgroundColor = System.Drawing.Color.White;
            this.dgvModelli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModelli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvModelli.Location = new System.Drawing.Point(3, 16);
            this.dgvModelli.Name = "dgvModelli";
            this.dgvModelli.Size = new System.Drawing.Size(676, 231);
            this.dgvModelli.TabIndex = 0;
            this.dgvModelli.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvModelli_DataError);
            // 
            // btnAgg
            // 
            this.btnAgg.Location = new System.Drawing.Point(864, 268);
            this.btnAgg.Name = "btnAgg";
            this.btnAgg.Size = new System.Drawing.Size(75, 23);
            this.btnAgg.TabIndex = 2;
            this.btnAgg.Text = "Aggiorna";
            this.btnAgg.UseVisualStyleBackColor = true;
            this.btnAgg.Click += new System.EventHandler(this.btnAgg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 298);
            this.Controls.Add(this.btnAgg);
            this.Controls.Add(this.grpbModelli);
            this.Controls.Add(this.grpbAuto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modelli Auto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpbAuto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarche)).EndInit();
            this.grpbModelli.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelli)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbAuto;
        private System.Windows.Forms.GroupBox grpbModelli;
        private System.Windows.Forms.DataGridView dgvMarche;
        private System.Windows.Forms.DataGridView dgvModelli;
        private System.Windows.Forms.Button btnAgg;
    }
}

