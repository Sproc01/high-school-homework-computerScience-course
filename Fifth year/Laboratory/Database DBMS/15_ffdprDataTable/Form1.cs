using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ffdprDataTable
{
    public partial class FormGestioneDataTable : Form
    {
        DataTable dtAnagrafica;

        public FormGestioneDataTable()
        {
            InitializeComponent();
        }

        private void FormGestioneDataTable_Load(object sender, EventArgs e)
        {
            dtAnagrafica = new DataTable();
            DataColumn col = new DataColumn();

            col.ColumnName = "Codice";
            //col.DataType = typeof(string);
            col.DataType = typeof(Int32);
            dtAnagrafica.Columns.Add(col);
            col.AutoIncrement = true;

            col = new DataColumn();
            col.ColumnName = "Cliente";
            col.DataType = typeof(string);
            dtAnagrafica.Columns.Add(col);

            col = new DataColumn();
            col.ColumnName = "Città";
            col.DataType = typeof(string);
            dtAnagrafica.Columns.Add(col);

            //Inserimento vincolo di chiave primaria, specifico le colonne che devono essere chiave primaria
             DataColumn[] colonne = new DataColumn[1];
            
            colonne[0] = dtAnagrafica.Columns["Codice"]; //faccio riferimento alla tabella
            
            dtAnagrafica.PrimaryKey = colonne; //assegno la chiave primaria che è composta da una matrice di oggetti Datacolum;

            
            //Inserimento vincolo di unicità singolo da utilizzare per inserire un solo vincolo
            //dtAnagrafica.Columns["Cliente"].Unique = true;

            //Inserimento vincolo di unicità doppio
            DataColumn[] colonneU = new DataColumn[2];
            colonneU[0] = dtAnagrafica.Columns["Cliente"]; //faccio riferimento alla tabella
            colonneU[1] = dtAnagrafica.Columns["Città"];
            UniqueConstraint uc = new UniqueConstraint(colonneU);  //simile CONSTRAINT sql, crea vincoli sulla tabella
            //assegno vincolo alla tabella
            dtAnagrafica.Constraints.Add(uc);
        }

        private void btnInserisci_Click(object sender, EventArgs e)
        {
            DataRow riga = dtAnagrafica.NewRow();// definisco una riga con gli stessi attributi

            //valorizzo campi
            //riga["Codice"] = textBox1.Text;
            riga["Cliente"] = textBox2.Text;
            riga["Città"] = textBox3.Text;

            //errore se inserisco due oggetti con la stessa chiave primaria
            try
            {
                dtAnagrafica.Rows.Add(riga);
            }
            catch (DataException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            dgwDati.DataSource = null;
            dgwDati.DataSource = dtAnagrafica;
            
        }

        private void btnStato_Click(object sender, EventArgs e)
        {
            listBoxStato.Items.Clear();
            foreach (DataRow riga in dtAnagrafica.Rows)
                listBoxStato.Items.Add(riga.RowState.ToString());
        }

        private void btnConferma_Click(object sender, EventArgs e)
        {
            dtAnagrafica.AcceptChanges();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            dtAnagrafica.RejectChanges();
        }

        private void btnCancella_Click(object sender, EventArgs e)
        {
            int indice = dgwDati.CurrentCellAddress.Y;
            dtAnagrafica.Rows[indice].Delete();
        }
    }
}
