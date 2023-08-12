using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RubricaModale
{
    public partial class setuprubrica : Form
    {
        public int dim=3;
        public setuprubrica()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            MinimizeBox = false;//non si può rimpincciolire la finestra
            MaximizeBox = false;//non si può ingrandire la finestra
            FormBorderStyle = FormBorderStyle.FixedDialog;//non fa ridimensionare il form
            AcceptButton = btnverifica;
            CancelButton = btncancel;
        }

        private void btnverifica_Click(object sender, EventArgs e)
        {
            Rubrica form = new Rubrica();
            if(txtpassword.Text=="123")
            {
                DialogResult = DialogResult.OK;
                MessageBox.Show("Codice corretto, nuova dimensione massima pari a 10", "Corretto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (Convert.ToInt32(txtdim.Text) >= 3)
                    dim = Convert.ToInt32(txtdim.Text);
                else
                    MessageBox.Show("Dimensione nuova minore di 3","Impossibile",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                DialogResult = DialogResult.Cancel;
                MessageBox.Show("Codice errato", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtdim_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsDigit(c)&&c!=8)
                e.Handled = true;
        }
    }
}
