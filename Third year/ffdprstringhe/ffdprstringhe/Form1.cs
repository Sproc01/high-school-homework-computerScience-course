using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ffdprstringhe
{
    public partial class Form1 : Form
    {
        char[] charinput;
        string input;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnvisualizzza_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("messaggio", "errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            input = txtinput.Text;
            foreach (char carattere in input)
            {
                txtvisualizza.Text += carattere + Environment.NewLine;
            }
        }
        private void btnVisualizzaindice_Click(object sender, EventArgs e)
        {
            input = txtinput.Text;
            for (int i = 0; i < input.Length; i++)
            {
                txtvisualizza.Text += input[i] + Environment.NewLine;
            }
        }
        private void btnstringa_Click(object sender, EventArgs e)
        {
            input = txtinput.Text;
            charinput = input.ToCharArray();
            for (int i = 0; i < charinput.Length; i++)
            {
                txtvisualizza.Text += charinput[i] + Environment.NewLine;
            }
        }
        private void btnmodifica_Click(object sender, EventArgs e)
        {
            char input;
            int posizione=Convert.ToInt32(txtposizione.Text);
            input = Convert.ToChar(txtchar.Text);
            if (posizione >= 0 && posizione <= (charinput.Length - 1))
                charinput[posizione] = input;
            else
            {
                MessageBox.Show("Posizione errata ", "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtposizione.Select();
            }
        }
        private void btnvettorestringa_Click(object sender, EventArgs e)
        {
            txtvisualizza.Clear();
            for (int i = 0; i < charinput.Length; i++)
            {
                txtvisualizza.Text+= charinput[i]+Environment.NewLine;
            }
        }
        private void btncontrolla_Click(object sender, EventArgs e)
        {
            string input = txtinput.Text;
            char car = Convert.ToChar(txtchar.Text);
            txtposizione.Text = input.IndexOf(car).ToString();
        }
        private void btncontrolla_Click_1(object sender, EventArgs e)
        {
            string input = txtinput.Text;
            string sub = txtchar.Text;
            txtposizione.Text = input.IndexOf(sub).ToString();
        }
        private void btnsubstringa_Click(object sender, EventArgs e)
        {
            string input = txtinput.Text;
            string sub = txtchar.Text;
            txtvisualizza.Text = input.Substring(input.IndexOf(sub));
        }
        private void btnsubstringa2_Click(object sender, EventArgs e)
        {
            string input = txtinput.Text;
            string sub = txtchar.Text;
            txtvisualizza.Text = input.Substring(input.IndexOf(sub),Convert.ToInt32(txtposizione.Text));
        }
        private void btnremove_Click(object sender, EventArgs e)
        {
            string input = txtinput.Text;
            string sub = txtchar.Text;
            input = input.Remove(input.IndexOf(sub));
            txtvisualizza.Text = input;
        }
        private void btnsplit_Click(object sender, EventArgs e)
        {
            string input = txtinput.Text;
            string[] parole = input.Split(' ');
            foreach (string parola in parole)
            {
                txtvisualizza.Text += parola + Environment.NewLine;
            }
        }
    }
}
