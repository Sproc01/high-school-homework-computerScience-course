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

namespace DBAuto
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            if (con == null)
            {
                try
                {
                    con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=L:\\Dati\\Informatica\\Laboratorio\\Database DBMS\\database\\Auto.mdf;Integrated Security=True");
                    textBox1.Text += "Connessione creata" + Environment.NewLine;
                }
                catch (SqlException ex)
                {
                    textBox1.Text += "Errore di connessione: " + ex.ToString() + Environment.NewLine;
                }
            }
            else
                textBox1.Text += "Connessione già istanziata";

            if(con.State != ConnectionState.Open)
            {
                try
                {
                    con.Open();
                    textBox1.Text += "Connessione aperta" + Environment.NewLine;
                }
                catch (SqlException ex)
                {
                    textBox1.Text += "Errore di Connessione: " + ex.ToString() + Environment.NewLine;
                }
            }
        }

        private void checkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            if(con != null)
            {
                textBox1.Text += "Stringa di connessione: " + con.ConnectionString + Environment.NewLine;
                textBox1.Text += "Stato della connessione: " + con.State.ToString() + Environment.NewLine;
                textBox1.Text += "Data Source = " + con.DataSource + Environment.NewLine;                
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            if(con != null)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                    textBox1.Text = "Connessione chiusa";
                    
                }
                con = null;
            }
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            if (con != null && con.State == ConnectionState.Open)
            {
                ShowList sh = new ShowList(con);
                sh.Show();
            }
            else textBox1.Text= "Controllare la connessione";
        }

        private void tableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            if (con != null && con.State == ConnectionState.Open)
            {
                ShowGrid sh = new ShowGrid(con);
                sh.Show();
            }
            else textBox1.Text = "Controllare la connessione";
        }

        private void tableViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            if (con != null && con.State == ConnectionState.Open)
            {
                ShowGrid2 sh2 = new ShowGrid2(con);
                sh2.Show();
            }
            else textBox1.Text = "Controllare la connessione";
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            if (con != null && con.State == ConnectionState.Open)
            {
                Insert insert = new Insert(con);
                insert.Show();
            }
            else textBox1.Text = "Controllare la connessione";
        }

        private void tableViewTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            if (con != null && con.State == ConnectionState.Open)
            {
                ShowDt sh2 = new ShowDt(con);
                sh2.Show();
            }
            else textBox1.Text = "Controllare la connessione";
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            if (con != null && con.State == ConnectionState.Open)
            {
                ShowGridDelete sh2 = new ShowGridDelete(con);
                sh2.Show();
            }
            else textBox1.Text = "Controllare la connessione";
        }

        private void modifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            if (con != null && con.State == ConnectionState.Open)
            {
                Update sh2 = new Update(con);
                sh2.Show();
            }
            else textBox1.Text = "Controllare la connessione";
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            if (con != null && con.State == ConnectionState.Open)
            {
                Search sh2 = new Search(con);
                sh2.Show();
            }
            else textBox1.Text = "Controllare la connessione";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            textBox1.Clear();
            if (con != null)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                    textBox1.Text = "Connessione chiusa";

                }
                con = null;
            }
        }
    }
}
