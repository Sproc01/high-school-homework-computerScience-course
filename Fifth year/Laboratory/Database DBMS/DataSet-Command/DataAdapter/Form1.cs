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
        SqlDataAdapter da;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnvisualizza_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string squery="SELECT * FROM MARCHE";
            da = new SqlDataAdapter(squery,con);
            da.Fill(ds, "Marche");

            squery = "SELECT * FROM CLASSI";
            da.SelectCommand.CommandText = squery;
            da.Fill(ds, "Classi2");

            squery = "SELECT * FROM MODELLI";
            da.SelectCommand.CommandText = squery;
            da.Fill(ds, "Modelli");
            con.Close();
            foreach (DataTable item in ds.Tables)
            {
                listBox1.Items.Add(item.TableName);
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\database\Auto.mdf;Integrated Security=True");
            con.Open();
            ds = new DataSet("auto");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = ds;
            if(listBox1.SelectedIndex!=-1)
            {
                //dataGridView1.DataMember = (String)listBox1.Items[listBox1.SelectedIndex];
                dataGridView1.DataSource = ds.Tables[listBox1.SelectedIndex];
            }
        }

        private void button2_Click(object sender, EventArgs e)//conferma
        {
            if (ds.Tables[listBox1.SelectedIndex] != null)
            {
                ds.Tables[listBox1.SelectedIndex].AcceptChanges();
            }
        }

        private void button5_Click(object sender, EventArgs e)//versione
        {
            listBox3.Items.Clear();
            string item = "";
            foreach (DataRow row in ds.Tables[listBox1.SelectedIndex].Rows)
            {
                foreach (DataColumn col in ds.Tables[listBox1.SelectedIndex].Columns)
                {
                    item = "Valore originale:" + row[col, DataRowVersion.Original].ToString() + " Valore corrente: " + row[col, DataRowVersion.Current].ToString();
                    listBox3.Items.Add(item);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)//stato
        {
            listBox2.Items.Clear();
            if (ds.Tables[listBox1.SelectedIndex] != null)
                foreach (DataRow item in ds.Tables[listBox1.SelectedIndex].Rows)
                {
                    listBox2.Items.Add(item.RowState.ToString());
                }
        }

        private void button4_Click(object sender, EventArgs e)//aggiorna
        {
            string sq = "SELECT * FROM " + ds.Tables[listBox1.SelectedIndex];
            SqlDataAdapter sda = new SqlDataAdapter(sq, con);
            SqlCommandBuilder cmdb = new SqlCommandBuilder(sda);
            sda.Update(ds, ds.Tables[listBox1.SelectedIndex].ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ds.Tables[listBox1.SelectedIndex]!=null)
            {
                ds.Tables[listBox1.SelectedIndex].RejectChanges();
            }
        }
    }
}
