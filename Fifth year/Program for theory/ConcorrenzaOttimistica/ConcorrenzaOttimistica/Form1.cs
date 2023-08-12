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
using System.Threading;

namespace ConcorrenzaOttimistica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClicca_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\;Initial Catalog=Auto;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM CONTATORE", con);
            con.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            //SqlDataReader  dr= cmd.ExecuteReader();
            //dr.Read();
            //var time = dr.GetSqlBinary(1);
            //int cntold = dr.GetInt32(0);
            int cntold = Convert.ToInt32(dt.Rows[0][0].ToString());
            //dr.Close();
            //var time = dt.Rows[0][1].;
            int cntnew = cntold+1;
            Thread.Sleep(5000);
            cmd = new SqlCommand($"UPDATE CONTATORE SET CNT='{cntnew}' WHERE TMP=@time", con);
            //cmd.Parameters.Add("@time", SqlDbType.Timestamp).Value=time;
            cmd.Parameters.Add("@time", SqlDbType.Timestamp).Value = dt.Rows[0][1];
            int i = cmd.ExecuteNonQuery();
            Rowcount.Text = i.ToString();
            cmd = new SqlCommand("SELECT * FROM CONTATORE", con);
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            Contatore.Text =dt.Rows[0][0].ToString();
            con.Close();
        }
    }
}
