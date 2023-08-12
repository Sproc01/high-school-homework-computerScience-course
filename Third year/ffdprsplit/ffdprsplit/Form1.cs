using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ffdprsplit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsplit_Click(object sender, EventArgs e)
        {
            txtvisualizza.Clear();
            string input = txtinput.Text;
            int posizione=0;
            string split=input;
           do
           {
                posizione = input.IndexOf(" ");
                split = input.Substring(posizione+1);
                txtvisualizza.Text += input.Remove(posizione+1);
                if (posizione!=-1)
                {
                    txtvisualizza.Text += Environment.NewLine;
                }
                input = split;
           }while (posizione!=-1);
            txtvisualizza.Text += split;
        }
    }
}
