using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ffdprrubrica
{
    //Michele Sprocatti 4E
    public struct Persona
    {
        public string Cognome;
        public string Nome;
        public string NumTelefono;
    }
    public partial class Form1 : Form
    {
        const int dim = 10;
        Persona[] Contatto=new Persona[dim];
        int numinseriti = 0;
        public Form1()
        {
            InitializeComponent();
        }
        static int Confronto(Persona x, Persona y)//delegato array.sort
        {
            int pos = 0;
            if(x.Cognome!=""&&y.Cognome!="")
            pos = string.Compare(x.Cognome, y.Cognome);//metodo string compare per confrontare le stringhe
            if(pos==0)//se cognomi uguali considero il nome
            pos=string.Compare(x.Nome,y.Nome);
            return pos;
        }
        private void btninserisci_Click(object sender, EventArgs e)
        {
            int pos;
            Persona temp;//variabile temporanea per inserimento
            txtoutput.Clear();
            if (txtNome.Text.Length == 0 || txtCognome.Text.Length == 0 || txtNumTelefono.Text.Length == 0)
                txtoutput.Text = "Manca una o più caratteristiche del contatto";//textbox vuota
            else
            if (txtNome.Text.Length <= 15 && txtCognome.Text.Length <= 15 && txtNumTelefono.Text.Length < 11)//controllo lunghezza massima textbox
            {
                temp.Nome = txtNome.Text;
                temp.Cognome = txtCognome.Text;
                temp.NumTelefono = txtNumTelefono.Text;
                if (numinseriti < dim)
                {//controllo dimensione massima
                    pos = Array.FindIndex(Contatto, ricerca);//controllo elemento già presente
                    if (pos < 0)
                    {
                        Contatto[numinseriti] = temp;
                        txtoutput.Text += "Elemento inserito" + Environment.NewLine;
                        numinseriti++;
                    }
                    else
                        txtoutput.Text += "elemento già presente";
                }
                else
                {
                    //rubrica piena
                    MessageBox.Show("Rubrica piena,Impossibile effettuare inserimento", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                //lunghezza textbox superata
                MessageBox.Show("Errore inserimento, lunghezza massima superata", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtNome.Clear();
            txtCognome.Clear();
            txtNumTelefono.Clear();
            txtNome.Focus();
        }
        private void btnvisualizza_Click(object sender, EventArgs e)
        {//bottone visualizza
            txtoutput.Clear();
            Persona[] visualizza = new Persona[dim];
            for (int i = 0; i < visualizza.Length; i++)//copia elementi in un altro vettore
            {
                visualizza[i].Cognome = Contatto[i].Cognome;
                visualizza[i].Nome = Contatto[i].Nome;
                visualizza[i].NumTelefono = Contatto[i].NumTelefono;
            }
            Array.Sort(visualizza, Confronto);//ordinamento vettore nuovo
            for (int i = 0; i < numinseriti | i<visualizza.Length; i++)
            {//visualizzazione elementi ordinati del vettore nuovo
                if(visualizza[i].Nome!="" & visualizza[i].Cognome!=""& visualizza[i].NumTelefono!="")
                txtoutput.Text += (i+1)+") nome: " + visualizza[i].Nome + " cognome: " + visualizza[i].Cognome + " Numero telefono: " + visualizza[i].NumTelefono + Environment.NewLine;
            }
        }
        private void btnricerca_Click(object sender, EventArgs e)
        {//bottone ricerca elemento
            txtoutput.Clear();
            int pos;
            pos=Array.FindIndex(Contatto, ricerca);
            if (pos >= 0)
                txtoutput.Text += "nome: " + Contatto[pos].Nome + " cognome: " + Contatto[pos].Cognome + " Numero telefono: " + Contatto[pos].NumTelefono + Environment.NewLine;
            else
                txtoutput.Text += "Elemento non presente";
        }
        private bool ricerca(Persona x)//metodo predicato per array.findindex
        {
            return x.Cognome == txtCognome.Text && x.Nome == txtNome.Text;
        }

        private void btnmodifica_Click(object sender, EventArgs e)
        {//modifica elemento
            txtoutput.Clear();
            int pos = Array.FindIndex(Contatto, ricerca);
            if (pos>=0)
            {
                Contatto[pos].NumTelefono = txtNumTelefono.Text;
                txtoutput.Text += "nome: " + Contatto[pos].Nome + " cognome: " + Contatto[pos].Cognome + " Numero telefono: " + Contatto[pos].NumTelefono + Environment.NewLine;
            }
              else
                txtoutput.Text += "elemento non presente";
        }

        private void btnelimina_Click(object sender, EventArgs e)
        {//elemina elemento
            txtoutput.Clear();
            int pos = Array.FindIndex(Contatto, ricerca);
            if (pos>=0)//controllo se elemento presente
            {//elimino elemento
                for (int i= pos; i< (Contatto.Length-1); i++)
                {
                    Contatto[i].Nome = Contatto[i + 1].Nome;
                    Contatto[i].Cognome = Contatto[i + 1].Cognome;
                    Contatto[i].NumTelefono = Contatto[i + 1].NumTelefono;
                    Contatto[i+1].Nome = "";
                    Contatto[i+1].Cognome = "";
                    Contatto[i+1].NumTelefono ="";
                }
                numinseriti--;
                txtoutput.Text += "Operazione riuscita";
            }
            else
                txtoutput.Text += "elemento non presente";
        }

        private void Form1_Load(object sender, EventArgs e)
        {//inizializzazione variabili
            for (int i = 0; i < Contatto.Length; i++)
            {
                Contatto[i].Nome = "";
                Contatto[i].Cognome = "";
                Contatto[i].NumTelefono ="";
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {//bottone chiudi
            Close();
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {//evento keypress permette di scrivere solo lettere e cancellare
            char car = e.KeyChar;
            if (char.IsLetter(car) == false && car!=8)
                e.Handled = true;
        }

        private void txtNumTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {//evento keypress permette di scrivere solo numeri e cancellare
            char car = e.KeyChar;
            if (char.IsDigit(car) == false&&car!=8)
                e.Handled = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {//chiusura form
            if (MessageBox.Show("Vuoi chiudere il programma?", "Chiusura programma", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                e.Cancel=true;
        }
    }
}
