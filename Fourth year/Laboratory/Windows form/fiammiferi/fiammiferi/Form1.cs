using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace fiammiferi
{
    public partial class Form1 : Form
    {
        enum turno { gio1, gio2 }//enumeratore per gestire i turni
        const int dim = 24;//dimensione vettore
        int rimanenti=dim;
        PictureBox[] vett = new PictureBox[dim];
        string path;
        turno attuale;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            path = Environment.CurrentDirectory;//percorso per immagini picture box
            gio2.Visible = false;//groupbox non visibili
            gio1.Visible = false;
            for (int i = 0; i < rimanenti; i++)
            {
                //picture box non visibili
                (Controls.Find("PictureBox" + (i + 1), true).FirstOrDefault() as PictureBox).Visible=false;
            }
        }
        
        private void btn1p_Click(object sender, EventArgs e)
        {
            switch (((Button)sender).Text)//switch in base a numero selezionato
            {
                case "1":
                    vett[rimanenti - 1].BackgroundImage = Image.FromFile(path + "\\img\\fiamspento.jpeg");
                    rimanenti--;
                    break;
                case "2":
                    vett[rimanenti - 1].BackgroundImage = Image.FromFile(path + "\\img\\fiamspento.jpeg");
                    if(rimanenti-2>=0)
                    vett[rimanenti - 2].BackgroundImage = Image.FromFile(path + "\\img\\fiamspento.jpeg");
                    rimanenti -= 2;
                    break;
                case "3":
                    vett[rimanenti - 1].BackgroundImage = Image.FromFile(path + "\\img\\fiamspento.jpeg");
                    if (rimanenti - 2 >= 0)
                        vett[rimanenti - 2].BackgroundImage = Image.FromFile(path + "\\img\\fiamspento.jpeg");
                    if (rimanenti - 3 >= 0)
                        vett[rimanenti - 3].BackgroundImage = Image.FromFile(path + "\\img\\fiamspento.jpeg");
                    rimanenti -= 3;
                    break;
            }
            if (rimanenti > 0)//controllo per vittoria o no del giocatore
            {
                lbrimanenti.Text = rimanenti.ToString();
                cambio();
            }
            else
            {
                if (attuale == turno.gio1)//controllo per detrminare vincitore
                    MessageBox.Show("Ha vinto il giocatore 2", "Gioco terminato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    MessageBox.Show("Ha vinto il giocatore 1", "Gioco terminato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //dialogo ricomincia gioco o no
                if (MessageBox.Show("Vuoi ripetere il gioco?", "Ripetre gioco", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                    ricomincia();
                else
                    Close();
            }
        }
        void ricomincia()
        {
            for (int i = 0; i < vett.Length; i++)
            {
                //reimposta proprietà picture box 
                (Controls.Find("PictureBox" + (i + 1), true).FirstOrDefault() as PictureBox).BackgroundImage= Image.FromFile(path + "\\img\\fiamacceso.jpeg");
            }
            btnplay.PerformClick();
        }
        void cambio()
        {
            switch (attuale)//switch cambio turno
            {
                case turno.gio1:
                    gio2.Visible = false;
                    gio1.Visible = true;
                    attuale = turno.gio2;
                    break;
                case turno.gio2:
                    gio2.Visible = true;
                    gio1.Visible = false;
                    attuale=turno.gio1;
                    break;
            }        
        }
        private void btnplay_Click(object sender, EventArgs e)
        {
            //inizio gioco
            PictureBox pic;
            lbrimanenti.Text = rimanenti.ToString();
            attuale = turno.gio1;
            cambio();
            for (int i = 0; i < vett.Length; i++)
            {
                pic = (Controls.Find("PictureBox" + (i + 1), true).FirstOrDefault() as PictureBox);
                pic.Visible = true;
                //assegnazione picture box al vettore
                vett[i]=pic;
            }
        }
    }
}
