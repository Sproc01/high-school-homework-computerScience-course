namespace DBAuto
{
    partial class Search
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
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCitta = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdBMarca = new System.Windows.Forms.RadioButton();
            this.rdBC = new System.Windows.Forms.RadioButton();
            this.rdbMC = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnchiudi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(31, 54);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Città";
            // 
            // txtCitta
            // 
            this.txtCitta.Location = new System.Drawing.Point(34, 127);
            this.txtCitta.Name = "txtCitta";
            this.txtCitta.Size = new System.Drawing.Size(100, 20);
            this.txtCitta.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbMC);
            this.groupBox1.Controls.Add(this.rdBC);
            this.groupBox1.Controls.Add(this.rdBMarca);
            this.groupBox1.Location = new System.Drawing.Point(156, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(116, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cerca in base a";
            // 
            // rdBMarca
            // 
            this.rdBMarca.AutoSize = true;
            this.rdBMarca.Location = new System.Drawing.Point(7, 20);
            this.rdBMarca.Name = "rdBMarca";
            this.rdBMarca.Size = new System.Drawing.Size(55, 17);
            this.rdBMarca.TabIndex = 0;
            this.rdBMarca.TabStop = true;
            this.rdBMarca.Text = "Marca";
            this.rdBMarca.UseVisualStyleBackColor = true;
            // 
            // rdBC
            // 
            this.rdBC.AutoSize = true;
            this.rdBC.Location = new System.Drawing.Point(7, 43);
            this.rdBC.Name = "rdBC";
            this.rdBC.Size = new System.Drawing.Size(46, 17);
            this.rdBC.TabIndex = 1;
            this.rdBC.TabStop = true;
            this.rdBC.Text = "Città";
            this.rdBC.UseVisualStyleBackColor = true;
            // 
            // rdbMC
            // 
            this.rdbMC.AutoSize = true;
            this.rdbMC.Checked = true;
            this.rdbMC.Location = new System.Drawing.Point(7, 67);
            this.rdbMC.Name = "rdbMC";
            this.rdbMC.Size = new System.Drawing.Size(81, 17);
            this.rdbMC.TabIndex = 2;
            this.rdbMC.TabStop = true;
            this.rdbMC.Text = "Marca/Città";
            this.rdbMC.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(37, 200);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Cerca";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnchiudi
            // 
            this.btnchiudi.Location = new System.Drawing.Point(163, 200);
            this.btnchiudi.Name = "btnchiudi";
            this.btnchiudi.Size = new System.Drawing.Size(75, 23);
            this.btnchiudi.TabIndex = 6;
            this.btnchiudi.Text = "Chiudi";
            this.btnchiudi.UseVisualStyleBackColor = true;
            this.btnchiudi.Click += new System.EventHandler(this.btnchiudi_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnchiudi);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtCitta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMarca);
            this.Name = "Search";
            this.Text = "Search";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCitta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbMC;
        private System.Windows.Forms.RadioButton rdBC;
        private System.Windows.Forms.RadioButton rdBMarca;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnchiudi;
    }
}