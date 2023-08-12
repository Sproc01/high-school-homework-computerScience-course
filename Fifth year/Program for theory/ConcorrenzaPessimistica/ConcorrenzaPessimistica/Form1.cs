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

namespace ConcorrenzaPessimistica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btnclicca_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\;Initial Catalog=Auto;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM CONTATORE WITH(XLOCK)", con);
            con.Open();
            SqlTransaction tr = con.BeginTransaction(IsolationLevel.Serializable);
            cmd.Transaction = tr;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            int cntold = Convert.ToInt32(dt.Rows[0][0].ToString());
            //byte[] time = (byte[])dt.Rows[0][1];
            int cntnew = cntold + 1;
            Thread.Sleep(5000);
            //TMP=PARSE('{time}' AS TIMESTAMP)
            cmd = new SqlCommand($"UPDATE CONTATORE SET CNT='{cntnew}' WHERE TMP=@TIME", con);
            cmd.Parameters.Add("@time", SqlDbType.Timestamp).Value = dt.Rows[0][1];
            cmd.Transaction = tr;
            Rowcount.Text = cmd.ExecuteNonQuery().ToString();               
            cmd = new SqlCommand("SELECT * FROM CONTATORE", con);
            cmd.Transaction = tr;
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            Contatore.Text = dt.Rows[0][0].ToString();
            cmd.Transaction.Commit();
            con.Close();
        }
    }
}
