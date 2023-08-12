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
    public partial class ShowGrid : Form
    {
        SqlConnection conn;
        public ShowGrid(SqlConnection c)
        {
            conn = c;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void visualizza(string sqlcmd)
        {
            SqlCommand cmd;
            SqlDataReader read;
            DataTable db = new DataTable();
            cmd = new SqlCommand(sqlcmd, conn);
            read = cmd.ExecuteReader();
            db.Load(read);
            read.Close();
            dataGridView1.DataSource = db;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            label1.Text += righe("SELECT COUNT (*) FROM MARCHE");
            visualizza("SELECT * FROM MARCHE");
        }

        private int righe(string sqlquery)
        {
            SqlCommand cmd= new SqlCommand(sqlquery, conn);
            return (int)cmd.ExecuteScalar();
        }

        private int marcheCitta(string sqlquery)
        {
            SqlCommand cmd = new SqlCommand(sqlquery, conn);
            return (int)cmd.ExecuteScalar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "N°:";
            if(textBox1.Text!="")
                label3.Text += marcheCitta(string.Format("SELECT COUNT (*) FROM MARCHE WHERE CITTA = '{0}' ", textBox1.Text));
        }
    }
}
