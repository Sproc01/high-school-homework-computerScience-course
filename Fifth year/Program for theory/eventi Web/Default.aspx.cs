using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
        {if (target.Value=="span1")
            body.Attributes["bgcolor"] =argomento.Value ;
        if  (target.Value == "span2")
            body.Attributes["bgcolor"] = argomento.Value;
        }
    
    }
}