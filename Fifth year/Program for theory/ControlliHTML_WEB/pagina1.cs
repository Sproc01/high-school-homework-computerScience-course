using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Text1.Value == "pippo")
            Reset1.Disabled = false;
        else
            Reset1.Disabled = true;
    }

    //genero pagina, quando clicco viene eseguito un submit quando torna indietro vedo se il pulsante
    //è stato cliccato e associa metodo corretto
    protected void metodo1(object sender, EventArgs e)
    {
        etichetta.InnerText = "Button 1 pressed.";
    }

    protected void metodo2(object sender, EventArgs e)
    {
        etichetta.InnerText = "Button 2 pressed.";
    }
}