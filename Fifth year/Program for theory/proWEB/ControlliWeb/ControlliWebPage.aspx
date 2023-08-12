<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ControlliWebPage.aspx.cs" Inherits="ControlliWebPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title title="Controlli WEB"></title>
    <style type="text/css">
         {
            color: #FFCC00;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>  
        Pagina di prova dei principali Controlli Web<br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Questa è una LABEL" ></asp:Label>
        &nbsp;
        <asp:TextBox ID="TextBox1" runat="server" >TextBox</asp:TextBox>
        <br />
        <br />
        </div>
        <asp:CheckBox ID="CheckBox1" runat="server" Text="Testo della checkBox1" />
        <br />
        <br />
        <asp:CheckBox ID="CheckBox2" runat="server" Text="Testo della checkBox2" />
        <br />
        <asp:CheckBoxList ID="CheckBoxList1" runat="server" >
            <asp:ListItem Value="valore1">testo1</asp:ListItem>
            <asp:ListItem Value="valore2">testo2</asp:ListItem>
        </asp:CheckBoxList>
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server">HyperLink</asp:HyperLink>
        <br />
        <br />
        <asp:ListBox ID="ListBox1" runat="server">
            <asp:ListItem>l1</asp:ListItem>
            <asp:ListItem>l2</asp:ListItem>
        </asp:ListBox>
        <br />
        <br />
        <asp:RadioButton ID="RadioButton1" runat="server" GroupName="g1" Text="radio1" />
        <br />
        <asp:RadioButton ID="RadioButton2" runat="server" GroupName="g1" Text="radio2" />
        <br />
    </form>
</body>
</html>
