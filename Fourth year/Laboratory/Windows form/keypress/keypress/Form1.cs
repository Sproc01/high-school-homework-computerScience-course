using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace keypress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char car=e.KeyChar;
            if (char.IsDigit(car) == false && car != '-' && car != 8)
                e.Handled = true;
            if (car == (char)Keys.Enter)
                label2.Text = textBox1.Text;
        }
    }
}
