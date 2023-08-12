using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace NegoziOrdini
{
    /// <summary>
    /// Michele Sprocatti 5E
    /// Programma pienamente funzionante
    /// </summary>
    public partial class Form1 : Form
    {
        OleDbConnection con;
        OleDbDataAdapter daN;
        OleDbDataAdapter daO;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
            dtNegozi.MultiSelect = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+Environment.CurrentDirectory+"\\Mobili.accdb");
            con.Open();//connessione
            ds = new DataSet();
            UpdateView();
        }
        /// <summary>
        /// aggiorno le datagrid
        /// </summary>
        private void UpdateView()
        {
            ds = new DataSet();
            daN = new OleDbDataAdapter("SELECT * FROM NEGOZI", con);
            daN.Fill(ds, "Negozi");        
            dtNegozi.DataSource = ds.Tables["Negozi"];
            labeldtnegozi.Text = "Cella in sola lettura";
            daO = new OleDbDataAdapter("SELECT * FROM ORDINI", con);
            daO.Fill(ds, "Ordini");
            labeldtordini.Text = "Cella in sola lettura";
            dtOrdini.DataSource = ds.Tables["Ordini"];
        }

        private void btnAggiorna_Click(object sender, EventArgs e)
        {
            OleDbCommandBuilder cmdNeg = new OleDbCommandBuilder(daN);
            OleDbCommandBuilder cmdOrd = new OleDbCommandBuilder(daO);
            try
            {
                daN.Update(ds,"Negozi");
            }
            catch (Exception i)
            {
                MessageBox.Show(i.Message);
            }
            try
            {
                daO.Update(ds, "Ordini");
            }
            catch (Exception i)
            {
                MessageBox.Show(i.Message);
            }
            UpdateView();
        }
        private void dtNegozi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //imposto la cella in sola lettura o meno
            if(dtNegozi.CurrentCellAddress.Y< ds.Tables["Negozi"].Rows.Count && dtNegozi.CurrentCellAddress.X<4)
                //<4 perchè la quarta colonna è sempre modificabile
                //mentre la prima condizione serve a capire se è una riga già presente o una che sta inserendo l'utente
            {
                dtNegozi.Columns[dtNegozi.CurrentCellAddress.X].ReadOnly = true;
                labeldtnegozi.Text = "Cella in sola lettura";
            }
            else
            {
                dtNegozi.Columns[dtNegozi.CurrentCellAddress.X].ReadOnly = false;
                labeldtnegozi.Text = "Cella modificabile";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

        private void dtNegozi_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {//cancellazione a cascata manuale
            if (DialogResult.OK == MessageBox.Show("Cancellare i record presenti nella tabella ordini correlati, in caso ce ne siano, al record selezionato o annullare operazione? Premendo 'ok' si effetuerà l'aggiornamento del database", "Attenzione", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk))
            {
                int indice = dtNegozi.CurrentCellAddress.Y;
                string cod = ds.Tables["Negozi"].Rows[indice][0].ToString();
                OleDbCommand cmd = new OleDbCommand("DELETE FROM ORDINI WHERE NEG_COD = '" + cod + "'", con);
                cmd.ExecuteNonQuery();//cancello righe nella tabella ordini che sono correlate alla tabella negozi
            }
            else
                e.Cancel = true;
        }

        private void dtOrdini_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //imposto la cella in sola lettura o meno
            if (dtOrdini.CurrentCellAddress.Y < ds.Tables["Ordini"].Rows.Count && dtOrdini.CurrentCellAddress.X < 2)
            //<2 perchè la quarta colonna è sempre modificabile
            //mentre la prima condizione serve a capire se è una riga già presente o una che sta inserendo l'utente
            {
                dtOrdini.Columns[dtOrdini.CurrentCellAddress.X].ReadOnly = true;
                labeldtordini.Text = "Cella in sola lettura";
            }
            else
            {
                dtOrdini.Columns[dtOrdini.CurrentCellAddress.X].ReadOnly = false;
                labeldtordini.Text = "Cella modificabile";
            }
        }

        private void dtNegozi_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            btnAggiorna.PerformClick();//richiamo aggiorna per evitare il problema di avere ancora nel database un negozio ma senza i suoi ordini
        }
    }  
}

