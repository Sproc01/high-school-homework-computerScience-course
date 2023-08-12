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
    public partial class ShowGridDelete : Form
    {
        SqlConnection conn;
        public ShowGridDelete(SqlConnection c)
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
            cmd = new SqlCommand(sqlcmd, conn);
            read = cmd.ExecuteReader();
            while (read.Read())
            {              
                dataGridView1.Rows.Add(read.GetInt32(0), read.GetString(1),read.GetString(2));                
            }
            read.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
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

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Rimozione riga?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dr==DialogResult.Yes)
            {
                int celRow = dataGridView1.CurrentRow.Index;
                string messagge;
                if (Del(dataGridView1[1,celRow].Value.ToString(), dataGridView1[2,celRow].Value.ToString(), out messagge) != -1)
                    MessageBox.Show(messagge, "Cancellazione", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    MessageBox.Show(messagge, "Cancellazione", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
        private int Del(string marca, string città, out string message)
        {
            string sql = string.Format("DELETE MARCHE WHERE MARCA='{0}' AND  CITTA='{1}'", marca, città);
            SqlCommand cmd = new SqlCommand(sql,conn);
            try
            {
                message = "cancellazione corretta";
                return cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                message = ex.Message;
                return -1;
            }
        }
    }
}
