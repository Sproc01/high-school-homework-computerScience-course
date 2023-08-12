using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.IO;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Text1.Value == "pippo")
            Reset1.Disabled = false;
        else
            Reset1.Disabled = true;

        //SqlConnection conn = new SqlConnection();
        HttpFileCollection collezione = Request.Files;
        try
        {
            //dentro corpo del messaggio arriva anche il file
            File1.PostedFile.SaveAs(@"E:\BARIN GIULIA 5E\ControlliHTML_WEB\" + Path.GetFileName(File1.PostedFile.FileName));
        }
        catch
        { }

        Stream inputStream = Request.InputStream;
        StreamReader strRead = new StreamReader(inputStream);
        string s = strRead.ReadToEnd();
        TextArea1.Value = s;

        //per trovare una cartella
        foto.Src = "Tulips.jpg";
    }

    //genero pagina, quando clicco viene eseguito un submit quando torna indietro vedo se il pulsante
    //è stato cliccato e associa metodo corretto
    protected void metodo1(object sender, EventArgs e)
    {
        etichetta.InnerText = "Bottone 1 cliccato.";
    }

    protected void metodo2(object sender, EventArgs e)
    {
        etichetta.InnerText = "Bottone 2 cliccato.";
    }
}
