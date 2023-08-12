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
    public struct Persona
    {
        public string Cognome;
        public string Nome;
        public string NumTelefono;
    }
    public partial class Form1 : Form
    {
        int posizione = 0;
        Persona[] Contatto=new Persona[3];
        Persona temp;
        bool trovato;
        int numinseriti = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btninserisci_Click(object sender, EventArgs e)
        {
            txtoutput.Clear();
            temp.Nome = txtNome.Text;
            temp.Cognome = txtCognome.Text;
            temp.NumTelefono = txtNumTelefono.Text;
            if (numinseriti < 3)
            {
                    Contatto[posizione] = temp;
                    txtoutput.Text += "Elemento inserito" + Environment.NewLine;
                    posizione++;
                    numinseriti++;
            }
            else
            {
                MessageBox.Show("Rubrica piena,Impossibile effettuare inserimento", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtNome.Clear();
            txtCognome.Clear();
            txtNumTelefono.Clear();
            txtNome.Focus();
        }
        private void btnvisualizza_Click(object sender, EventArgs e)
        {
            txtoutput.Clear();
            for (int i = 0; i < numinseriti | i<Contatto.Length; i++)
            {
                if(Contatto[i].Nome!="" & Contatto[i].Cognome!=""& Contatto[i].NumTelefono!="")
                txtoutput.Text += "nome: " + Contatto[i].Nome + " cognome: " + Contatto[i].Cognome + " Numero telefono: " + Contatto[i].NumTelefono + Environment.NewLine;
            }
        }

        private void btnricerca_Click(object sender, EventArgs e)
        {
            txtoutput.Clear();
            ricerca();
            if (trovato)
                txtoutput.Text += "nome: " + Contatto[posizione].Nome + " cognome: " + Contatto[posizione].Cognome + " Numero telefono: " + Contatto[posizione].NumTelefono + Environment.NewLine;
            else
                errore();
        }
        private void ricerca()
        {
            posizione = 0;
            int i;
            trovato = false;
            for (i = 0; i < numinseriti&!trovato; i++)
            {
                trovato = (txtNome.Text == Contatto[i].Nome && txtCognome.Text == Contatto[i].Cognome);
                if (trovato)
                    posizione = i;
            }
        }

        private void btnmodifica_Click(object sender, EventArgs e)
        {
            txtoutput.Clear();
            ricerca();
            if (trovato)
            {
                Contatto[posizione].NumTelefono = txtNumTelefono.Text;
                txtoutput.Text += "nome: " + Contatto[posizione].Nome + " cognome: " + Contatto[posizione].Cognome + " Numero telefono: " + Contatto[posizione].NumTelefono + Environment.NewLine;
            }
              else
                errore();
        }

        private void btnelimina_Click(object sender, EventArgs e)
        {
            txtoutput.Clear();
            ricerca();
            if (trovato)
            {
                Contatto[posizione].Nome = "";
                Contatto[posizione].Cognome = "";
                Contatto[posizione].NumTelefono = "";
                numinseriti--;
                txtoutput.Text += "Operazione riuscita";
            }
            else
                errore();
        }
        private void errore()
        {
           MessageBox.Show("Elemento non trovato", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
