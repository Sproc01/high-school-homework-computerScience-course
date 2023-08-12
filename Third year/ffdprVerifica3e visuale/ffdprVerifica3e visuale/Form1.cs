using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ffdprVerifica3e_visuale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void labeltesto_Click(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
            //oppure this.Close();
        }

        private void btncalcola_Click(object sender, EventArgs e)
        {
            string input;
            string lettera;
            int[] Flettere = new int[26];
            int[] Fnumeri = new int[10];
            //txtFrequenze.Text = txtinput.Text;
            input = txtinput.Text;
            Calcolafrequenza(input, Fnumeri, Flettere);
            Visuafrequenzanum(Fnumeri, Flettere);
        }
        private void Calcolafrequenza(string input,int [] Fnumeri, int [] Flettere)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsNumber(input[i]))
                    Fnumeri[(int)input[i]-'0']++;
                if (char.IsLetter(input[i]))
                    if((char)input[i] - 97>=0)
                        Flettere[(char)input[i] - 97]++;
                else
                    Flettere[(char)input[i] - 65]++;
            }

        }
        private void Visuafrequenzanum(int [] Fnumeri, int []  Flettere)
        {
            char lettera = 'A';
            for (int i=0; i<Fnumeri.Length;i++)
            {
                txtFrequenze.Text += "[" + i + "]" + Fnumeri[i]+Environment.NewLine;
            }
            for (int i = 0; i < Flettere.Length; i++)
            {
                txtFrequenze.Text += "[" + lettera + "]" + Flettere[i] + Environment.NewLine;
                lettera++;
            }
        }
    }
}
