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
        DataTable dt;
        DataSet dsAuto;

        public Form1()
        {
            InitializeComponent();            
        }

        private void button2_Click(object sender, EventArgs e) //visualizza
        {            
            string query = "SELECT * FROM MARCHE";
            da = new SqlDataAdapter(query, con);
            con.Open();

            da.Fill(dsAuto, "Marche");

            query = "SELECT * FROM CLASSI";
            da.SelectCommand.CommandText = query;
            da.Fill(dsAuto, "Classi");

            query = "SELECT * FROM MODELLI";
            da.SelectCommand.CommandText = query;
            da.Fill(dsAuto, "Modelli");

            con.Close();

            foreach(DataTable table in dsAuto.Tables)
            {
                listBox1.Items.Add(table.TableName);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source =.\; Initial Catalog = Auto; Integrated Security = True");
            dsAuto = new DataSet("auto");

        }

        private void button3_Click(object sender, EventArgs e)//marche
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = dsAuto;
            if(listBox1.SelectedIndex != -1)
            {
                //dataGridView1.DataMember = (string)listBox1.Items[listBox1.SelectedIndex];
                dataGridView1.DataSource = dsAuto.Tables[listBox1.SelectedIndex];
            }
        }
    }
}
