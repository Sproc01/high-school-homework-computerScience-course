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
    public partial class Form2 : Form
    {
        SqlConnection conn;
        public Form2(SqlConnection c)
        {
            conn = c;
            InitializeComponent();
        }
        private void visualizza(string sqlcmd)
        {
            SqlCommand cmd;
            SqlDataReader read;
            /*cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sqlcmd;*/
            cmd = new SqlCommand(sqlcmd, conn);
            read = cmd.ExecuteReader();
            while (read.Read())
            {
                //1 modalità
                //listBox1.Items.Add(read["codice"].ToString()+" " + read["marca"].ToString()+" "+read["citta"].ToString());
                //2 modalità
                //listBox1.Items.Add(read[0].ToString() + " " + read[1].ToString() + " " + read[2].ToString());
                //3 modalità
                listBox1.Items.Add(read.GetInt32(0) + " " + read.GetString(1) + " " + read.GetString(2));
            }
            read.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            visualizza("SELECT * FROM MARCHE");
        }
    }
}
