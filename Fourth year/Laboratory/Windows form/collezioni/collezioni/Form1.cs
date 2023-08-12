using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace collezioni
{
    public partial class Form1 : Form
    {
        List<int> serie = new List<int>(4);
        public Form1()
        {
            InitializeComponent();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            if(txtinput.Text!="")
            {
                listBox1.Items.Add(txtinput.Text);
                txtinput.Clear();
                listBox1.SelectedIndex = 0;
                txtinput.Focus();
                lbconta.Text = listBox1.Items.Count.ToString();
            }

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            lbconta.Text = listBox1.Items.Count.ToString();
        }

        private void btnremoveat_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex!=-1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                if (listBox1.Items.Count != 0)
                    listBox1.SelectedIndex = 0;
                lbconta.Text = listBox1.Items.Count.ToString();
            }

        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            if(txtinput.Text!="")
            {
                listBox1.Items.Remove(txtinput.Text);
                if (listBox1.Items.Count != 0)
                    listBox1.SelectedIndex = 0;
                lbconta.Text = listBox1.Items.Count.ToString();
                txtinput.Clear();
                txtinput.Focus();
            }
        }

        private void btnaddrange_Click(object sender, EventArgs e)
        {
            string[] markeout = { "Fiat", "Lancia", "Ferrari", "Lamborghini" };//solo elementi tipo riferimento
            listBox1.Items.AddRange(markeout);
            lbconta.Text = listBox1.Items.Count.ToString();
        }

        private void btnaddvalue_Click(object sender, EventArgs e)
        {
            int[] num = { 1, 2, 3 };
            foreach (var item in num)
            {
                listBox1.Items.Add(item);
            }
            lbconta.Text = listBox1.Items.Count.ToString();
        }

        private void btninsert1_Click(object sender, EventArgs e)
        {
            if (serie.Count < serie.Capacity)
                if(int.TryParse(txtinput.Text,out int num))
                    serie.Add(num);
            else
                MessageBox.Show("Lista piena", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtinput.Clear();
            txtinput.Focus();
        }

        private void btndatasource_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;//azzera sorgente dati
            listBox1.DataSource = serie;//collega componente visuale ad una collezione l'inserimento manuale viene disattivata
        }

        private void btndatasorcenun_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
        }

        private void btnpreleva_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
                label1.Text += listBox1.Items[listBox1.SelectedIndex].ToString();
        }

        private void btntext_Click(object sender, EventArgs e)
        {
            if (txtinput.Text != "")
                listBox1.Text = txtinput.Text;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
                txtinput.Text = listBox1.Text;
        }
    }
}
