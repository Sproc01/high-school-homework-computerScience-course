using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ffdprConSql
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlConnectionStringBuilder builder;
        DataTable tblProviders;
        public Form1()
        {
            InitializeComponent();
        }       
        private DataTable DbProviders()
        {
            DataTable dbProviders = DbProviderFactories.GetFactoryClasses();//contiene tutte le infornmazione relative ai
            return dbProviders;                                             //provider installati.            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            txtProvider.Clear();
            builder = new SqlConnectionStringBuilder();
            builder.DataSource = textBox1.Text;
            builder.InitialCatalog =textBox2.Text;
            builder.UserID = textBox4.Text;
            builder.Password = textBox5.Text;
            builder.IntegratedSecurity = true;//false per specificare user id e password
            builder.PersistSecurityInfo = false;// settato a true permette di vedere la password.
            conn = new SqlConnection(builder.ConnectionString);                       
            try
            {
                conn.Open();               
                MessageBox.Show("Connessione Eseguita\r\n" + conn.ServerVersion + "\r\n" + conn.ConnectionString);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Connessione Connessione Fallita" + ex.ToString());
            }                
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            tblProviders = DbProviders();
            foreach (DataRow row in tblProviders.Rows)
            {
                txtProvider.Text += row[0].ToString() + Environment.NewLine;
            }                             
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
