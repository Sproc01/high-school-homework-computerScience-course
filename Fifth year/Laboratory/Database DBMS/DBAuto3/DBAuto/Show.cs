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
    public partial class ShowList : Form
    {
        SqlConnection conn;
        public ShowList(SqlConnection c)
        {
            InitializeComponent();
            conn = c;
        }

        private void btnClose_Click(object sender, EventArgs e)
        { Close();}
        private void Visualizza(string sqlCmd)
        {
            SqlCommand cmd;
            SqlDataReader dr;
            /*cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sqlCmd;*/
            cmd = new SqlCommand(sqlCmd, conn);
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                //listBox1.Items.Add(dr["Codice"].ToString() + " " + dr["marca"].ToString() + " " + dr["citta"].ToString());
                //listBox1.Items.Add(dr[0].ToString() + " " + dr[1].ToString() + " " + dr[2].ToString());
                listBox1.Items.Add(dr.GetInt32(0) + " " + dr.GetString(1) + " " + dr.GetString(2));
            }
            dr.Close();
        }

        private void Show_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Visualizza("SELECT * FROM MARCHE");
        }
    }
}
