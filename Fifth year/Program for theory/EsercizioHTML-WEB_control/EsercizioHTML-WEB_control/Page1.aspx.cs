using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EsercizioHTML_WEB_control
{
    public partial class Page1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (name.Value != "" && evento.Value != "")
            {
                if (evento.Value == "click")
                    change();
                if (evento.Value == "wheel")
                    changelabel();
            }

        }

        protected void change()
        {
            body.Attributes["bgcolor"] = "red";
        }
        protected void changelabel()
        {
            body.Attributes["bgcolor"] = "green";
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            lb2.InnerText = "Benvenuto " + txtnome.Text + " " + txtcognome.Text;
        }
    }
}