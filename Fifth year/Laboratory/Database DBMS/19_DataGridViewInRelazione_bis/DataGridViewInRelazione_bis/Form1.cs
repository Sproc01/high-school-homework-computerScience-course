using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DataGridViewInRelazione_bis
{
    public partial class Form1 : Form
    {
        //crea gli oggetti BindingSource
        private BindingSource MarcheBinding = new BindingSource();
        private BindingSource ModelliBinding = new BindingSource();
        //crea gli oggetti adapter
        private SqlDataAdapter MarcheDataAdapter;
        private SqlDataAdapter ModelliDataAdapter;
        //crea il dataset
        private DataSet dsAuto;
        //crea una variabile ausiliaria
        private int riga;
        private String ConnString;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //imposta la stringa di connessione
            //String ConnString = "Data Source=.\\SQLEXPRESS;Persist Security Info=False;Trusted_Connection=Yes;DATABASE=auto";
            ConnString = "Data Source=.\\;Persist Security Info=False;Trusted_Connection=Yes;DATABASE=auto";

            //associa l'oggetto BindingSource al DataGridView dgvMarche
            dgvMarche.DataSource = MarcheBinding;// tabella<---Bindingsouce<----Origine dati
            //associa l'oggetto BindingSource al DataGridView dgvModelli
            dgvModelli.DataSource = ModelliBinding;
            //invoca il metodo che procede alla
            //connessione e popolamento del dataset
            Carica();
            //registra il delegato per l'evento che si verifica quando una riga 
            //riceve il focus e diventa la riga corrente
            dgvMarche.RowEnter += new DataGridViewCellEventHandler(OnRowEnter);


        }
        private void Carica()
        {

            //crea l'oggetto connection
            SqlConnection conn = new SqlConnection(ConnString);
            //crea il dataset
            dsAuto = new DataSet();
            //lo svuota
            dsAuto.Clear();
            //---------------------- TABELLA MARCHE ----------------------
            MarcheDataAdapter = new SqlDataAdapter("SELECT * FROM MARCHE", conn);
            MarcheDataAdapter.Fill(dsAuto, "Marche");
            ModelliDataAdapter = new SqlDataAdapter("SELECT * FROM MODELLI", conn);
            ModelliDataAdapter.Fill(dsAuto, "Modelli");
            //richiama il metodo per la creazione 
            //esplicita dei comandi
            ExplicitCommand(conn);
            //crea un oggetto DataRelation
            DataRelation relazione = new DataRelation("ModelliMarche", dsAuto.Tables["Marche"].Columns["codice"], dsAuto.Tables["Modelli"].Columns["Codice_marca"]);
            //aggiungi l'oggetto al dataset
            dsAuto.Relations.Add(relazione);
            //imposta la sorgente di dati
            MarcheBinding.DataSource = dsAuto;//elenco di tabelle
            //imposta il membro (tabella) per la sorgente di dati
            MarcheBinding.DataMember = "Marche";// permette di associare un elemento del DataSet(una tabella/relazione)
            //imposta la prima colonna (codice) della tabella 
            //come colonna di sola lettura e quindi
            //non modificabile
            dgvMarche.Columns[0].ReadOnly = true;
            //imposta la sorgente di dati
            ModelliBinding.DataSource = MarcheBinding;
            //imposta il membro per la sorgente di dati
            //cioè la relazione
            ModelliBinding.DataMember = "ModelliMarche";
            //imposta la prima colonna (CodiceMarca) 
            //come colonna di sola lettura e quindi
            //non modificabile
            dgvModelli.Columns[5].ReadOnly = true;
        }

        private void btnAgg_Click(object sender, EventArgs e)
        {

            //crea il commandBuilder
            SqlCommandBuilder commBuild = new SqlCommandBuilder(MarcheDataAdapter);

            //esegue l'eventuale aggiornamento della
            //tabella Marche
            MarcheDataAdapter.Update(dsAuto, "Marche");

            //esegue l'eventuale aggiornamento della
            //tabella Modelli
            ModelliDataAdapter.Update(dsAuto, "Modelli");

            //ricarica il database
            Carica();

            //libera le risorse
            commBuild.Dispose();
        }

        private void OnRowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //preleva l'indice di riga selezionata
            riga = e.RowIndex;
        }
        private void ExplicitCommand(SqlConnection conn)
        {
            //------------------ SELECT COMMAND -----------------------------
            SqlCommand commSelectModelli = new SqlCommand("SELECT * FROM MODELLI", conn);
            //registra il comando
            ModelliDataAdapter.SelectCommand = commSelectModelli;
            //------------------ INSERT COMMAND -----------------------------
            SqlCommand commInsertModelli = new SqlCommand("INSERT INTO MODELLI(Modello,Prezzo,Cilindrata,Consumourbano,Consumoextraurb,Codice_marca,Tipo)VALUES(@paramModello,@paramPrezzo,@paramCilindrata,@paramConsumoUrb,@paramConsExtra,@paramCodiceMarca,@paramTipo)", conn);

            //registrazione dei parametri per l' INSERT COMMAND tramite
            //l'ivocazione del metodo ParamAdd(...)
            //Questi parametri sono utilizzati per la selezione dei dati 
            //dall'origine dati e per la loro immissione nell'oggetto DataSet.
            ParamAdd(commInsertModelli, "@paramModello", SqlDbType.NVarChar, 20, "Modello");
            ParamAdd(commInsertModelli, "@paramPrezzo", SqlDbType.Money, 12, "Prezzo");
            ParamAdd(commInsertModelli, "@paramCilindrata", SqlDbType.Int, 4, "Cilindrata");
            ParamAdd(commInsertModelli, "@paramConsumoUrb", SqlDbType.Decimal, 4, "Consumourbano");
            ParamAdd(commInsertModelli, "@paramConsExtra", SqlDbType.Decimal, 4, "Consumoextraurb");
            ParamAdd(commInsertModelli, "@paramCodiceMarca", SqlDbType.Int, 4, "Codice_marca");
            ParamAdd(commInsertModelli, "@paramTipo", SqlDbType.NVarChar, 10, "Tipo");
            //registra il comando
            ModelliDataAdapter.InsertCommand = commInsertModelli;
            //------------------ UPDATE COMMAND ------------------------------
            SqlCommand commUpDateModelli = new SqlCommand("UPDATE MODELLI SET Modello=@paramModello, Prezzo=@paramPrezzo, Cilindrata=@paramCilindrata, "+
                "Consumourbano=@paramConsumoUrb,Consumoextraurb=@paramConsExtra,Tipo=@paramTipo WHERE Modello=@oldModello", conn);       
          
            //registrazione dei parametri per il comando UPDATE
            ParamAdd(commUpDateModelli, "@paramModello", SqlDbType.NVarChar, 20, "Modello");
            ParamAdd(commUpDateModelli, "@paramPrezzo", SqlDbType.Money, 12, "Prezzo");
            ParamAdd(commUpDateModelli, "@paramCilindrata", SqlDbType.Int, 4, "Cilindrata");
            ParamAdd(commUpDateModelli, "@paramConsumoUrb", SqlDbType.Decimal, 4, "Consumourbano");
            ParamAdd(commUpDateModelli, "@paramConsExtra", SqlDbType.Decimal, 4, "Consumoextraurb");
            ParamAdd(commUpDateModelli, "@paramTipo", SqlDbType.NVarChar, 10, "Tipo");
            //registra il parametro
            SqlParameter para2 = commUpDateModelli.Parameters.Add("@oldModello",SqlDbType.NVarChar, 20, "Modello");
            //registra il valore originale nel parametro
            para2.SourceVersion = DataRowVersion.Original;
            //registra il comando
            ModelliDataAdapter.UpdateCommand = commUpDateModelli;
            //------------------ DELETE COMMAND -----------------------------------
            SqlCommand commDeleteModelli = new SqlCommand("DELETE FROM MODELLI WHERE Modello=@paramModello", conn);
            //registrazione del parametro per il comando DELETE
            
            para2 = commDeleteModelli.Parameters.Add("@paramModello", SqlDbType.NVarChar, 20, "Modello");
            //registra il comando
            ModelliDataAdapter.DeleteCommand = commDeleteModelli;
        }
        private void ParamAdd(SqlCommand commSQL, String pParam, SqlDbType TipoDato, int tipoSize, String campo)
        {
            commSQL.Parameters.Add(pParam, TipoDato, tipoSize, campo);
        }
        private void dgvMarche_DataBindingComplete
                      (object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //visualizza il numero di marche di autovetture presenti
            txtMarche.Text = "Marche auto presenti " + (dgvMarche.RowCount - 1);
        }

        private void dgvMarche_DataBindingComplete_1(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //visualizza il numero di marche di autovetture presenti
            txtMarche.Text = "Marche auto presenti: " + (dgvMarche.RowCount - 1);
        }

        private void dgvModelli_Paint(object sender, PaintEventArgs e)
        {
            //conta i modelli presenti
            int numModelli = dgvModelli.RowCount - 1;
            //ripulisci la textBox
            txtModelli.Clear();
            //controlla la quantità di modelli presenti
            //e effettua la visualizzazione del messaggio adeguato
            if (numModelli == 0) //se non ci sono modelli presenti
            {
                if (dgvMarche[1, riga].Value.ToString() != "")
                {
                    txtModelli.Text = "Per la " + dgvMarche[1, riga].Value.ToString() + " non sono presenti";
                }
                else
                {
                    txtModelli.Text = "Non sono presenti";
                }
            }
            else //se ci sono modelli
            {
                txtModelli.Text = "Per la " + dgvMarche[1, riga].Value.ToString() + " sono presenti " + numModelli;
            }
            //concatena la stringa al messaggio
            txtModelli.Text += " modelli ";
        }

        private void dgvModelli_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}