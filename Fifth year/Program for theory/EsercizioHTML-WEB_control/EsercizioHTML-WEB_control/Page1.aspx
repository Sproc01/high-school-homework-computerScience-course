<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page1.aspx.cs" Inherits="EsercizioHTML_WEB_control.Page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Page 1</title>
    <script type="text/javascript">
        function postback(comp, event) {
            var form = document.forms["form1"];
            if (!form)
                form = document.form1;
            form.name.value = comp;
            form.evento.value = event;
        }
    </script>
</head>
<body id="body" runat="server">
    <form id="form1" runat="server">
        <div>
            <asp:TextBox runat="server" ID="txtnome"></asp:TextBox>
            <asp:TextBox runat="server" ID="txtcognome"></asp:TextBox>
            <asp:Button OnClick="Unnamed_Click" runat="server" Text="sumbit"/>
            <input type="hidden" id="name" runat="server"/>
            <input type="hidden" id="evento" runat="server" />
        </div>
    </form>
    <span id="lb1" runat="server" onclick="postback('label','click')" onmousewheel="postback('label','wheel')" >click</span>
    <br />
    <span runat="server" id="lb2" />
</body>
</html>
