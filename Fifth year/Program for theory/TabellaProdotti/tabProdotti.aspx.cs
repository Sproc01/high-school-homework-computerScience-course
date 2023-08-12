using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class tabProdotti : System.Web.UI.Page
{
    protected void Button1_Command(object sender, CommandEventArgs e)
    {
        string codice = (string)e.CommandArgument;
        int quant;
        if (qta.Text != "")
            try
            {
                quant = Convert.ToInt32(qta.Text);
                HttpCookie ck = new HttpCookie(codice, quant.ToString());
                Response.Cookies.Add(ck);
            }
            catch { }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        Magazzino m = new Magazzino();
        foreach (Prodotto p in m.mag)
        {
            TableRow riga = new TableRow();

            TableCell cellaNome = new TableCell();
            cellaNome.Width = Unit.Pixel(200);
            cellaNome.Text = p.Nome;
            riga.Cells.Add(cellaNome);

            TableCell cellaDescr = new TableCell();
            cellaDescr.Width = Unit.Pixel(300);
            riga.Cells.Add(cellaDescr);
            cellaDescr.Text = p.Descrizione;

            TableCell cellaPrezzo = new TableCell();
            cellaPrezzo.Text = p.Prezzo.ToString();
            riga.Cells.Add(cellaPrezzo);

            TableCell cellaBtn = new TableCell();
            Button btn = new Button();
            btn.Text = "Ordina";
            btn.Command += Button1_Command;
            btn.CommandArgument = p.Nome;
            cellaBtn.Controls.Add(btn);
            riga.Cells.Add(cellaBtn);

            tabella.Rows.Add(riga);
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        List<Ordinato> lista = new List<Ordinato>();
        int num = Request.Cookies.Count;
        for(int x =0; x < num; x++)
        {
            try
            {
                lista.Add(new Ordinato() { Codice = Request.Cookies[x].Name, Quantià = Convert.ToInt32(Request.Cookies[x].Value) });
                HttpCookie ck = new HttpCookie(Request.Cookies[x].Name);
                ck.Expires = DateTime.Now.AddDays(-1.0);
                Response.Cookies.Add(ck);
            }
            catch { }
        }
        Session["listaProdotti"] = lista;
        Server.Transfer("fattura.aspx");
    }
}
