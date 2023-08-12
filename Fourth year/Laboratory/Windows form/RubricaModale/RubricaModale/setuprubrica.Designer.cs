namespace RubricaModale
{
    partial class setuprubrica
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
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnverifica = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.txtdim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(84, 52);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(100, 20);
            this.txtpassword.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inserire password licenza per ampliamento rubrica\r\n";
            // 
            // btnverifica
            // 
            this.btnverifica.Location = new System.Drawing.Point(54, 112);
            this.btnverifica.Name = "btnverifica";
            this.btnverifica.Size = new System.Drawing.Size(75, 23);
            this.btnverifica.TabIndex = 2;
            this.btnverifica.Text = "Verifica";
            this.btnverifica.UseVisualStyleBackColor = true;
            this.btnverifica.Click += new System.EventHandler(this.btnverifica_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(135, 112);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 3;
            this.btncancel.Text = "Annulla";
            this.btncancel.UseVisualStyleBackColor = true;
            // 
            // txtdim
            // 
            this.txtdim.Location = new System.Drawing.Point(110, 86);
            this.txtdim.Name = "txtdim";
            this.txtdim.Size = new System.Drawing.Size(100, 20);
            this.txtdim.TabIndex = 4;
            this.txtdim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdim_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nuova Dimensione:";
            // 
            // setuprubrica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 148);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtdim);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnverifica);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpassword);
            this.Name = "setuprubrica";
            this.Text = "setuprubrica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnverifica;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.TextBox txtdim;
        private System.Windows.Forms.Label label2;
    }
}