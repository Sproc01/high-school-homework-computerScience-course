using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using librarymodelgiococarte;

namespace giococarte
{
    public partial class Form1 : Form
    {
        Gioco g;
        public Form1()
        {
            InitializeComponent();
            g = new Gioco();
        }

        private void btnplay_Click(object sender, EventArgs e)
        {
            g.Comincia();
            g.confronto();
            piccomputer.BackgroundImage = Image.FromFile(g.CartaComputer.Percorsoimg);
            lbcomputer.Text = g.CartaComputer.ToString();
            lbgio.Text = g.CartaGiocatore.ToString();
            picgio.BackgroundImage = Image.FromFile(g.CartaGiocatore.Percorsoimg);
            lbris.Text = g.Risultato;
        }
    }
}
