using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC2
{
    class Controller
    {
        Model modello;
        View view;

        public Controller(Model modello, View view)
        {
            this.modello = modello;
            this.view = view;
        }

        public void uguale_Click(double add1, double add2)
        {
            modello.Add1 = Convert.ToDouble(add1);
            modello.Add2 = Convert.ToDouble(add2);
            modello.CalcolaSomma();
        }
    }
}
