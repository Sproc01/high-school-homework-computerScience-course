using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC1
{
    public partial class View : Form
    {
        Model modello;
        Controller controllore;

        public View()
        {
            //modello = new Model();
            controllore = new Controller(out modello, this);

            modello.updated += new Model.updatedHandler(aggiorna);

            InitializeComponent();

            this.uguale.Click += new System.EventHandler(controllore.uguale_Click);
        }

        void aggiorna()
        {
            result.Text = modello.Somma.ToString();
            risultato.Width = (int)modello.Somma * 10;
        }


     }
}
