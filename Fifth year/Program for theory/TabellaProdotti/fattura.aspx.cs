using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class fattura : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            List<Ordinato> lista =(List<Ordinato>) Session["listaProdotti"];
            Label1.Text = "";
            foreach(Ordinato ord in lista)
            {
                Label1.Text += ord.Codice + " "+ ord.Quantià + "<br/>";

            }
            Session["listaProdotti"] = null;
        }
    }
}