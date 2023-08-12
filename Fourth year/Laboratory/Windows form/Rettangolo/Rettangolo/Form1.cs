using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rettangolo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static void errore(int e)
        {
            string errore="";
            switch (e)
            {
                case 1:
                    errore = "manca la base";
                    break;
                case 2:
                    errore = "manca l'altezza";
                    break;
                case 3:
                    errore = "entrambe vuote";
                    break;
                case 4:
                    errore = "Formato errato";
                    break;
            }
            MessageBox.Show(errore, "Errore input", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void rdperimetro_CheckedChanged(object sender, EventArgs e)//radiobutton
        {
            if (rdperimetro.Checked)
                loutput.Text = "Perimetro";//cambio testo label output
            else
            {
                loutput.Text = "Area";
                txtoutput.Clear();
            }
        }

        private void btncalcola_Click(object sender, EventArgs e)
        {
            double Base=0;
            double Altezza=0;
            double Output;
            bool inputbase=true;
            bool inputaltezza=true;
            //inserimento
            /*try
            {
                Base = Convert.ToDouble(txtbase.Text);
                input = true;
            }
            catch (Exception)
            {
                input = false;
                MessageBox.Show("Errore inserimento base", "Errore input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(input)
            try
            {
                input = true;
                Altezza = Convert.ToDouble(txtaltezza.Text);
            }
            catch (Exception)
            {
                input = false;
                MessageBox.Show("Errore inserimento altezza", "Errore input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
            if (txtaltezza.Text == "" && txtbase.Text == "")
            {
                inputbase = false;
                errore(3);
            }         
            else
            {
                if (txtbase.Text == "")
                {
                    inputbase = false;
                    errore(1);
                }
                else
                    try
                    {
                        Base = Convert.ToDouble(txtbase.Text);
                        inputbase = true;
                    }
                    catch (Exception)
                    {
                        inputbase = false;
                        errore(4);
                    }
                if (txtaltezza.Text == "")
                {
                    inputaltezza = false;
                    errore(2);
                }
                else
                    try
                    {
                        Altezza = Convert.ToDouble(txtaltezza.Text);
                        inputaltezza = true;
                    }
                    catch (Exception)
                    {
                        inputaltezza = false;
                        errore(4);
                    }
            }
            if (inputbase&&inputaltezza)
            {//calcolo in base al radiobutton
                if (rdperimetro.Checked)
                    Output = (Base + Altezza) * 2;
                else
                    Output = (Base * Altezza) / 2;
                txtoutput.Text = Output.ToString();
            }             
        }

        private void btncancella_Click(object sender, EventArgs e)//pulizia textbox
        {
            txtaltezza.Clear();
            txtbase.Clear();
            txtoutput.Clear();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
                Close();//chiusura programma
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Vuoi chiudere l'applicazione?", "Chiusura programma", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                e.Cancel=true;//chiusura programma
            
        }
    }
}
