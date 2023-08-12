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
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void btnvisualizza_Click(object sender, EventArgs e)
        {
            Modale formdialog = new Modale(true);//costruttore del form
            DialogResult risposta = formdialog.ShowDialog();//intercetta la risposta del form modale
            if (risposta == DialogResult.OK)
                MessageBox.Show("Hai premuto pulsante conferma");
            if(risposta==DialogResult.Cancel)
                MessageBox.Show("Hai premuto pulsante annulla");
            formdialog.Dispose();//elimina i dati del form dalla memoria
        }

        private void btnvisualizza2_Click(object sender, EventArgs e)
        {
            Nonmodale nomodal = new Nonmodale();
            nomodal.Show();
        }

        private void btninserisci_Click(object sender, EventArgs e)
        {
            Modale inserimento = new Modale(true);
            DialogResult result=inserimento.ShowDialog();
            if(result==DialogResult.OK)
            listBox1.Items.Add(inserimento.alunno.cognome+" "+ inserimento.alunno.nome);
            if (result == DialogResult.Cancel)
                MessageBox.Show("Operazione annulata");
            if (listBox1.Items.Count != 0)
                listBox1.SelectedIndex = 0;
        }

        private void btnvisualizza3_Click(object sender, EventArgs e)
        {
            Modale visualizza = new Modale(false);
            studente alunno;
            if(listBox1.SelectedIndex!=-1)
            {
                alunno.cognome = listBox1.SelectedItem.ToString().Split(' ')[0];
                alunno.nome = listBox1.SelectedItem.ToString().Split(' ')[1];
                visualizza.alunno.cognome = alunno.cognome;
                visualizza.alunno.nome = alunno.nome;
                visualizza.ShowDialog();
            }
        }
    }
}
