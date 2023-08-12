using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class listaFile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HyperLink lnk = new HyperLink();
        lnk.Text = "file .txt";
        lnk.NavigateUrl = "render.txt";
        Panel1.Controls.Add(lnk);

        LiteralControl lit = new LiteralControl("<br/><br/>");
        Panel1.Controls.Add(lit);
 		       
 	    lnk = new HyperLink();
        lnk.Text = "file .zip";
        lnk.NavigateUrl = "render.zip";
        Panel1.Controls.Add(lnk);

        lit = new LiteralControl("<br/><br/>");
        Panel1.Controls.Add(lit);

        lnk = new HyperLink();
        lnk.Text = "file .docx";
        lnk.NavigateUrl = "render.docx";
        Panel1.Controls.Add(lnk);

    }
}