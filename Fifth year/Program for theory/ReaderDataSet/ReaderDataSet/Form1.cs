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

namespace ReaderDataSet
{
    public partial class Form1 : Form
    {
        DataTable d1;
        DataTable d2;
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    dataGridView1.DataSource = d1;
                    break;
                case 1:
                    dataGridView1.DataSource = d2;
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.\\;Initial Catalog=Auto;Integrated Security=True");
            SqlCommand co = conn.CreateCommand();
            co.CommandType = CommandType.StoredProcedure;
            co.CommandText = "ElencoMarche";
            co.Parameters.Add("@CodiceMarca", SqlDbType.Int).Value = 2;
            SqlParameter param = co.Parameters.Add("@NumRighe", SqlDbType.Int);
            param.Direction = ParameterDirection.Output;
            conn.Open();
            SqlDataReader dr = co.ExecuteReader();

            d1 = new DataTable();
            d1.Load(dr);
            dataGridView1.DataSource = d1;
            //SqlDataReader dr1 = co.ExecuteReader();
            //d2 = new DataTable();
            //dr1.NextResult();
            //string i = dr1.GetValue(0).ToString();
            //comboBox1.DataSource = new List<int>() { 1, 2 };
        }
    }
}
