<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Submit1
        {
            height: 28px;
            width: 98px;
        }
        #Text1
        {
            height: 26px;
            width: 153px;
        }
    </style>

    <script type="text/javascript">
        function doPostBack(target, evento) 
        {
            var t = document.getElementById("target");
            t.value = target;
            var e = document.getElementById("evento");
            e.value = evento;
            var f = document.getElementById("form1");
            f.submit();
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Visualizza foto:</h1>Inserisci il nome della foto:<br />
        <input id="Text1" type="text" runat="server"/> 
        <asp:Label ID="Label" runat="server" Text=""></asp:Label><br />
        <input id="Submit1" type="submit" value="Mostra foto" runat="server" /><br />

        <input id="target" type="hidden" runat="server"/><br />
        <input id="evento" type="hidden" runat="server" /><br />
        <br />
        <table style="width:100%;" runat="server" id="table">
        </table>
    </div>
    </form>
        <p>
          <img id="Immagine" alt="foto" style="height: 527px; width: 707px" runat="server" onclick="doPostBack('Immagine', 'click');" 
                  onwheel="doPostBack('Immagine', 'wheel');"/>
        </p>
</body>
</html>
