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


namespace DataAdapter
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        DataTable dt;
        SqlDataAdapter da;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnmarche_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (DataRow item in dt.Rows)
            {
                listBox1.Items.Add(item[1]);
            }
        }

        private void btnvisualizza_Click(object sender, EventArgs e)
        {
            string squery="SELECT * FROM MARCHE";
            dt = new DataTable("Auto");
            //1- 
            //da = new SqlDataAdapter(squery, con);

            // 2-
            //da = new SqlDataAdapter();
            //SqlCommand sqc = new SqlCommand(squery,con);
            //da.SelectCommand = sqc;

            //3 -
            //da = new SqlDataAdapter();
            //SqlCommand sqc = con.CreateCommand();
            //da.SelectCommand.CommandType = CommandType.Text;
            //da.SelectCommand.CommandText = squery;

            //4 -
                da = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = squery;
                da.SelectCommand = cmd;

            da.Fill(dt);
            label1.Text += dt.TableName;
            dataGridView1.DataSource = dt;
            label2.Text += dt.Rows.Count;
            con.Close();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\database\Auto.mdf;Integrated Security=True");
            con.Open();
        }
    }
}
