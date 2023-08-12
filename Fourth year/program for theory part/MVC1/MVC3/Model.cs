using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC2
{
    class Model
    {
        double add1;
        double add2;
        double somma;

        public delegate void updatedHandler();
        public event updatedHandler updated;

        //public delegate int pippo(double x);

        public double Add1
        {
            set { add1 = value; }
            get { return add1; }
        }

        public double Add2
        {
            set { add2 = value; }
            get { return add2; }
        }

        public double Somma
        {
            get { return somma; }
        }


        public void CalcolaSomma()
        {
            somma = add1 + add2;
            if (updated != null)
                updated();
        }

    }
}
