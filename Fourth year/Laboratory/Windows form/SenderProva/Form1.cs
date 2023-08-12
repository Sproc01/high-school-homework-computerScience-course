using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SenderProva
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button btnSupporto = (Button)sender;
            txtMsg.Text += btnSupporto.Text;
/*            if (sender == btn1)
                txtMsg.Text = "Hai premuto il bottone 1";
            else if (sender == btn2)
                txtMsg.Text = "Hai premuto il bottone 2";
            else
                txtMsg.Text = "Hai premuto il bottone 3";*/
        }
    }
}
