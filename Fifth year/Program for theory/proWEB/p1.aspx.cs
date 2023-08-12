using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

public partial class p1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button_Click(object sender, EventArgs e)
    {
        Label1.Text = sender.ToString();
        Label1.Text += sender == Button1 ? Button1.Text : "";
    }
    protected void Button_Command(object sender, CommandEventArgs e)
    {
        Label2.Text = "Hai scelto: " + e.CommandName ;
        Label3.Text = " Argomento: " + e.CommandArgument;

    }

}
