using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class NuovaPagina_nuova1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Redirect_Click(object sender, EventArgs e)
    {
        Response.Redirect("nuova2.aspx?dato=" + dato.Text);
    }
    protected void transfer_Click(object sender, EventArgs e)
    {
        Server.Transfer("nuova3.aspx");
    }
    protected void CrossPost_Click(object sender, EventArgs e)
    {

    }
}