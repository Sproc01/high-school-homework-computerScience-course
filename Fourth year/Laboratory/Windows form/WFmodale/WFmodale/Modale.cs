using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFmodale
{
    public partial class Modale : Form
    {
        public studente alunno;
        private bool bottonenull;
        public Modale(bool annulla)
        {
            bottonenull = annulla;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            MinimizeBox = false;//non si può rimpincciolire la finestra
            MaximizeBox = false;//non si può ingrandire la finestra
            FormBorderStyle = FormBorderStyle.FixedDialog;//non fa ridimensionare il form
            AcceptButton = btnconferma;
            CancelButton = btnannulla;
        }

        private void btnconferma_Click(object sender, EventArgs e)
        {
            alunno.nome = txtnome.Text;
            alunno.cognome = txtcognome.Text;
            DialogResult = DialogResult.OK;
        }

        private void btnannulla_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void Modale_Load(object sender, EventArgs e)
        {
            if(!bottonenull)
            {
                txtcognome.Text = alunno.cognome;
                txtnome.Text = alunno.nome;
            }
        }
    }
}
