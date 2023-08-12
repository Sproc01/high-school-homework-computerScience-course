using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangoloclass
{
    public class Triangolo
    {
        double lato1;
        double lato2;
        double lato3;
        public Triangolo(double l)
        {
            lato1 = l;
            lato2 = l;
            lato3 = l;
        }
        public Triangolo(double l1, double l2)
        {
            lato1 = l1;
            lato2 = l1;
            lato3 = l2;
        }
        public Triangolo(double l1,double l2, double l3)
        {
                lato1 = l1;
                lato2 = l2;
                lato3 = l3;   
        }
        public double GetArea()
        {
            double p = Getperimetro()/2;
            return Math.Sqrt(p * (p - lato1) * (p - lato2) * (p - lato3));
        }
        public double Getperimetro()
        {
            return lato1 + lato2 + lato3;
        }
    }
}
