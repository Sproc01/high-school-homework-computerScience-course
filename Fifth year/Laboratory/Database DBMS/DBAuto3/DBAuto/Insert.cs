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
    public partial class Insert : Form
    {
        SqlConnection conn;
        public Insert(SqlConnection connection)
        {
            InitializeComponent();
            conn = connection;
        }

        public int Ins(string Marca, string Citta,out string Message)
        {
            SqlCommand cmd;
            string sql = string.Format("INSERT INTO MARCHE (MARCA,CITTA) VALUES (@MARCA , @CITTA)");
            cmd = new SqlCommand(sql, conn);
            SqlParameter param = new SqlParameter("@MARCA", SqlDbType.NVarChar,20);
            cmd.Parameters.Add(param);
            param = new SqlParameter("@CITTA", SqlDbType.NVarChar, 20);
            cmd.Parameters.Add(param);
            //if(cmd.Parameters.Count==0)
            //{
            //    //prima modalità di inserimento
                      //cmd.Parameters.AddWithValue("@MARCA", Marca);
                     //cmd.Parameters.AddWithValue("@CITTA", Citta);
            //    //seconda modalità
                    //cmd.Parameters.Add("@MARCA", SqlDbType.NVarChar,20);
                   //cmd.Parameters.Add("@CITTA", SqlDbType.Text);
            //}
            //cmd.Parameters["@MARCA"].Value = Marca;
            //cmd.Parameters["@CITTA"].Value = Citta;
            cmd.Parameters[0].Value = Marca;
            cmd.Parameters[1].Value = Citta;
            try
            {
                Message = "Inserimento corretto";
                return cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Message = ex.Message;
                return -1;
            }
        }  

        private void btnInserimento_Click(object sender, EventArgs e)
        {
            string Message;
            if (Ins(txbMarca.Text, txbCitta.Text, out Message) != -1)
                MessageBox.Show(Message, "Inserimento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                MessageBox.Show(Message, "Inserimento", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
