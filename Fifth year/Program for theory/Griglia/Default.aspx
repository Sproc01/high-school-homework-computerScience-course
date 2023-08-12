<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Table ID="Table1" runat="server" CellPadding="10">
            <asp:TableRow runat="server">
                <asp:TableCell runat="server">
                    <asp:gridview runat="server" ID="griglia" CellPadding="4" ForeColor="#333333" OnSelectedIndexChanged="griglia_SelectedIndexChanged">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:ButtonField ButtonType="Button" CommandName="Select" Text="Sel" />
                        </Columns>
                        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                        <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                    </asp:gridview>
                </asp:TableCell>
                <asp:TableCell runat="server">
                     Codice: <asp:TextBox ID="cod" runat="server"></asp:TextBox><br /><br /><br />
                     Marca: <asp:TextBox ID="marca" runat="server"></asp:TextBox><br /><br /><br />
                     Città: <asp:TextBox ID="city" runat="server"></asp:TextBox><br />
                </asp:TableCell>
                <asp:TableCell runat="server">
                    <asp:button ID="Ins" runat="server" text="Inserisci" OnClick="Ins_Click" /><br /><br /><br />
                    <asp:button ID="Mod" runat="server" text="Modifica" OnClick="Mod_Click" /><br /><br /><br />
                    <asp:button ID="Del" runat="server" text="Elimina" OnClick="Del_Click" />
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
       <asp:Label ID="Carrello" runat="server" />
    </div>
 </form>
</body>
</html>

