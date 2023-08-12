using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC1
{
    class Controller
    {
        Model modello;
        View formView;
        

        public Controller(out Model modello, View formView)
        {
            this.modello = new Model();
            modello = this.modello;
            this.formView = formView;
            Vista2 f2 = new Vista2(modello);
            f2.Show();
        }

        public void uguale_Click(object sender, EventArgs e)
        {
            modello.Add1 = Convert.ToDouble(formView.add1.Text);
            modello.Add2 = Convert.ToDouble(formView.add2.Text);
            modello.CalcolaSomma();
        }
    }
}
