using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcolatrice
{
    public partial class Form1 : Form
    {
        double risultato;
        bool erroredivperzero = true;
        /*enum statoconversione
        {
          ok,
          operandomancante,
          divisoneperzero,
        }*/
        public Form1()
        {
            InitializeComponent();
        }
        private string Elabora(string operando, double operando1, double operando2)
        {
            string operazione = "";
            switch (operando)
            {
                case "+":
                    erroredivperzero = false;
                    risultato = operando1 + operando2;
                    operazione = operando1 + operando + operando2 + "=";
                    break;
                case "-":
                    erroredivperzero = false;
                    risultato = operando1 - operando2;
                    operazione = operando1 + operando + operando2 + "=";
                    break;
                case "*":
                    erroredivperzero = false;
                    risultato = operando1 * operando2;
                    operazione = operando1 + operando + operando2 + "=";
                    break;
                case "/":
                    if (operando2 != 0)
                    {
                        erroredivperzero = false;
                        risultato = operando1 / operando2;
                        operazione = operando1 + operando + operando2 + "=";
                    }
                    else
                        if(operando1==0)
                        {
                        MessageBox.Show("Risultato indefinito", "Entrambi operandi 0", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        erroredivperzero = false;
                        }
                         else
                         {
                            erroredivperzero = true;
                            MessageBox.Show("Divisione per zero", "Erorre calcolo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                         }
                    break;
            }
            return operazione;
        }

        private void btnsomma_Click(object sender, EventArgs e)
        {
            txtrisultato.Clear();
            double operando1=0;
            double operando2=0;
            txtoperazione.Clear();
            string operando = ((Button)sender).Text;
            if (txt1operando.Text != ""||txt2operando.Text!="")
            {
                if(txt1operando.Text!="")
                operando1 = Convert.ToDouble(txt1operando.Text);
                else
                    MessageBox.Show("1 operando mancante", "Manca elemento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if(txt2operando.Text!="")
                    operando2 = Convert.ToDouble(txt2operando.Text);
                else
                    MessageBox.Show("2 operando mancante", "Manca elemento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Entrambi operandi mancanti", "Manca elemento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (txt1operando.Text != "" && txt2operando.Text != "")
                txtoperazione.Text += Elabora(operando, operando1, operando2);
        }

        private void btnuguale_Click(object sender, EventArgs e)
        {
            txtrisultato.Clear();
            if(!erroredivperzero)
            txtrisultato.Text += risultato;
        }

        private void txt1operando_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != '-' && e.KeyChar != 8&& e.KeyChar!=',')
                e.Handled = true;
            if (((TextBox)sender).Name == txt1operando.Name)
                if (e.KeyChar == (char)Keys.Return)
                    txt2operando.Focus();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Chiudere il programma?", "Chiusura", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }
    }
}
