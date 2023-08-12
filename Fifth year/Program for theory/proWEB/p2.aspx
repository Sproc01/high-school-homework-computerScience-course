<%@ Page Language="C#" AutoEventWireup="True" %>
<%@ Import namespace= "System.Diagnostics" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
    "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" > 

<head id="Head1" runat="server">
    <title> ListControl SelectedValue Example </title>
<script runat="server">

    struct elemento
    {
        string _testo;
        string _valore;
        public string testo
        {
            get { return _testo; }
            set { _testo = value; }
        }
        public string valore
        {
            get { return _valore; }
            set { _valore = value; }
        }
        public elemento(string t, string v)
        {
            _testo = t;
            _valore = v;
        }
    }
    elemento[] sorgente = {new elemento( "uno","1"),
                           new elemento( "due","2"),
                           new elemento("tre" ,"3")};

    Hashtable ht = new Hashtable();
    
      void Button_Click(Object sender, EventArgs e)
      {

         // Perform this operation in a try-catch block in case the item is not found.
         try
         {
            List.SelectedValue = ItemTextBox.Text;
            MessageLabel.Text = "You selected " + List.SelectedValue + ".";
         }
         catch (Exception ex)
         {
            List.SelectedValue = null;
            MessageLabel.Text = "Item not found in ListBox control.";
         }
      }

      protected void Page_Load(object sender, EventArgs e)
      {
          if (!IsPostBack)
          {
              ht.Add("k1", "pippo");
              ht.Add("k2", "pluto");
              ht.Add("k3", "paperino");
              DDList1.DataSource = ht;
              DDList1.DataTextField = "key";
              DDList1.DataValueField = "value";
              DataBind();

              // esempio di scrittura sul log di sistema
              //EventLog ev = new EventLog("Application");
              //ev.Source = "pagina p2.aspx";
              //ev.WriteEntry("ciao mario", EventLogEntryType.Error);

              ListBox1.DataSource = sorgente;
              ListBox1.DataTextField = "testo";
              ListBox1.DataValueField = "valore";
              ListBox1.DataBind();
          }
          
      }

      protected void DDList1_SelectedIndexChanged(object sender, EventArgs e)
      {
          Label1.Text = "Hai selezionato la chiave: " + DDList1.SelectedItem.Text +
                        " associata al valore: " +DDList1.SelectedValue ;
      }
</script>

</head>

<body>

   <form id="form1" runat="server">

      <h3> Esempio della proprietà SelectedValue di una ListBox</h3>
      
      Ai valori visualizzati nella lista sono associate le proprietà Value seguenti:<br />
      elem1<br />
      elem2<br />
      elem3<br />
      elem4<br />
       <br /> 
      <asp:ListBox ID="List" runat="server">
         <asp:ListItem Value="elem1">Item 1</asp:ListItem>
         <asp:ListItem Value="elem2">Item 2</asp:ListItem>
         <asp:ListItem Value="elem3">Item 3</asp:ListItem>
         <asp:ListItem Value="elem4">Item 4</asp:ListItem>
      </asp:ListBox>

      <hr />

      Inserire il value dell'elemento da selezionare: <br />
      <asp:TextBox ID="ItemTextBox"
           MaxLength="6"
           Text="elem1"
           runat="server"/>

      &nbsp;&nbsp;

      <asp:Button ID="SelectButton"
           Text="Seleziona elemento"
           OnClick="Button_Click"
           runat="server"/>

      <br /><br />

      <asp:Label ID="MessageLabel"
           runat="server"/>     

      <br />
      <hr />
      <br />
      Esempio di DropDownList associata ad un a HasTable.<br />
      <br />
      <asp:DropDownList ID="DDList1"  runat="server" 
          onselectedindexchanged="DDList1_SelectedIndexChanged" AutoPostBack="True">
      </asp:DropDownList>
      
      <br />
      <asp:Label ID="Label1" runat="server"/>     
      <br />
      <br />
      <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
      <br />
      <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/proWEB/Default.htm">Home</asp:HyperLink>
   </form>

</body>
</html>


