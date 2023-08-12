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

namespace EsercizioRipasso
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        DataSet ds;
        SqlDataAdapter da;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=.\\;Initial Catalog=Auto;Integrated Security=True");
            con.Open();
            ds = new DataSet();
            da = new SqlDataAdapter("SELECT * FROM MODELLI", con);
            da.Fill(ds, "Modelli");
            da = new SqlDataAdapter("SELECT * FROM MARCHE", con);
            da.Fill(ds, "Marche");
            comboBox1.DataSource = new List<string>() {"Marche", "Modelli" };
            comboBox1.SelectedIndex = 0;
            dataGridView1.DataSource = ds.Tables[comboBox1.SelectedIndex];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
                dataGridView1.DataSource = ds.Tables[comboBox1.SelectedIndex];
        }

        private void btnaggiorna_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex==1)
            {
                SqlCommandBuilder cmd = new SqlCommandBuilder(da);
                da.Update(ds, "Marche");
            }
        }
    }
}
