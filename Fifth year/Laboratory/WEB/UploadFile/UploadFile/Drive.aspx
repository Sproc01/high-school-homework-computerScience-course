<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Drive.aspx.cs" Inherits="UploadFile.Drive" %>
<%@ import Namespace="System.Data.OleDb" %>
<%@ Import Namespace="System.Data" %>
<%@ Import Namespace="System.IO" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Drive</title>
    <script src="https://code.jquery.com/jquery-3.4.1.slim.min.js" integrity="sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js" integrity="sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6" crossorigin="anonymous"></script>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous"/>
    <script runat="server">
        //variabili globali per poter acceddere da ogni metodo
        string utente;
        string password;
        int AccFA;
        int AccCO;
        DataTable dt= new DataTable();
        /// <summary>
        /// Verifica le credenziali dell'utente nel database
        /// </summary>
        void Accesso()
        {
            utente = Request.Form["Utente"];
            password = Request.Form["Password"];
            if (utente != null)
            {
                AccFA = Convert.ToInt32(Request.Form["AccessiFalliti"]);
                AccCO = Convert.ToInt32(Request.Form["AccessiCorretti"]);
                OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + HttpRuntime.AppDomainAppPath + "\\Utenti.accdb");
                con.Open();
                OleDbCommand cmd = new OleDbCommand($"SELECT * FROM UTENTE WHERE UTENTE='{utente}' AND PASSWORD='{password}'", con);

                dt.Load(cmd.ExecuteReader());
                if (dt.Rows.Count == 1)
                {
                    Response.Write("Accesso corretto; benvenuto "+utente+"<br/>");
                    AccCO++;
                }
                else
                {
                    Response.Write("Accesso fallito, Nome utente o password non corretti <br/>");
                    AccFA++;
                }

            }
        }
        /// <summary>
        /// Visualizza i file collegati al determinato utente utente
        /// </summary>
        void visualizza()
        {
            if(dt.Rows.Count == 1)
            {
                Response.Write("I tuoi file: <br/>");
                string path = HttpRuntime.AppDomainAppPath + "Drive\\" + utente + "\\";
                string [] vett= Directory.GetFiles(path);
                if (vett.Length > 0)
                    for (int i = 0; i < vett.Length; i++)
                    {
                        path = Path.GetFileName(vett[i]);
                        Response.Write($"{i + 1}.<a target=\"blank\" href=\"{"Drive/"+utente+"/"+path}\"> {path} </a><br/>");
                    }
                else
                    Response.Write("Non ci sono file salvati");
            }

        }
        /// <summary>
        /// scrive la password con gli asterischi una volta effettuato l'accesso
        /// </summary>
        void passw()
        {
            if(dt.Rows.Count == 1)
            {
                string pwd = "";
                for (int i = 0; i < password.Length; i++)
                {
                    pwd += "*";
                }
                Response.Write(pwd);
            }

        }
    </script>
</head>
<body>
    <div class="container">
      <div class="row">
        <div class="col-sm">
          <form action="Drive.aspx" method="post">
            <h4>Credenziali di accesso:</h4>
            <% Accesso(); %>
            Nome utente:
            <input type="text" name="Utente" value="<%Response.Write(utente); %>" />
            <br />
            <br />
            Password:
            <input type="text" name="Password" value="<%passw(); %>"/>
            <br />

            <hr />
            <input type="submit" value="Accedi" />
            <br />
            <input type="hidden" name="AccessiFalliti" value="<%Response.Write(AccFA); %>" />
            <input type="hidden" name="AccessiCorretti" value="<%Response.Write(AccCO); %>" />
        </form>
        </div>
        <div class="col-sm">
            <% visualizza(); %>
        </div>
      </div>
    </div>
</body>
</html>
