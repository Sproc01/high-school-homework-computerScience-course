<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Prova1._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script runat="server">
        void Scrivi()
        {
            string inp = Request.Form["nome"];
            if (inp != null)
                Response.Write("Ciao " + inp);
        }
    </script>
</head>
<body>
    <form method="post" action="default.aspx">
        <input name="nome" type="text" value="<%Response.Write(Request.Form["nome"]); %>"/>
        <input type="submit" value="Invia" />
        <div>
            <%Scrivi(); %>
        </div>
    </form>
</body>
</html>
