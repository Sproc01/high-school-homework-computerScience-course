using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.IO;
using System.Web.UI.HtmlControls;

public partial class _Default : System.Web.UI.Page
{
    // variabili di stato
    string immagine;

    protected void Page_Load(object sender, EventArgs e)
    {
        if(IsPostBack)
        {
            CaricaStato();
            if (target.Value != "")         // c'è un evento personalizzato da gestire
            {
                switch (target.Value)
                {
                    case "Immagine":
                        {
                            switch (evento.Value)
                            {
                                case "click":
                                    {
                                        MostraTabella();
                                        break;
                                    }
                                case "wheel":
                                    {
                                        Immagine_Wheel();
                                        break;
                                    }
                            }
                        }
                        break;

                    default:            // click su una immagine della tabella
                        {
                            switch (evento.Value)
                            {
                                case "click":
                                    {
                                        Immagine_Click(target.Value);
                                        break;
                                    }
                            }
                        }
                        break;
                }
            }
            else            // è stato premuto il pulsante submit
            {
                MostraImmagine(Text1.Value);
            }
        }
        else
        {
            MostraTabella();
        }

        // pulisco i campi nascosti
        target.Value = "";
        evento.Value = "";
    }

    protected void Immagine_Click(string target)
    {
        //mostra la foto cliccata ingrandita
        Label.Text = target.Remove(target.IndexOf('.'));
        Immagine.Visible = true;
        Immagine.Src = string.Format(@"..\foto\{0}", target);
        table.Visible = false;
        immagine = target;
    }

    protected void MostraTabella()
    {
        //mostra la tabella delle foto
        Immagine.Visible = false;
        table.Visible = true;

        //percorso assoluto dalla cartella virtuale
        string path = Server.MapPath("/foto");

        string[] files = Directory.GetFiles(path, "*.jpg");
        int numFotoPerRiga = 3;
        int numRighe = (int)(files.Length / (double)numFotoPerRiga + 0.5);
        int cnt = 0;
        for (int i = 0; i < numRighe; i++)
        {
            HtmlTableRow riga = new HtmlTableRow();
            riga.Align = "center";
            table.Rows.Add(riga);

            for (int j = 0; j < numFotoPerRiga && cnt < files.Length; j++, cnt++)
            {
                HtmlTableCell cella = new HtmlTableCell();
                riga.Cells.Add(cella);

                cella.InnerHtml = string.Format(@"<img src='..\foto\{0}' style='height: 231px; width: 308px' onClick=""doPostBack('{0}','click');""/>", Path.GetFileName(files[cnt]));
                cella.InnerHtml += string.Format("<br /> {0}", Path.GetFileNameWithoutExtension(files[cnt]));
            }
        }
    }

    protected void MostraImmagine(string nome)
    {
        //percorso assoluto dalla cartella virtuale
        string path = Server.MapPath("/foto");

        if (nome != "")
        {
            if (File.Exists(path + String.Format("/{0}.jpg", nome))) // se esiste l'immagine
            {
                // parte dal cartella del sito (default)
                Label.Text = "";
                Immagine.Src = String.Format(@"..\foto\{0}.jpg", nome);
                Immagine.Visible = true;
                table.Visible = false;
                immagine = nome + ".jpg";
            }
            else
                nome = "";
        }
        if (nome == "")
        {
            Label.Text = "Imagine non presente";
            MostraTabella();
            Immagine.Visible = false;
            table.Visible = true;
        }
    }

    protected void Immagine_Wheel()
    {
        string path = Server.MapPath("/foto");
        string[] files = Directory.GetFiles(path, "*.jpg");
        int ind = Array.IndexOf(files, path + "\\" + immagine);
        if (ind == files.Length - 1)
            ind = 0;
        else
            ind++;
        Immagine.Src = String.Format(@"..\foto\{0}", Path.GetFileName(files[ind]));
        immagine = Path.GetFileName(files[ind]);
    }

    protected void CaricaStato()
    {
        immagine = (string)ViewState["immagine"];
    }

    protected void SalvaStato()
    {
        ViewState["immagine"]= immagine;
    }

    protected void Page_PreRender(object sender, EventArgs e)
    {
        SalvaStato();
    }
}