using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ffdprkillbug
{
    public partial class Form1 : Form
    {
        Random posizione = new Random();
        string path;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point xy = new Point();
            xy.X = posizione.Next(0, (panel1.ClientSize.Width - pictureBox1.Width)+1);
            xy.Y = posizione.Next(0, (panel1.ClientSize.Height - pictureBox1.Height) + 1);
            pictureBox1.Location = xy;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            pictureBox1.Image = Image.FromFile(path + "\\img\\moscaX.gif");
            label2.Text = (Convert.ToInt16(label2.Text) + 1).ToString();
            MessageBox.Show("Colpita","Complimenti");
            pictureBox1.Image = Image.FromFile(path + "\\img\\mosca.gif");
            timer1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            path = Environment.CurrentDirectory;
            label2.Text = "0";
            timer1.Interval = 1000;
        }
    }
}
