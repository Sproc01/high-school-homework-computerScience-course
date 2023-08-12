<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<%--<link href="StyleSheet.css" type="text/css" />--%>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <input id="Text1" type="text" value="pippo" runat="server"/>
        <br />
        <br />
        <input id="Button1" type="button" value="button" onclick="alert('ciao');"/> <!-- No submit, automatizzare qualcosa, inserire codice javascript-->
        <br />
        <br />
        <input id="Reset1" type="reset" value="reset" runat="server"/>
        <br />
        <br />
        <input id="Submit1" type="submit" value="submit 1" runat="server" onserverclick="metodo1" />&nbsp;
       
        <input id="Submit2" type="submit" value="submit 2" runat="server" onserverclick="metodo2" />
        <br />
        
        <br /><span id="etichetta" runat="server"></span> 
        <br />
        <br />
        <input id="File1" type="file" runat="server"/><br />
        <input id="File2" type="file" /><br />
        <br />
        <textarea id="TextArea1" cols="20" name="S1" rows="2" runat="server"></textarea><br />
        <br />
        <img id ="foto" alt=""  runat="server"/></div>
    </form>
</body>
</html>
