using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ffdprsalveRagazzi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        private void saluto_Click(object sender, EventArgs e)
        {
            if(label1.Text == "salve ragazzi")
            label1.Text = "ti ho già salutato";
            else label1.Text = "salve ragazzi";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
