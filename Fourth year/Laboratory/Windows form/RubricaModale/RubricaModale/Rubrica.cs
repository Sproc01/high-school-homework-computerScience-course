using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RubricaModale;

namespace RubricaModale
{
    /// <summary>
    /// Michele Sprocatti 4E
    /// Inserimento,
    /// modifica(solo stato civile e foto dopo aver inserito nome e cognome), 
    /// elimina(effettuando doppio click sull'elemento o premendo il tasto elimina che permette di effettuare la ricerca tramite nome e cognome),
    /// setup(solo un aumento disponibile), ricerca(tramite nome e cognome), cancella tutto, visualizza
    /// </summary>
    public partial class Rubrica : Form
    {
        public List<Persona> lista = new List<Persona>();
        int dim = 3;
        public Rubrica()
        {
            InitializeComponent();
        }

        private void cancellaArchivioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //cancella tutto l'archivio
            lista.Clear();
            listBox.Items.Clear();
        }

        private void inserisciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //inserire nuovo elemento
            DialogResult d;
            if (lista.Count < dim)//controllo se si può inserire
            {
                FormModale form = new FormModale();
                form.ShowDialog();//apertura form modale
                if (form.DialogResult == DialogResult.OK)
                {
                    listBox.Items.Add("Cognome:" + form.p1.cognome + ",Nome:" + form.p1.nome + ",Sesso:" + form.p1.Sesso + ",Stato civile:" + form.p1.stato);
                    lista.Add(form.p1);//aggiunta
                    listBox.SelectedIndex = 0;
                }
            }
            else
            {
                if(lista.Count==3)
                {//setup rubrica
                    d=MessageBox.Show("Massima dimensione raggiunta, aumentare dimensione?", "Impossibile ampliare rubrica", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if(d==DialogResult.Yes)
                    setupRubricaToolStripMenuItem.PerformClick();//richiamo click setuprubrica
                }
                else
                    MessageBox.Show("Effettuato già l'unico ampliamento disponibile", "Impossibile ampliare rubrica", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }        
        }
        private void setupRubricaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setuprubrica form = new setuprubrica();//aumento dimensione tramite codice(123)
            form.ShowDialog();
            if(form.DialogResult==DialogResult.OK)
            {
                dim = form.dim;
            }
        }
        private void modificaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RicercaToolStripMenuItem.PerformClick();
            if (lista.Count > 0)//controllo se elementi presenti
            {
                FormModale form = new FormModale(lista[listBox.SelectedIndex],false);
                form.ShowDialog();
                int i = listBox.SelectedIndex;
                if (form.DialogResult == DialogResult.OK)
                {
                    listBox.Items.RemoveAt(listBox.SelectedIndex);
                    listBox.Items.Add("Cognome:" + form.p1.cognome + ",Nome:" + form.p1.nome + ",Sesso:" + form.p1.Sesso + ",Stato civile:" + form.p1.stato);
                    lista[i] = form.p1;
                    listBox.SelectedIndex = 0;
                }
            }
            else
                MessageBox.Show("Non ci sono elementi presenti","Impossibile",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }
        private void eliminaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RicercaToolStripMenuItem.PerformClick();
            if (lista.Count>0)
            {
                lista.RemoveAt(listBox.SelectedIndex);//rimozione elemento
                listBox.Items.RemoveAt(listBox.SelectedIndex);
                if (lista.Count > 0)
                    listBox.SelectedIndex = 0;
            }
            else
                MessageBox.Show("Non ci sono elementi presenti", "Impossibile", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void VisualizzaStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (lista.Count > 0)
            {
                FormModale form = new FormModale(lista[listBox.SelectedIndex], true);
                form.ShowDialog();//form modale per visualizzare
            }
        }
        private void RicercaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lista.Count > 0)//controllo se elementi presenti
            {
                bool trovato = false;
                FormModale form = new FormModale(true);
                form.ShowDialog();
                for (int i = 0; i < lista.Count && !trovato; i++)
                {
                    if (form.p1.nome == lista[i].nome && form.p1.cognome == lista[i].cognome)//ricerca
                    {
                        listBox.SelectedIndex = i;
                        trovato = true;
                    }
                }
                if (!trovato)//elemento non trovato
                    MessageBox.Show("Elemento non trovato", "Non presente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           else
                MessageBox.Show("Non ci sono elementi presenti", "Impossibile", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void listBox_DoubleClick(object sender, EventArgs e)
        {
            if (lista.Count > 0)
            {
                lista.RemoveAt(listBox.SelectedIndex);//rimozione elemento
                listBox.Items.RemoveAt(listBox.SelectedIndex);
                if (lista.Count > 0)
                    listBox.SelectedIndex = 0;
            }
            else
                MessageBox.Show("Non ci sono elementi presenti", "Impossibile", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
