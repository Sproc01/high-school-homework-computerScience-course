using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class NuovaPagina_nuova3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        dato.Text = Request.Form["dato"];
    }
}