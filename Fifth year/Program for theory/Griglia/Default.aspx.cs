using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                RefreshGriglia();
            }
        }

    protected void griglia_SelectedIndexChanged(object sender, EventArgs e)
    {
        int i = griglia.SelectedIndex;
        List<int> listaCodici = (List<int>)ViewState["listaCodici"];
        cod.Text = listaCodici[i].ToString();
        marca.Text = griglia.SelectedRow.Cells[1].Text;
        city.Text = griglia.SelectedRow.Cells[2].Text;
        // gestione cookies
        int contatore = 0;
        foreach (string s in Request.Cookies)
            if (s.Substring(0, 8) == "prodotto")
                contatore++;
        contatore++;
        HttpCookie ck = new HttpCookie("prodotto" + contatore.ToString());
        ck.Values.Add("codice", cod.Text);
        ck.Values.Add("codice", marca.Text);
        ck.Values.Add("codice", city.Text);
        Response.Cookies.Add(ck);
        // visualizzo il carrello
        Carrello.Text = "";
        //foreach (string s in Request.Cookies)
        //{
        //    string[] v=null;
        //    foreach (string str in Request.Cookies[s].Values)
        //         Carrello.Text += Request.Cookies[s].Values[str] + "<br/>";
        //    //    v = Request.Cookies[s].Values.GetValues(0);
        //    //foreach(string x in v)
        //    //    Carrello.Text += x + "<br/>";
        //}
        foreach (string s in Request.Cookies)
            Carrello.Text += Request.Cookies[s].Value + "<br/>";
    }

    protected void Ins_Click(object sender, EventArgs e)
        {
            if (marca.Text.Length != 0 && city.Text.Length != 0)
            {
                SqlConnection conn = new SqlConnection("Data Source=.\\;Initial Catalog=Auto;Integrated Security=True");
                string sqlIns = "INSERT INTO MARCHE (Marca,Citta)VALUES('" + marca.Text + "','" + city.Text +
                "')";
                SqlCommand cmd = new SqlCommand(sqlIns, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                RefreshGriglia();
            }
        }

        protected void Mod_Click(object sender, EventArgs e)
        {
            if (cod.Text.Length != 0 && marca.Text.Length != 0 && city.Text.Length != 0)
            {
                SqlConnection conn = new SqlConnection("Data Source=.\\;Initial Catalog=Auto;Integrated Security=True");
                string sqlIns = "UPDATE MARCHE SET Marca='" + marca.Text + "',Citta='" + city.Text +
                "' WHERE Codice =" + cod.Text;
                SqlCommand cmd = new SqlCommand(sqlIns, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                RefreshGriglia();
            }
        }

        protected void Del_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.\\;Initial Catalog=Auto;Integrated Security=True");
            string sqlIns = "DELETE FROM  MARCHE WHERE Codice =" + cod.Text;
            SqlCommand cmd = new SqlCommand(sqlIns, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            RefreshGriglia();
        }

        public void RefreshGriglia()
        {
            SqlConnection conn = new SqlConnection("Data Source=.\\;Initial Catalog=Auto;Integrated Security=True");
            string query = "SELECT MARCA,CITTA FROM MARCHE";
            string query2 = "SELECT CODICE FROM MARCHE";
            List<int> listaCodici = new List<int>();
            SqlCommand command = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader dr = command.ExecuteReader();
            griglia.DataSource = dr;
            griglia.DataBind();
            command.CommandText = query2;
            dr.Close();
            dr = command.ExecuteReader();
            while (dr.Read())
            {
                listaCodici.Add(dr.GetInt32(0));
            }
            dr.Close();
            conn.Close();
            ViewState["listaCodici"] = listaCodici;
        }
    }
