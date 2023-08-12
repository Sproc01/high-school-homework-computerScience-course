<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
     <script type="text/javascript">

        

         function doPostback(target, argomento) {

             
             var theForm = document.forms["form1"];

             if (!theForm)
             { theForm=document.form1; }
            
           if(!theForm.onsubmit || (theForm.onsubmit()!=false))
            {
                 theForm.target.value = target;
                 theForm.argomento.value = argomento;
                 theForm.submit();
            }

             // modo alternativo di accedere agli elementi del form
             // è il modo standard

            /* var t = document.getElementById("target");
             t.value = target;

             var e = document.getElementById("argomento");
             e.value = argomento;

             var f = document.getElementById("form1");
             f.submit();*/
         }

         </script>
    <style type="text/css">
        .auto-style1 {
            color: #4cff00;
        }
        .auto-style2 {
            color: #0066FF;
        }
    </style>
</head>

<body runat="server"  id="body">

    <form id="form1" runat="server">
    <div>
        <input type="hidden" name="target" id="target" value="" runat="server"/>
        <input type="hidden" name="argomento" id="argomento" value=""  runat="server"/>

    <span id="span1" onclick="doPostback('span1','yellow')" class="auto-style1">giallo</span><br /><br /><br />
    <span id="span2" onclick="doPostback('span2','red')" class="auto-style2">rosso</span>
     
    </div>
    </form>
</body>
</html>
