using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PrepVerifica
{
    public partial class Insert : Form
    {
        OleDbConnection con;
        public Insert(OleDbConnection c, bool IsInsert)
        {
            InitializeComponent();
            con = c;
            if (IsInsert)
            {
                btnInsert.Visible = true;
                this.Text = "Insert";
                btnModify.Visible = false;
            }
            else
            {
                btnInsert.Visible = false;
                this.Text = "Modify";
                btnModify.Visible = true;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string course = txtCourse.Text;
            string query = "";
            if(name!="" && surname!="" && course!="")
            {
                query = string.Format("INSERT INTO STUDENTI (NOME, COURSE) VALUES('{0}','{1}')",name+" "+surname, course);
                OleDbCommand cmd = new OleDbCommand(query, con);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Correct insert", "Insert");
                    Close();
                }
                catch (OleDbException i)
                {
                    MessageBox.Show("Insert error \n"+i, "Insert");
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string course = txtCourse.Text;
            string query = "";
            if (name != "" && surname != "" && course != "")
            {
                query = string.Format($"UPDATE STUDENTI SET COURSE='{course}' WHERE NOME='{name + " " + surname}'");
                OleDbCommand cmd = new OleDbCommand(query, con);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Correct modify", "Modify");
                    Close();
                }
                catch (OleDbException i)
                {
                    MessageBox.Show("Modify error \n" + i, "Modify");
                }
            }
        }

    }
}
