<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="RubricaAsp._default" %>
<%@ import Namespace="System.Data.OleDb" %>
<%@ Import Namespace="System.Data" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Rubrica</title>
    <script runat="server">
        string telefono;
        string nome;
        string img="";
        DataTable da;

        void Esegui()
        {
            string nome = Request.Form["nome"];
            if (nome != null)
            {
                OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+HttpRuntime.AppDomainAppPath+"\\Rubrica.accdb");
                con.Open();
                OleDbCommand cmd = new OleDbCommand($"SELECT * FROM PERSONA WHERE NOME='{nome}'", con);
                OleDbDataReader dr = cmd.ExecuteReader();
                da = new DataTable();
                da.Load(dr);
                if(da.Rows.Count!=0)
                {
                    telefono = da.Rows[0][1].ToString();
                    Response.Write("Il numero di telefono è: " + telefono);
                }
                else
                {
                    Response.Write("Elemento non presente");
                }
            }
        }
        void Images()
        {
            string path = "";
            if(da!=null)
            {
                img = da.Rows[0][2].ToString();
                path = HttpRuntime.AppDomainAppVirtualPath + "img/" + img;
            }
            Response.Write(path);
        }
    </script>
</head>
<body>
        <h2>Rubrica</h2>
        <form action="default.aspx" method="post">
        <input name="nome" type="text" value="<% Response.Write(Request.Form["nome"]); %>"/>
        <br/>
        <br />
        <input type="submit" value="Invia" />
        <div>
            <hr />
            <% Esegui(); %>
            <br />
            <br />
            <img src="<% Images(); %>" alt="<% Images(); %>" />
        </div>
    </form>
</body>
</html>
