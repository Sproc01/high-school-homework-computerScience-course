namespace ffdprDataAdapterDataSet
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvDatiTabella = new System.Windows.Forms.DataGridView();
            this.lstTabelle = new System.Windows.Forms.ListBox();
            this.btnTabelle = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAggiorna = new System.Windows.Forms.Button();
            this.lstStato = new System.Windows.Forms.ListBox();
            this.btnStatus = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnTabDb = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatiTabella)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatiTabella
            // 
            this.dgvDatiTabella.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatiTabella.Location = new System.Drawing.Point(13, 13);
            this.dgvDatiTabella.Name = "dgvDatiTabella";
            this.dgvDatiTabella.Size = new System.Drawing.Size(401, 280);
            this.dgvDatiTabella.TabIndex = 0;
            this.dgvDatiTabella.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvDatiTabella_DataError);
            // 
            // lstTabelle
            // 
            this.lstTabelle.FormattingEnabled = true;
            this.lstTabelle.Location = new System.Drawing.Point(420, 13);
            this.lstTabelle.Name = "lstTabelle";
            this.lstTabelle.Size = new System.Drawing.Size(120, 277);
            this.lstTabelle.TabIndex = 1;
            this.lstTabelle.SelectedIndexChanged += new System.EventHandler(this.lstTabelle_SelectedIndexChanged);
            // 
            // btnTabelle
            // 
            this.btnTabelle.Location = new System.Drawing.Point(13, 299);
            this.btnTabelle.Name = "btnTabelle";
            this.btnTabelle.Size = new System.Drawing.Size(75, 23);
            this.btnTabelle.TabIndex = 2;
            this.btnTabelle.Text = "Tabelle";
            this.btnTabelle.UseVisualStyleBackColor = true;
            this.btnTabelle.Click += new System.EventHandler(this.btnTabelle_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(339, 299);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAggiorna
            // 
            this.btnAggiorna.Location = new System.Drawing.Point(94, 299);
            this.btnAggiorna.Name = "btnAggiorna";
            this.btnAggiorna.Size = new System.Drawing.Size(75, 23);
            this.btnAggiorna.TabIndex = 4;
            this.btnAggiorna.Text = "Aggiorna";
            this.btnAggiorna.UseVisualStyleBackColor = true;
            this.btnAggiorna.Click += new System.EventHandler(this.btnAggiorna_Click);
            // 
            // lstStato
            // 
            this.lstStato.FormattingEnabled = true;
            this.lstStato.Location = new System.Drawing.Point(546, 12);
            this.lstStato.Name = "lstStato";
            this.lstStato.Size = new System.Drawing.Size(111, 277);
            this.lstStato.TabIndex = 5;
            this.lstStato.SelectedIndexChanged += new System.EventHandler(this.lstStato_SelectedIndexChanged);
            // 
            // btnStatus
            // 
            this.btnStatus.Location = new System.Drawing.Point(176, 300);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(75, 23);
            this.btnStatus.TabIndex = 6;
            this.btnStatus.Text = "Stato";
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(258, 300);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(75, 23);
            this.btnUndo.TabIndex = 7;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnTabDb
            // 
            this.btnTabDb.Location = new System.Drawing.Point(421, 300);
            this.btnTabDb.Name = "btnTabDb";
            this.btnTabDb.Size = new System.Drawing.Size(75, 23);
            this.btnTabDb.TabIndex = 8;
            this.btnTabDb.Text = "TabDb";
            this.btnTabDb.UseVisualStyleBackColor = true;
            this.btnTabDb.Click += new System.EventHandler(this.btnTabDb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 348);
            this.Controls.Add(this.btnTabDb);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnStatus);
            this.Controls.Add(this.lstStato);
            this.Controls.Add(this.btnAggiorna);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnTabelle);
            this.Controls.Add(this.lstTabelle);
            this.Controls.Add(this.dgvDatiTabella);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatiTabella)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatiTabella;
        private System.Windows.Forms.ListBox lstTabelle;
        private System.Windows.Forms.Button btnTabelle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAggiorna;
        private System.Windows.Forms.ListBox lstStato;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnTabDb;
    }
}

