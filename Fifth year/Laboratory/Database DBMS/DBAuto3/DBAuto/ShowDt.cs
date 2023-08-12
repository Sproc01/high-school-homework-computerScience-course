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
    public partial class ShowDt : Form
    {
        SqlConnection conn;
        DataTable dt;
        public ShowDt(SqlConnection c)
        {
            conn = c;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
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

        private void ShowDt_Load(object sender, EventArgs e)
        {
            Visualizza("SELECT * FROM MARCHE");
        }
    }
}
