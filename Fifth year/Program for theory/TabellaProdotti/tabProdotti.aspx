<%@ Page Language="C#" AutoEventWireup="true" CodeFile="tabProdotti.aspx.cs" Inherits="tabProdotti" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Table ID="tabella" runat="server" EnableViewState="False" Height="77px" Width="313px">
        </asp:Table>
        <br />
        <br />
    
    </div>
        <asp:Label ID="Label1" runat="server" Text="Quantità"></asp:Label>
&nbsp;
        <asp:TextBox ID="qta" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Conferma" />
    </form>
</body>
</html>
