using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DataGridViewInRelazione
{
    public partial class Form1 : Form
    {
        //crea gli oggetti BindingSource
        private BindingSource AgentiBinding = new BindingSource();
        private BindingSource VenditeBinding = new BindingSource();
        //crea gli oggetti adapter
        private OleDbDataAdapter AgentiDataAdapter;
        private OleDbDataAdapter VenditeDataAdapter;
        //crea il dataset
        private DataSet dsDbase;
        //definisci una variabile ausiliaria
        private int riga;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //associa gli oggetti di binding
            //ai rispettivi controlli DataGridView
            dgvNegozi.DataSource = AgentiBinding;
            dgvOrdini.DataSource = VenditeBinding;
            //invoca il metodo
            Carica();
            //regola la larghezza di tutte le colonne
            dgvNegozi.AutoResizeColumns();
            //imposta il valore per determinate la larghezza delle colonne
            dgvOrdini.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //disabilita il DataGridView dgvModelli
            dgvOrdini.Enabled = false;

        }
        private void Carica()
        {
            //imposta la stringa di connessione
            String ConnString ="Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\dbIV_sql_ddl.mdb";
            //crea l'oggetto Connection
            OleDbConnection conn = new OleDbConnection(ConnString);

            //crea il dataset
            dsDbase = new DataSet();
            
            //cancella tutti i dati presenti nel dataset
            dsDbase.Clear();

            //crea il DataAdapter per la tabella Marche
            AgentiDataAdapter = new OleDbDataAdapter("SELECT * FROM Agenti_1", conn);

            //riempi il dataset con i dati
            AgentiDataAdapter.Fill(dsDbase, "Agenti_1");

            //crea il DataAdapter per la tabella Modelli          
            VenditeDataAdapter = new OleDbDataAdapter("SELECT * FROM Vendite_1", conn);

            //riempi il dataset con i dati           
            VenditeDataAdapter.Fill(dsDbase, "Vendite_1");
           
            //  definizione di un vincolo di chiave esterna sulle tabelle con cancellazione e modifica a cascata
            ForeignKeyConstraint vincolo = new ForeignKeyConstraint
           ("AgentiVendite",
           dsDbase.Tables["Agenti_1"].Columns["Cod_Agente"],
           dsDbase.Tables["Vendite_1"].Columns["Cod_Agente"]);

            vincolo.DeleteRule = Rule.Cascade;
            vincolo.UpdateRule = Rule.Cascade;
                     
            //Recupero del vincolo se definito nella tabella
            //dsDbase.EnforceConstraints = true;// permette di applicare dei vincoli alle tabelle

            //crea un oggetto DataRelation
            DataRelation relazione = new DataRelation("VenditeAgenti", dsDbase.Tables["Agenti_1"].Columns["Cod_Agente"], dsDbase.Tables["Vendite_1"].Columns["Cod_Agente"]);
            
            //aggiungi l'oggetto DataRelation al dataset
            dsDbase.Relations.Add(relazione);

            relazione.ChildKeyConstraint.AcceptRejectRule = AcceptRejectRule.Cascade;

            //imposta l'origine dati
            AgentiBinding.DataSource = dsDbase;

            //associa la tabella specifica come sorgente di dati
            AgentiBinding.DataMember = "Agenti_1";

            //imposta l'origine dati
           VenditeBinding.DataSource = AgentiBinding;

            //associa la tabella specifica come sorgente di dati
           VenditeBinding.DataMember = "VenditeAgenti";
        }

        private void btnAgg_Click(object sender, EventArgs e)
        {

            //crea l'oggetto SqlCommandBuilder che consente
            //la generazione automatica di comandi SQL INSERT, DELETE, UPDATE
            //per la tabella Marche
            OleDbCommandBuilder commBuild = new OleDbCommandBuilder(AgentiDataAdapter);
            try
            { 
            //aggiorna la tabella del database
            AgentiDataAdapter.Update(dsDbase, "Agenti_1");

            //crea l'oggetto SqlCommandBuilder che consente
            //la generazione automatica di comandi SQL
            //per la tabella Modelli
            OleDbCommandBuilder commBuild2 = new OleDbCommandBuilder(VenditeDataAdapter);

            //aggiorna la tabella del database
            VenditeDataAdapter.Update(dsDbase, "Vendite_1");
            }
            catch(Exception ex)
            {
               MessageBox.Show(ex.ToString());
                
                
            }
            //ricarica le tabelle aggiornate
            Carica();
            //abilita il controllo per l'inserimento delle
            //informazioni
            dgvOrdini.Enabled = true;
        }
    }
}