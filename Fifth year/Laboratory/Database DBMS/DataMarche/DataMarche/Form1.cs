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

namespace DataMarche
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        DataTable dt;
        SqlDataAdapter da;
        public Form1()
        {
            InitializeComponent();
            dt = new DataTable("Marche");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\database\\Auto.mdf; Integrated Security = True");
            con.Open();
        }

        private void button1_Click(object sender, EventArgs e)//visualizza
        {
            string sq = "SELECT * FROM MARCHE";
            da = new SqlDataAdapter(sq, con);
            //da.FillSchema(dt, SchemaType.Source);
            //da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)//bologna
        {
            string sq = "SELECT * FROM MARCHE WHERE Città='BOLOGNA'";
            da = new SqlDataAdapter(sq, con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int col = 0; col < dt.Columns.Count; col++)
            {
                string descr = "";
                descr += dt.Columns[col].ColumnName.ToUpper() + " Proprietà: ";
                descr += dt.Columns[col].AutoIncrement ? " Autoincrementa |" : " Non autoincrementa |";
                descr += " Lunghezza massima: " + dt.Columns[col].MaxLength+ " |";
                descr += dt.Columns[col].ReadOnly ? " Solo lettura |" : " Modificabile |";
                descr += dt.Columns[col].Unique ? " Unico |" : " Non unico |";
                descr += dt.Columns[col].DataType.ToString();
                listBox1.Items.Add(descr);
            }
        }
    }
}
