using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salvemondo
{
    public partial class Form1 : Form       // classe parziale il resto è contenuto nel designer
    {
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnclose;
        Random posizione = new Random();
        Point xy = new Point();
        int contatore;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            contatore = 0;
        }
        private void btnclose_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Vuoi chiudere l'applicazione?","Chiusura",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation)==DialogResult.Yes)
                Close();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            btn1 = new Button();
            xy.X = posizione.Next(0,(ClientSize.Width - btn1.Width)+1);
            xy.Y = posizione.Next(0,(ClientSize.Height - btn1.Height)+1);
            contatore++;
            this.btn1.Location = xy;
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Btn1:"+contatore;
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btnclose_Click);
            this.Controls.Add(this.btn1);
        }
    }
}
