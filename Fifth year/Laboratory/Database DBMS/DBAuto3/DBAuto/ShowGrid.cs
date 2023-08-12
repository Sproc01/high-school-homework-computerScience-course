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
    public partial class ShowGrid : Form
    {
        SqlConnection conn;
        public ShowGrid(SqlConnection c)
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
            label1.Text = "";
            Visualizza("SELECT * FROM MARCHE");
            label1.Text += Righe("SELECT COUNT(*) FROM MARCHE");
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
            string sql = $"SELECT COUNT (*) FROM MARCHE WHERE Citta='{textBox1.Text}'";
            label3.Text += Citta(sql);
        }
    }
}
