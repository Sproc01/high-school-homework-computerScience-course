﻿using System;
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
        int rimanenti=24;
        List<PictureBox> lista = new List<PictureBox>();
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
            PictureBox pic;
            int n=Convert.ToInt32(((Button)sender).Text);
            for (int i = 0; i < n; i++)
            {
                if(rimanenti-i>0)
                {
                    pic = (Controls.Find("PictureBox" + (rimanenti - i), true).FirstOrDefault() as PictureBox);
                    Controls.Remove(pic);
                    lista.RemoveAt((rimanenti-1) - i);
                    pic.BackgroundImage = Image.FromFile(path + "\\img\\fiamspento.jpeg");
                    lista.Insert((rimanenti-1) - i, pic);
                    Controls.Add(pic);
                }
            }
            rimanenti -= n;
            if (rimanenti > 0)//controllo per vittoria o no del giocatore
            {
                lbrimanenti.Text = rimanenti.ToString();
                cambio();
            }
            else
            {
                if (attuale == turno.gio1)//controllo per detrminare vincitore
                    MessageBox.Show("Ha vinto il giocatore 2", "Gioco terminato", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Ha vinto il giocatore 1", "Gioco terminato", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //dialogo ricomincia gioco o no
                if (MessageBox.Show("Vuoi ripetere il gioco?", "Ripetre gioco", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    btnplay.PerformClick();
                else
                    Close();
            }
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
            rimanenti = 24;
            for (int i = 0; i < rimanenti; i++)
            {
                //reimposta proprietà picture box 
                (Controls.Find("PictureBox" + (i + 1), true).FirstOrDefault() as PictureBox).BackgroundImage = Image.FromFile(path + "\\img\\fiamacceso.jpeg");
            }
            PictureBox pic;
            lbrimanenti.Text = rimanenti.ToString();
            attuale = turno.gio1;
            cambio();
            for (int i = 1; i <= rimanenti; i++)
            {
                pic = (Controls.Find("PictureBox" + (i), true).FirstOrDefault() as PictureBox);
                pic.Visible = true;
                //assegnazione picture box al vettore
                lista.Add(pic);
            }
        }
    }
}
