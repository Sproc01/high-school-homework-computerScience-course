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
    public partial class Update : Form
    {
        SqlConnection conn;
        DataTable dt;
        public Update(SqlConnection c)
        {
            conn = c;
            InitializeComponent();
        }

        private void btnModfica_Click(object sender, EventArgs e)
        {
            string message;
            if (Mod(textBox2.Text, textBox3.Text,out message) != -1)
                MessageBox.Show(message, "Elemento modificato", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(message, "Modifica non eseguita", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Visualizza("SELECT * FROM MARCHE");
        }
        private void Visualizza(string sqlCmd)
        {
            dt = new DataTable();
            SqlCommand cmd;
            SqlDataReader dr;
            cmd = new SqlCommand(sqlCmd, conn);
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            dr.Close();
        }
        private void btnChiudi_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Update_Load(object sender, EventArgs e)
        {
            Visualizza("SELECT * FROM MARCHE");
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int celRow = dataGridView1.CurrentRow.Index;
            textBox1.Text = dataGridView1[0, celRow].Value.ToString();
            textBox2.Text = dataGridView1[1, celRow].Value.ToString();
            textBox3.Text = dataGridView1[2, celRow].Value.ToString();
            
        }
        private int Mod(string Marca, string Citta, out string Message)
        {
            SqlCommand cmd;
            string sql = string.Format($"UPDATE MARCHE SET CITTA='{Citta}' WHERE MARCA = '{Marca}'");
            cmd = new SqlCommand(sql, conn);
            try
            {
                Message = "Modifica eseguita";
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
