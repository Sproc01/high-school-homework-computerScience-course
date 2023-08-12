using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RubricaModale
{
    public partial class FormModale : Form
    {
        public Persona p1=new Persona();
        public FormModale()//costruttore di default
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            MinimizeBox = false;//non si può rimpincciolire la finestra
            MaximizeBox = false;//non si può ingrandire la finestra
            FormBorderStyle = FormBorderStyle.FixedDialog;//non fa ridimensionare il form
            AcceptButton = btnOk;
            CancelButton = btnCancel;
        }
        public FormModale(bool ricerca)//costruttore utilizzato per la ricerca
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            MinimizeBox = false;//non si può rimpincciolire la finestra
            MaximizeBox = false;//non si può ingrandire la finestra
            FormBorderStyle = FormBorderStyle.FixedDialog;//non fa ridimensionare il form
            AcceptButton = btnOk;
            CancelButton = btnCancel;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            pictureBox1.Visible = false;
            btnsfoglia.Visible = false;
        }
        public FormModale(Persona p, bool visualizza)//costruttore utilizzato per tasti visualizza e modifica
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            MinimizeBox = false;//non si può rimpincciolire la finestra
            MaximizeBox = false;//non si può ingrandire la finestra
            FormBorderStyle = FormBorderStyle.FixedDialog;//non fa ridimensionare il form
            AcceptButton = btnOk;
            CancelButton = btnCancel;
            txtcognome.Text = p.cognome;
            txtnome.Text = p.nome;
            pictureBox1.BackgroundImage = p.img.Image;
            switch (p.Sesso)
            {//distinzione sesso
                case Sesso.Maschio:
                    rdbtnMaschio.Checked = true;
                    break;
                case Sesso.Femmina:
                    rdfemmina.Checked = true;
                    break;
            }
            switch (p.stato)
            {//distinzione sesso
                case Statocivile.Celibe:
                    case Statocivile.Nubile:
                    rdcelibenubile.Checked = true;
                    break;
                case Statocivile.Coniugato:
                    case Statocivile.Coniugata:
                    rdconiugatoa.Checked = true;
                    break;
                case Statocivile.Divorziata:
                    case Statocivile.Divorziato:
                    rddivorziatoa.Checked = true;
                    break;
            }
            txtcognome.ReadOnly = true;
            txtnome.ReadOnly = true;
            rdbtnMaschio.Enabled = false;
            rdfemmina.Enabled = false;
            if (visualizza)//distinzione se bisogna modificare o visualizzare l'elemento
            {
                rddivorziatoa.Enabled = false;
                rdconiugatoa.Enabled = false;
                rdcelibenubile.Enabled = false;
                btnsfoglia.Visible = false;
            }
        }
        private void btnsfoglia_Click(object sender, EventArgs e)//bottone sfoglia: open file dialog
        {
            openFileDialog1.Filter = "Immagine(*.jpg)|*.jpg|Tutti i File(*.*)|*.*";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory + "\\Immagini\\";//percorso di default
            DialogResult cmd = openFileDialog1.ShowDialog();
            if (cmd != DialogResult.OK)
            {
                MessageBox.Show("Non hai selezionato nessun file");
            }
            else
            {
                MessageBox.Show("File selezionato:" + openFileDialog1.FileName);
                pictureBox1.BackgroundImage = Image.FromFile(openFileDialog1.FileName);//assegnazione a picture box dell'immagine selezionata
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            p1.img = new PictureBox();//inizializzazione campo img della struttura p1
            if (txtcognome.Text!=""&&txtnome.Text!="")//controllo dati input
            {
                p1.nome = txtnome.Text;
                p1.cognome = txtcognome.Text;
                //controllo radiobutton selezionati
                if(rdbtnMaschio.Checked)
                    p1.Sesso = Sesso.Maschio;
                if(rdfemmina.Checked)
                    p1.Sesso = Sesso.Femmina;
                if(rdcelibenubile.Checked)
                    switch (p1.Sesso)
                    {//distinzione sesso
                        case Sesso.Maschio:
                            p1.stato = Statocivile.Celibe;
                            break;
                        case Sesso.Femmina:
                            p1.stato = Statocivile.Nubile;
                            break;
                    }
                if(rdconiugatoa.Checked)
                    switch (p1.Sesso)
                    {//distinzione sesso
                        case Sesso.Maschio:
                            p1.stato = Statocivile.Coniugato;
                            break;
                        case Sesso.Femmina:
                            p1.stato = Statocivile.Coniugata;
                            break;
                    }
                if(rddivorziatoa.Checked)
                    switch (p1.Sesso)
                    {//distinzione sesso
                        case Sesso.Maschio:
                            p1.stato = Statocivile.Divorziato;
                            break;
                        case Sesso.Femmina:
                            p1.stato = Statocivile.Divorziata;
                            break;
                    }
                p1.img.Image = pictureBox1.BackgroundImage;
                DialogResult = DialogResult.OK;
            }
            else
            {
                //valori input errati
                if (txtcognome.Text == "" && txtnome.Text == "")
                    MessageBox.Show("Manca sia nome che cognome", "mancanza", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (txtcognome.Text == "")
                        MessageBox.Show("Manca il cognome", "mancanza", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        if ( txtnome.Text == "")
                        MessageBox.Show("Manca il nome", "mancanza", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
