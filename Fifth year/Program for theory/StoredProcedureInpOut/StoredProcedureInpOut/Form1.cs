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

namespace StoredProcedureInpOut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.\\;Initial Catalog=Auto;Integrated Security=True");
            SqlCommand command = conn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "ElencoMarche";
            command.Parameters.Add("@CodiceMarca", SqlDbType.Int).Value=8;
            SqlParameter param= command.Parameters.Add("@NumRighe", SqlDbType.Int);
            param.Direction = ParameterDirection.Output;
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            conn.Open();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            textBox1.Text = param.Value.ToString();
        }
    }
}
