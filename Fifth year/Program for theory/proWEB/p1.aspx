<%@ Page Language="C#" AutoEventWireup="true" CodeFile="p1.aspx.cs" Inherits="p1" EnableViewState="False" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Pagina senza titolo</title>
    <style type="text/css">
        #form1
        {
            height: 164px;
        }
    </style>
    <script type="text/javascript">
    // <![CDATA[
    function f1()
    {
        alert("Hai cliccato su di un HyperLink");
        document.getElementById("Label1").innerText="";
        document.getElementById("Label2").innerText="";
        document.getElementById("Label3").innerText="";
    }
    // ]]>
    </script>
</head>
<body>

    <form id="form1" runat="server" style="padding: 20px; background-color: #00FFFF">
    <div style="padding: 10px; margin: 5px; border-width: 2px; border-style: solid; height: 259px; 
         background-color: #FFFF00; width: 328px;float: left">
    
        Esempio di Web Control :<br />
        Button<br />
        LinkButton<br />
        ImageButton<br />
        HyperLink<br />
        cliccando su uno di essi vengono visualizzate delle informazioni nel riquadro 
        grigio.<br />
        <br />
    
    </div>
    
    <br />

    <asp:ImageButton ID="ImageButton1" runat="server" Height="64px" CommandArgument="Argomento immagine" 
        CommandName="Pulsante con immagine"
        ImageUrl="Image/winxp.gif" Width="166px" oncommand="Button_Command" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" CommandArgument="Argomento normale" 
        CommandName="Pulsante normale" oncommand="Button_Command" Text="Pulsante normale" 
        EnableViewState="False" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
    <asp:LinkButton ID="LinkButton1" runat="server" oncommand="Button_Command"
    CommandArgument="Argomento link" CommandName="Pulsante link">LinkButton</asp:LinkButton>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
    <br />
    <br />
    <br />
    <asp:HyperLink ID="HyperLink1" runat="server" BorderColor="#FF3300" 
        BorderStyle="Solid" Height="17px" ImageUrl="Image/help.gif" 
        NavigateUrl="javascript: void(f1())" style="margin-left: 34px" Width="27px">HyperLink di prova
    </asp:HyperLink>
    
    <div style="padding: 10px; margin: 5px; border-width: 2px; border-style: solid; height: 259px;
         background-color: #C0C0C0; width: 328px; float: left;">
    
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
        <asp:Label ID="Label2" runat="server"></asp:Label>
        <br />
        <asp:Label ID="Label3" runat="server"></asp:Label>
        <br />
    
    </div>
    &nbsp;&nbsp;<br />
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="Default.htm">Home</asp:HyperLink>
    </p>
    </form>
    
    </body>
</html>
