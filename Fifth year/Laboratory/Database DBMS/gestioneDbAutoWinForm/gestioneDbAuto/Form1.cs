using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace gestioneDbAuto
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            if (conn == null)
                try
                {
                    conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=L:\\Dati\\Informatica\\Laboratorio\\Database DBMS\\database\\Auto.mdf;Integrated Security=True");
                    textBox1.Text += "Connessione creata" + Environment.NewLine;
                }
                catch (SqlException ex)
                {
                    textBox1.Text += "Errore di connessione" + ex.ToString() + Environment.NewLine;
                }
            else
                textBox1.Text += "Connessione già avvenuta" + Environment.NewLine;

            if(conn.State!=ConnectionState.Open)
                try
                {
                    conn.Open();
                    textBox1.Text += "Connessione aperta" + Environment.NewLine;
                }
                catch (SqlException ex)
                {
                    textBox1.Text += "Errore nell'apertura connessione" + ex.ToString() + Environment.NewLine;
                }              
        }

        private void checkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            if(conn!=null)
            {
                textBox1.Text += "Data Source: " + conn.DataSource + Environment.NewLine;
                textBox1.Text += "Connection String: " + conn.ConnectionString + Environment.NewLine;
                textBox1.Text += "Connection state: " + conn.State + Environment.NewLine;
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (conn != null)
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                    textBox1.Text += "Connessione chiusa" + Environment.NewLine;
                    conn = null;
                }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (conn != null)
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                    textBox1.Text += "Connessione chiusa" + Environment.NewLine;
                    conn = null;
                }
            Close();
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            if (conn != null && conn.State == ConnectionState.Open)
            {
                Form2 win = new Form2(conn);
                win.Show();
            }
            else
                textBox1.Text = "Connessione non aperta";
        }

        private void tabelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            if (conn != null && conn.State == ConnectionState.Open)
            {
                Form3 win = new Form3(conn);
                win.Show();
            }
            else
                textBox1.Text = "Connessione non aperta";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (conn != null)
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                    textBox1.Text += "Connessione chiusa" + Environment.NewLine;
                    conn = null;
                }
        }

        private void tabelviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            if (conn != null && conn.State == ConnectionState.Open)
            {
                ShowGrid win = new ShowGrid(conn);
                win.Show();
            }
            else
                textBox1.Text = "Connessione non aperta";
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                Insert win = new Insert(conn);
                win.Show();
            }
            else
                textBox1.Text = "Connessione non aperta";
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                ShowGridDelete win = new ShowGridDelete(conn);
                win.Show();
            }
            else
                textBox1.Text = "Connessione non aperta";
        }
    }
}
