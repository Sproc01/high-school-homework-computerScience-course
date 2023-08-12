<%--Direttiva Page--%>
<%@ Page Language="C#" %>

<%--Direttiva Assembly--%>
<%@ Assembly Name= "System.Data" %>

<%--Direttiva Import = using--%>
<%@ Import Namespace = "System.Data.SqlClient" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Text1.Value == "pippo")
                Reset1.Disabled = false;
            else
                Reset1.Disabled = true;

            SqlConnection conn = new SqlConnection();
        }

        //genero pagina, quando clicco viene eseguito un submit quando torna indietro vedo se il pulsante
        //è stato cliccato e associa metodo corretto
        protected void metodo1(object sender, EventArgs e)
        {
            etichetta.InnerText = "Button 1 pressed.";
        }

        protected void metodo2(object sender, EventArgs e)
        {
            etichetta.InnerText = "Button 2 pressed.";
        }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
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
        
        <br /><span id="etichetta" runat="server"></span> </div>
    </form>
</body>
</html>
