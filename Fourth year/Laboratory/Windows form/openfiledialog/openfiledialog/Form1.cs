using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace openfiledialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btndialog_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Immagine(*.jpg)|*.jpg|Tutti i File(*.*)|*.*";
            openFileDialog1.CheckFileExists = true;
            DialogResult cmd = openFileDialog1.ShowDialog();
            if(cmd!=DialogResult.OK)
            {
                MessageBox.Show("utente non ha selezionato nessun file");
            }
            else
                MessageBox.Show("File selezionato:"+openFileDialog1.FileName);
        }
    }
}
