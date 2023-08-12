using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DataGridViewInRelazione
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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //associa gli oggetti di binding
            //ai rispettivi controlli DataGridView
            dgvMarche.DataSource = MarcheBinding;
            dgvModelli.DataSource = ModelliBinding;
            //invoca il metodo
            Carica();
            //regola la larghezza di tutte le colonne
            dgvMarche.AutoResizeColumns();
            //imposta il valore per determinate la larghezza delle colonne
            dgvModelli.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //disabilita il DataGridView dgvModelli
            dgvModelli.Enabled = true;

        }
        private void Carica()
        {
            //imposta la stringa di connessione
            //String ConnString = "Data Source=.\\SQLEXPRESS;Persist Security Info=False;Trusted_Connection=Yes;DATABASE=auto";
            String ConnString = @"Data Source=.\;Persist Security Info=False;Trusted_Connection=Yes;DATABASE=auto";
            //crea l'oggetto Connection
            SqlConnection conn = new SqlConnection(ConnString);

            //crea il dataset
            dsAuto = new DataSet();

            //cancella tutti i dati presenti nel dataset
            dsAuto.Clear();

            //crea il DataAdapter per la tabella Marche
            MarcheDataAdapter = new SqlDataAdapter("SELECT * FROM MARCHE", conn);

            //riempi il dataset con i dati
            MarcheDataAdapter.Fill(dsAuto, "Marche");

            //crea il DataAdapter per la tabella Modelli          
            ModelliDataAdapter = new SqlDataAdapter("SELECT * FROM MODELLI", conn);

            //riempi il dataset con i dati           
            ModelliDataAdapter.Fill(dsAuto, "Modelli");

            //crea un oggetto DataRelation
            DataRelation relazione = new DataRelation("ModelliMarche", dsAuto.Tables["Marche"].Columns["codice"], dsAuto.Tables["Modelli"].Columns["Codice_marca"]);

            //aggiungi l'oggetto DataRelation al dataset
            dsAuto.Relations.Add(relazione);

            //imposta l'origine dati
            MarcheBinding.DataSource = dsAuto;

            //associa la tabella specifica come sorgente di dati
            MarcheBinding.DataMember = "Marche";

            //imposta l'origine dati
            ModelliBinding.DataSource = MarcheBinding;

            //associa la tabella specifica come sorgente di dati
            ModelliBinding.DataMember = "ModelliMarche";
        }

        private void btnAgg_Click(object sender, EventArgs e)
        {

            //crea l'oggetto SqlCommandBuilder che consente
            //la generazione automatica di comandi SQL INSERT, DELETE, UPDATE
            //per la tabella Marche
            SqlCommandBuilder commBuild = new SqlCommandBuilder(MarcheDataAdapter);

            //aggiorna la tabella del database
            MarcheDataAdapter.Update(dsAuto, "Marche");

            //crea l'oggetto SqlCommandBuilder che consente
            //la generazione automatica di comandi SQL
            //per la tabella Modelli
            SqlCommandBuilder commBuild2 = new SqlCommandBuilder(ModelliDataAdapter);

            //aggiorna la tabella del database
            ModelliDataAdapter.Update(dsAuto, "Modelli");

            //ricarica le tabelle aggiornate
            Carica();
            //abilita il controllo per l'inserimento delle
            //informazioni
            //dgvModelli.Enabled = true;
        }
        //viene generato quando si genera una violazione di un vincolo sulla sorgente dati sottostante
        private void dgvModelli_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //e.Cancel = true;
            //MessageBox.Show(e.Exception.Message);
        }
    }
}