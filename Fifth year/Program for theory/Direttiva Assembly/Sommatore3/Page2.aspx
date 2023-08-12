<%@ Page Language="C#" %>
<%@ Import Namespace="SoomatoreLib" %>

<!DOCTYPE html>

<script runat="server">
    void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = Sommatore.Somma(3, 45).ToString();
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
