using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcolatricewindows
{
    /// <summary>
    /// Michele Sprocatti
    ///Funzioni:
    ///Calcolatrice funzionante per tutte e 4 le operazioni, radice, reciproco, negazione dell'operando, percentuale
    ///Tasto C, tasto CE, tasto backspace funzionanti
    ///input sia da tastiera che grafico(numeri, 4 simboli operazioni(prodotto con asterisco) e backspace)
    ///premuti da tastiera invio e uguale effettuano il calcolo
    /// </summary>
    public partial class Form1 : Form   
    {
        string operando="";//variabile inizializzata per i controlli all'interno del codice
        double operando1;
        double operando2;
        double risultato;
        public Form1()
        {
            InitializeComponent();
        }
       
        private void Elabora()//metodo che esegue i calcoli delle quattro operazioni
        {
            switch (operando)
            {
                //calcolo risultato in base a operando
                case "+":
                    risultato = operando1 + operando2;
                    break;
                case "*":
                    risultato = operando1 * operando2;
                    break;
                case "/":
                    if (operando2 != 0)//controllo secondo operando se uguale a 0
                        risultato = operando1 / operando2;
                    else
                       if (operando1 != 0)
                        MessageBox.Show("Divisione per zero", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                       else
                        MessageBox.Show("Risultato indefinito, 0/0", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case "-":
                    risultato = operando1 - operando2;
                    break;
            }

        }
        private void btncclear_Click(object sender, EventArgs e)//tasto C 
        {//cancellazione completa
            operando1 = 0;
            operando2 = 0;
            risultato = 0;
            operando = "";
            txtinput.Text="0";
            txtoutput.Clear();
        }

        private void btn8_Click(object sender, EventArgs e)//bottoni numeri
        {
            if (txtinput.Text == "0")
                txtinput.Clear();//cancellazione dello zero iniziale dalla textbox
            txtinput.Text += ((Button)sender).Text;
        }

        private void btnprodotto_Click(object sender, EventArgs e)//bottoni operandi
        {
            if (operando != "-")//controllo per negare secondo operando
                if (((Button)sender).Text == "-")
                    txtinput.Text += ((Button)sender).Text;
            else
            if (txtinput.Text != "")//controllo mancanza primo operando
            {
                txtoutput.Clear();
                bool operandoinserito = txtinput.Text[txtinput.Text.Length - 1] == '+' || txtinput.Text[txtinput.Text.Length - 1] == '*' || txtinput.Text[txtinput.Text.Length - 1] == '-' || txtinput.Text[txtinput.Text.Length - 1] == '÷';
                if (!operandoinserito)//controllo operando già inserito
                {
                    if (operando != "")
                        btncalcola.PerformClick();
                        operando1 = Convert.ToDouble(txtinput.Text);
                        operando = ((Button)sender).Text;
                        if (operando != "/")
                            txtinput.Text += operando;
                        else
                            txtinput.Text += "÷";//scrittura del carattere ÷ a posto del carattere /
                        txtoutput.Text += txtinput.Text;
                        txtinput.Clear();
                }
                else
                    MessageBox.Show("Operando già inserito", "Già inserito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("Manca primo operando", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btncalcola_Click(object sender, EventArgs e)//bottone uguale
        {
            if(operando!="")//controllo operando inserito
            {
                txtoutput.Text += txtinput.Text;
                if(txtinput.Text!="")//controllo 2 operando inserito
                {
                    operando2 = Convert.ToDouble(txtinput.Text);
                    txtinput.Clear();
                    Elabora();
                    if (operando != "/" || operando2 != 0)
                        txtinput.Text += risultato;
                    operando = "";
                    txtoutput.Clear();
                }
                else
                    MessageBox.Show("Secondo operando mancante", "Mancanza", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                if(operando1!=0)//controllo mancanza anche primo operando
                     MessageBox.Show("Operando mancante", "Mancanza", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    MessageBox.Show("primo operando, operando e secondo operando mancanti", "Mancanza", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnquadrato_Click(object sender, EventArgs e)//bottone per elevare al quadrato
        {
            double num;
            if (txtinput.Text != "")//controllo se numero presente o no
            {
                num = Convert.ToDouble(txtinput.Text);
                txtoutput.Text += "(" + num + ")^2";
                num *= num;
                txtinput.Clear();
                txtinput.Text += num;
            }
             else
                MessageBox.Show("Elemento di cui fare il quadrato mancante", "Mancanza", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnpercentuale_Click(object sender, EventArgs e)//bottone percentuale
        {
            double num;
            if (txtinput.Text != "")//controllo se numero presente o no
            {
                num = Convert.ToDouble(txtinput.Text);
                num = (num/100)*operando1;
                txtinput.Clear();
                txtinput.Text += num;
            }
             else   
                MessageBox.Show("Elemento di cui calcolare la percentuale mancante", "Mancanza", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnradice_Click(object sender, EventArgs e)//bottone radice
        {
            double num;
            if (txtinput.Text != "")//controllo se numero presente o no
            {
                num = Convert.ToDouble(txtinput.Text);
                if (operando1 >= 0)//controllo numero maggiore di zero
                {
                    txtoutput.Text += ((Button)sender).Text + num;
                    num = Math.Sqrt(num);
                    txtinput.Clear();
                    txtinput.Text += num;
                }
                else
                    MessageBox.Show("Radice di un numero negativo", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Elemento di cui calcolare la radice mancante", "Mancanza", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void btnreciproco_Click(object sender, EventArgs e)//bottone reciproco
        {
            double num;
            if (txtinput.Text != "")//controllo se numero presente o no
            {
                num = Convert.ToDouble(txtinput.Text);
                num = 1 / num;
                txtoutput.Text += 1 + "÷" + num;
                txtinput.Clear();
                txtinput.Text += num;
            }
            else
            MessageBox.Show("Elemento di cui calcolare fare il reciproco mancante", "Mancanza", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnbackspace_Click(object sender, EventArgs e)//bottone backspace
        {
            int dim = 0;
            string txt;
            if (txtinput.Text != "")//controllo se bisogna cancellare l'operando oppure un numero
            {
                dim = txtinput.Text.Length - 1;
                txt = txtinput.Text;
                txtinput.Clear();
            }
            else
            {
                dim = txtoutput.Text.Length - 1;
                txt = txtoutput.Text;
                txtoutput.Clear();
            }
            char[] input = new char[dim];
            for (int i = 0; i < txt.Length - 1; i++)
            {
                input[i] = txt[i];
            }
            //controllo ultimo carattere se è l'operando
            if (txt[txt.Length - 1] == '+' || txt[txt.Length - 1] == '*' || txt[txt.Length - 1] == '-' || txt[txt.Length - 1] == '÷')
                operando = "";
            foreach (var item in input)
            {
                txtinput.Text += item;
            }
        }

        private void btnvirgola_Click(object sender, EventArgs e)//bottone virgola
        {
            string s = txtinput.Text;
            int pos=s.IndexOf(",");//ricerca dell'elemento
            if(pos==-1)//controllo se presente o no
                txtinput.Text += ",";
            else
                if(s=="")//distinzione errore
                    MessageBox.Show("Impossibile effettuare inserimento", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Virgola già presente", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void txtinput_KeyPress(object sender, KeyPressEventArgs e)//key press
        {
            string btn="";
            char car = e.KeyChar;
             e.Handled = true;//non scrive nulla da tastiera
            if (e.KeyChar == '+' || e.KeyChar == '*' || e.KeyChar == '-' || e.KeyChar == '/')
            {
                switch (e.KeyChar)//distinzione operando premuto da tastiera
                {
                    case '+':
                        btnsomma.PerformClick();//sollevo evento click in base all'operando premuto
                        break;
                    case '-':
                        btndifferenza.PerformClick();
                        break;
                    case '/':
                        btndivisione.PerformClick();
                        break;
                    case '*':
                        btnprodotto.PerformClick();
                        break;
                }           
            }
            if (char.IsDigit(e.KeyChar))//controllo se viene premuto un numero
            {
                btn = "btn" + e.KeyChar;
                //controls è una collezione che contiene tutti gli elementi presenti nel form
                (Controls.Find(btn, true).FirstOrDefault() as Button).PerformClick();//sollevo l'evento click del bottone che ha come nome la stringa btn
            }
            if (e.KeyChar == '=' || e.KeyChar == 13)
                btncalcola.PerformClick();//sollevo evento click se viene premuto uguale o invio da tastiera
            if (e.KeyChar == '%')
                btnpercentuale.PerformClick();//sollevo evento click se viene premuto il tasto percentuale da tastiera
            if (e.KeyChar == ',')
                btnvirgola.PerformClick();//sollevo evento click se viene premuto il tasto virgola
            if (e.KeyChar == 8)
                btnbackspace.PerformClick();//sollevo evento click se viene premuto il tasto backspace
        }

        private void btnnegate_Click(object sender, EventArgs e)
        {//nego operando
            double num;
            if (txtinput.Text != "")
                num = Convert.ToDouble(txtinput.Text);
            else
                num = 0;
            num = num - (num * 2);
            txtinput.Clear();
            txtinput.Text += num;
        }

        private void Form1_Load(object sender, EventArgs e)
        {//scrivo nella textbox 0 e la seleziono
            txtinput.Text += "0";
            txtinput.Select();
        }

        private void btncanc_Click(object sender, EventArgs e)
        {//tasto CE
            int dim = 0;
            string txt;
            if (txtinput.Text != "")//controllo se è stato inserito solo il primo/secondo operando
            {
                txtinput.Clear();
                txtinput.Text += 0;
            }
            else
            {
                dim = txtoutput.Text.Length - 1;
                txt = txtoutput.Text;
                txtoutput.Clear();
                char[] input = new char[dim];
                for (int i = 0; i < txt.Length - 1; i++)
                {
                    input[i] = txt[i];
                }
                if (txt[txt.Length - 1] == '+' || txt[txt.Length - 1] == '*' || txt[txt.Length - 1] == '-' || txt[txt.Length - 1] == '÷')
                    operando = "";
                foreach (var item in input)
                {
                    txtinput.Text += item;
                }
            }
           
        }
    }
}
