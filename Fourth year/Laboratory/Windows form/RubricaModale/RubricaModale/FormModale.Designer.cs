namespace RubricaModale
{
    partial class FormModale
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
            this.groupdati = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdconiugatoa = new System.Windows.Forms.RadioButton();
            this.rdcelibenubile = new System.Windows.Forms.RadioButton();
            this.rddivorziatoa = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbtnMaschio = new System.Windows.Forms.RadioButton();
            this.rdfemmina = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcognome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnsfoglia = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupdati.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupdati
            // 
            this.groupdati.Controls.Add(this.groupBox2);
            this.groupdati.Controls.Add(this.groupBox1);
            this.groupdati.Controls.Add(this.label2);
            this.groupdati.Controls.Add(this.txtcognome);
            this.groupdati.Controls.Add(this.label1);
            this.groupdati.Controls.Add(this.txtnome);
            this.groupdati.Location = new System.Drawing.Point(125, 6);
            this.groupdati.Name = "groupdati";
            this.groupdati.Size = new System.Drawing.Size(187, 243);
            this.groupdati.TabIndex = 0;
            this.groupdati.TabStop = false;
            this.groupdati.Text = "Dati";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdconiugatoa);
            this.groupBox2.Controls.Add(this.rdcelibenubile);
            this.groupBox2.Controls.Add(this.rddivorziatoa);
            this.groupBox2.Location = new System.Drawing.Point(5, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(182, 85);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stato Civile";
            // 
            // rdconiugatoa
            // 
            this.rdconiugatoa.AutoSize = true;
            this.rdconiugatoa.Location = new System.Drawing.Point(91, 19);
            this.rdconiugatoa.Name = "rdconiugatoa";
            this.rdconiugatoa.Size = new System.Drawing.Size(84, 17);
            this.rdconiugatoa.TabIndex = 11;
            this.rdconiugatoa.TabStop = true;
            this.rdconiugatoa.Text = "Coniugato/a";
            this.rdconiugatoa.UseVisualStyleBackColor = true;
            // 
            // rdcelibenubile
            // 
            this.rdcelibenubile.AutoSize = true;
            this.rdcelibenubile.Checked = true;
            this.rdcelibenubile.Location = new System.Drawing.Point(0, 19);
            this.rdcelibenubile.Name = "rdcelibenubile";
            this.rdcelibenubile.Size = new System.Drawing.Size(89, 17);
            this.rdcelibenubile.TabIndex = 10;
            this.rdcelibenubile.TabStop = true;
            this.rdcelibenubile.Text = "Celibe/Nubile";
            this.rdcelibenubile.UseVisualStyleBackColor = true;
            // 
            // rddivorziatoa
            // 
            this.rddivorziatoa.AutoSize = true;
            this.rddivorziatoa.Location = new System.Drawing.Point(1, 42);
            this.rddivorziatoa.Name = "rddivorziatoa";
            this.rddivorziatoa.Size = new System.Drawing.Size(83, 17);
            this.rddivorziatoa.TabIndex = 9;
            this.rddivorziatoa.TabStop = true;
            this.rddivorziatoa.Text = "Divorziato/a";
            this.rddivorziatoa.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbtnMaschio);
            this.groupBox1.Controls.Add(this.rdfemmina);
            this.groupBox1.Location = new System.Drawing.Point(5, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 53);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sesso";
            // 
            // rdbtnMaschio
            // 
            this.rdbtnMaschio.AutoSize = true;
            this.rdbtnMaschio.Checked = true;
            this.rdbtnMaschio.Location = new System.Drawing.Point(6, 19);
            this.rdbtnMaschio.Name = "rdbtnMaschio";
            this.rdbtnMaschio.Size = new System.Drawing.Size(65, 17);
            this.rdbtnMaschio.TabIndex = 1;
            this.rdbtnMaschio.TabStop = true;
            this.rdbtnMaschio.Text = "Maschio";
            this.rdbtnMaschio.UseVisualStyleBackColor = true;
            // 
            // rdfemmina
            // 
            this.rdfemmina.AutoSize = true;
            this.rdfemmina.Location = new System.Drawing.Point(77, 19);
            this.rdfemmina.Name = "rdfemmina";
            this.rdfemmina.Size = new System.Drawing.Size(67, 17);
            this.rdfemmina.TabIndex = 0;
            this.rdfemmina.TabStop = true;
            this.rdfemmina.Text = "Femmina";
            this.rdfemmina.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cognome";
            // 
            // txtcognome
            // 
            this.txtcognome.Location = new System.Drawing.Point(6, 72);
            this.txtcognome.Name = "txtcognome";
            this.txtcognome.Size = new System.Drawing.Size(100, 20);
            this.txtcognome.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(6, 35);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(100, 20);
            this.txtnome.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::RubricaModale.Properties.Resources.Sfoglia;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 117);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Immagine";
            // 
            // btnsfoglia
            // 
            this.btnsfoglia.Location = new System.Drawing.Point(12, 158);
            this.btnsfoglia.Name = "btnsfoglia";
            this.btnsfoglia.Size = new System.Drawing.Size(100, 23);
            this.btnsfoglia.TabIndex = 7;
            this.btnsfoglia.Text = "Sfoglia";
            this.btnsfoglia.UseVisualStyleBackColor = true;
            this.btnsfoglia.Click += new System.EventHandler(this.btnsfoglia_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(125, 266);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(214, 266);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormModale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 303);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnsfoglia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupdati);
            this.Name = "FormModale";
            this.Text = "FormModale";
            this.groupdati.ResumeLayout(false);
            this.groupdati.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupdati;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.RadioButton rdbtnMaschio;
        private System.Windows.Forms.RadioButton rdfemmina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcognome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnsfoglia;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdconiugatoa;
        private System.Windows.Forms.RadioButton rdcelibenubile;
        private System.Windows.Forms.RadioButton rddivorziatoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}