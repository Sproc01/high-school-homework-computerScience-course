<%@ Page Language="C#" AutoEventWireup="true" CodeFile="nuova1.aspx.cs" Inherits="NuovaPagina_nuova1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <asp:Label ID="Label1" runat="server" Text="Dato da pasare alla nuova pagina"></asp:Label>
   
        &nbsp;&nbsp;
   
        <asp:TextBox ID="dato" runat="server"></asp:TextBox>
    
    &nbsp;&nbsp;&nbsp;&nbsp;
         <br />
         <br />
         <asp:Button ID="Redirect" runat="server" OnClick="Redirect_Click" Text="Redirect" Width="83px" />
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:Button ID="transfer" runat="server" OnClick="transfer_Click" Text="Transfer" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:Button ID="CrossPost" runat="server" OnClick="CrossPost_Click" PostBackUrl="nuova4.aspx" Text="Cross Page Posting" />
    
    </div>
    </form>
</body>
</html>
