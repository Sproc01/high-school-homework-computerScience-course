using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ffdprspecifica_marche
{
    public partial class Form1 : Form
    {
        private SqlDataAdapter MarcheDataAdapter;
        //crea il dataset
        private DataSet dsAuto;
        //crea una variabile ausiliaria
        private int riga;
        public Form1()
        {
            InitializeComponent();
        }
        private void Carica()
        {
            //imposta la stringa di connessione
            String ConnString = @"Data Source=.\;Persist Security Info=False;Trusted_Connection=Yes;DATABASE=auto";

            //crea l'oggetto connection
            SqlConnection conn = new SqlConnection(ConnString);
            //crea il dataset
            dsAuto = new DataSet();
            //lo svuota
           // dsAuto.Clear();
            //---------------------- TABELLA MARCHE ----------------------
            MarcheDataAdapter = new SqlDataAdapter("SELECT * FROM MARCHE", conn);
            MarcheDataAdapter.Fill(dsAuto, "Marche");

            //esplicita dei comandi
            CommandEspliciti(conn);

            //imposta la sorgente di dati
            dataGridView1.DataSource = dsAuto;
            //imposta il membro (tabella) per la sorgente di dati
            dataGridView1.DataMember = "Marche";
            //imposta la prima colonna (codice) della tabella 
            //come colonna di sola lettura e quindi
            //non modificabile
            dataGridView1.Columns[0].ReadOnly = true;
            //imposta la sorgente di dati
            
        }
        private void CommandEspliciti(SqlConnection conn)
        {
            //------------------ SELECT COMMAND -----------------------------
            SqlCommand commSelectMarche = new SqlCommand("SELECT * FROM MARCHE", conn);
            //registra il comando
            MarcheDataAdapter.SelectCommand = commSelectMarche;
            //------------------ INSERT COMMAND -----------------------------
            SqlCommand commInsertModelli = new SqlCommand("Insert into Marche(Marca, Citta) values(@Marca, @Citta)", conn);

            //registrazione dei parametri per l' INSERT COMMAND tramite
            //l'invocazione del metodo ParamAdd(...)
            //Questi parametri sono utilizzati per la selezione dei dati 
            //dall'origine dati e per la loro immissione nell'oggetto DataSet.
            ParamAdd(commInsertModelli, "@Marca", SqlDbType.NVarChar, 20, "Marca");
            ParamAdd(commInsertModelli, "@Citta", SqlDbType.NVarChar, 20, "Citta");

            //registra il comando
            MarcheDataAdapter.InsertCommand = commInsertModelli;
           
            //------------------ UPDATE COMMAND ------------------------------
            SqlCommand commUpDateMarche = new SqlCommand("UPDATE Marche SET marca=@marca, Citta=@citta WHERE Codice=@oldCodice", conn);

            //registrazione dei parametri per il comando UPDATE
            ParamAdd(commUpDateMarche, "@Marca", SqlDbType.NVarChar, 20, "Marca");
            ParamAdd(commUpDateMarche, "@Citta", SqlDbType.NVarChar, 20, "Citta");
            ParamAdd(commUpDateMarche, "@oldcodice", SqlDbType.Int,5,"Codice");
            //registra il valore originale nel parametro
            commUpDateMarche.Parameters["@oldcodice"].SourceVersion = DataRowVersion.Original;
            //registra il comando
            MarcheDataAdapter.UpdateCommand = commUpDateMarche;
            //------------------ DELETE COMMAND -----------------------------------
           SqlCommand commDeleteModelli = new SqlCommand("DELETE FROM Marche WHERE Codice=@oldCodice", conn);
            //registrazione del parametro per il comando DELETE
            ParamAdd(commDeleteModelli, "@oldcodice", SqlDbType.Int, 5, "Codice");
            commDeleteModelli.Parameters["@oldcodice"].SourceVersion = DataRowVersion.Original;           
            //registra il comando
            MarcheDataAdapter.DeleteCommand = commDeleteModelli;
        }
        private void ParamAdd(SqlCommand commSQL, String pParam, SqlDbType TipoDato, int tipoSize, String campo)
        {
            commSQL.Parameters.Add(pParam, TipoDato, tipoSize, campo);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Carica();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAggiorna_Click(object sender, EventArgs e)
        {
            //esegue l'eventuale aggiornamento della
            //tabella Marche
            /*
             Quando si utilizza Update, l'ordine di esecuzione è il seguente:

            I valori di DataRow vengono spostati i valori dei parametri.

            Viene generato l'evento OnRowUpdating.

            Esegue il comando.

            Se il comando è impostato su FirstReturnedRecord, quindi il primo risultato restituito viene
            inserito nel DataRow.

            Se sono presenti parametri di output, vengono inseriti nel DataRow.

            Viene generato l'evento OnRowUpdated.

            Chiamata del metodo AcceptChanges.*/


            MarcheDataAdapter.Update(dsAuto, "Marche");
            Carica();
        }
    }
}
