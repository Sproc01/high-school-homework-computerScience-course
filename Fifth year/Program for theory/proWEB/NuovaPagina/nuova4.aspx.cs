using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class NuovaPagina_pagina4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        bool isCrossPage =(PreviousPage != null && PreviousPage.IsCrossPagePostBack);
        if (isCrossPage)
        {
            dato.Text = ((TextBox)PreviousPage.FindControl("dato")).Text;
        }
    }
}