using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProvaClassi
{
    class Punto
    {
        private double x;
        private double y;
        private double r;
        private double alfa;

        public double Getx()
        {
            
            return x;
        }

        public double Gety()
        {
            return y;
        }

        public void Setx(double valore)
        {
            x = valore;
            CalcolaRAlfa();
        }

        public void Sety(double valore)
        {
            y = valore;
            CalcolaRAlfa();
        }
        private void CalcolaRAlfa()
        {
            r = Math.Sqrt(x * x + y * y);
            alfa = x >= 0 ? Math.Atan(y / x) : Math.Atan(y / x) + Math.PI;
        }
        public double Getr()
        {
            return r;
        }

        public double Getalfa()
        {
            return alfa;
        }

        public void Setr(double valore)
        {
            r = valore;
            CalcolaXY();
        }

        public void Setalfa(double valore)
        {
            alfa = valore;
            CalcolaXY();
        }
        private void CalcolaXY()
        {
            x = r * Math.Cos(alfa);
            y = r * Math.Sin(alfa);
        }

        public void Visualizza()
        {
            Console.Write("({0}, {1})", Getx(), Gety());
            Console.Write("  ({0}, {1})", Getr(), Getalfa());
        }


        //public double r;
        //public double alfa;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Punto p1 = new Punto();
            //p1.Setx(3);
            //p1.Sety(3);
            p1.Setr(4.2426406871192851464050661726291);
            p1.Setalfa(0.78539816339744830961566084581988);
            p1.Visualizza();
            Console.ReadLine();
        }
    }
}
