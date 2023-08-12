using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MVC1
{
    public partial class Vista2 : Form
    {
        Model modello;
        internal Vista2(Model m)
        {
            InitializeComponent();
            modello = m;

            modello.updated += new Model.updatedHandler(aggiorna);
        }

        void aggiorna()
        {
            risultato.Width = (int)modello.Somma * 20;
        }
    }
}
