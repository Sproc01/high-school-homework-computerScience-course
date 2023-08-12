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
    public partial class ShowGridDelete : Form
    {
        SqlConnection conn;
        public ShowGridDelete(SqlConnection c)
        {
            InitializeComponent();
            conn = c;
        }

        private void btnClose_Click(object sender, EventArgs e)
        { Close(); }
        private void Visualizza(string sqlCmd)
        {
            SqlCommand cmd;
            SqlDataReader dr;
            /*cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sqlCmd;*/
            cmd = new SqlCommand(sqlCmd, conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr.GetInt32(0), dr.GetString(1), dr.GetString(2));
            }
            dr.Close();
        }

        private void ShowGrid_Load(object sender, EventArgs e)
        {
            Visualizza("SELECT * FROM MARCHE");
        }
        private int Righe(string sqlQry)
        {
            SqlCommand cmd = new SqlCommand(sqlQry, conn);
            return (int)cmd.ExecuteScalar();
        }
        private int Citta(string sqlQry)
        {
            SqlCommand cmd = new SqlCommand(sqlQry, conn);
            return (int)cmd.ExecuteScalar();
        }

        private void btnCerca_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DialogResult risposta;
            risposta = MessageBox.Show("Rimozione riga?", "Cancella", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (risposta == DialogResult.Yes)
            {
                string Message;
                int selRow = dataGridView1.CurrentRow.Index;
                if (Del(dataGridView1[1, selRow].Value.ToString(), dataGridView1[2, selRow].Value.ToString(), out Message) != -1)
                    MessageBox.Show(Message, "Elemento cancellato", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(Message, "Cancellazione non eseguita", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int Del(string Marca, string Citta, out string Message)
        {
            SqlCommand cmd;
            string sql = string.Format("DELETE FROM MARCHE WHERE MARCA = '{0}' AND CITTA = '{1}'", Marca, Citta);
            cmd = new SqlCommand(sql, conn);
            try
            {
                Message = "Cancellazione eseguita";
                return cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Message = ex.Message;
                return -1;
            }
        }
    }
}
