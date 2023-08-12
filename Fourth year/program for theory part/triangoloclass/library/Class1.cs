using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    enum Tipo {scaleno, equilatero, isoscele}
    public class Triangolo
    {
        double lato1;
        double lato2;
        double lato3;
        Tipo t;
        public Triangolo(double l1, double l2, double l3)
        {
            if (l1 < l2 + l3 && l2 < l1 + l3 && l3 < l2 + l1)
            {
                lato1 = l1;
                lato2 = l2;
                lato3 = l3;
                controllotipo();
            }
            else
                throw new Exception("Impossibile costruire un triangolo");
        }
        public double getlato1()
        { return lato1; }
        public double getlato2()
        { return lato2; }
        public double getlato3()
        { return lato3; }
        public void Setlato1(double l)
        {
            if (l < lato2 + lato3 && lato2 < l + lato3 && lato3 < lato2 + l)
            {
                lato1 = l;
                controllotipo();
            }
            else
                throw new Exception("Impossibile costruire un triangolo");
        }
        public void Setlato2(double l)
        {
            if (lato1 < l + lato3 && l < lato1 + lato3 && lato3 < l + lato1)
            {
                lato2 = l;
                controllotipo();
            }
            else
                throw new Exception("Impossibile costruire un triangolo");
        }
        private void controllotipo()
        {
            if (lato1 == lato2 && lato2 == lato3)
                t = Tipo.equilatero;
            else
            {
                if (lato1 == lato3 || lato1 == lato2 || lato2 == lato3)
                    t = Tipo.isoscele;
                else
                    t = Tipo.scaleno;
            }
        }
        public void Setlato3(double l)
        {
            if (lato1 < lato2 + l && lato2 < lato1 + l && l < lato2 + lato1)
            {
                lato3 = l;
                controllotipo();
            }
            else
                throw new Exception("Impossibile costruire un triangolo");
        }
        public string visualizza()
        {
            string s="";
            switch (t)
            {
                case Tipo.scaleno:
                    s= "Il triangolo è scaleno\n";
                    break;
                case Tipo.equilatero:
                    s = "Il triangolo è equilatero\n";
                    break;
                case Tipo.isoscele:
                    s = "Il triangolo è isoscele\n";
                    break;
            }
            s += "Primo lato:" + lato1;
            s += "\nSecondo lato:" + lato2;
            s+="\nTerzo lato:" + lato3;
            return s;
        }
        public double Getperimetro()
        {
            return lato1 + lato2 + lato3;
        }
        public double Getarea()
        {
            double p = Getperimetro() / 2;
            return Math.Sqrt(p * (p - lato1) * (p - lato2) * (p - lato3));
        }
    }
}
