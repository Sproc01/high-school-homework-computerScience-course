namespace MVC1
{
    partial class Vista2
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
            this.risultato = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // risultato
            // 
            this.risultato.BackColor = System.Drawing.Color.Lime;
            this.risultato.Location = new System.Drawing.Point(62, 72);
            this.risultato.Name = "risultato";
            this.risultato.Size = new System.Drawing.Size(0, 20);
            this.risultato.TabIndex = 0;
            // 
            // Vista2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 125);
            this.Controls.Add(this.risultato);
            this.Name = "Vista2";
            this.Text = "Vista2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox risultato;
    }
}