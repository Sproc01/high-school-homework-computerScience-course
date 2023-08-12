using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rettangolo
{
    public partial class Rettangolo : Form
    {
        public Rettangolo()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdArea.Checked)
                lblRisultato.Text = "Area";
            else
                lblRisultato.Text = "Perimetro";
        }

        private void btnChiudi_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void Rettangolo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Vuoi chiudere l'applicazione?", "Chiusura", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                e.Cancel = true;
        }

        private void btnCalcola_Click(object sender, EventArgs e)
        {
            if(txtBase==null||txtAltezza==null)
                MessageBox.Show("")
        }
    }
}
