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

        private void button1_Click(object sender, EventArgs e)//stato
        {
            listBox2.Items.Clear();
            if(dt!=null)
                foreach (DataRow item in dt.Rows)
                {
                    listBox2.Items.Add(item.RowState.ToString());
                }
        }

        private void button2_Click(object sender, EventArgs e)//accetta
        {
            if(dt!=null)
            {
                dt.AcceptChanges();
            }
        }

        private void button3_Click(object sender, EventArgs e)//undo
        {
            if (dt != null)
            {
                dt.RejectChanges();
            }
        }

        private void button4_Click(object sender, EventArgs e)//aggiorna
        {
            SqlCommandBuilder cmdb = new SqlCommandBuilder(da);
            da.Update(dt);//esegue le modifiche eseguite su datatable nel database 
        }

        private void button5_Click(object sender, EventArgs e)//versione
        {
            listBox3.Items.Clear();
            string item = "";
            foreach(DataRow row in dt.Rows)
            {
                foreach (DataColumn col in dt.Columns)
                {
                    item = "Valore originale:" + row[col, DataRowVersion.Original].ToString() + " Valore corrente: " + row[col, DataRowVersion.Current].ToString();
                    listBox3.Items.Add(item);
                }
            }
        }
    }
}
