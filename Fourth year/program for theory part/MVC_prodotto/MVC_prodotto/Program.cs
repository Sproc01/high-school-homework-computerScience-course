using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_prodotto
{
    class Prodotto
    {
        //modello
        double p1;
        double p2;
        double ris;
        public double fatt1
        {
            get { return p1; }
            set { p1 = value; }
        }
        public double fatt2
        {
            get { return p2; }
            set { p2 = value; }
        }
        public void calcolo()
        {
            ris = p1 * p2;
            View.output(this);
        }
        public double risultato
        {
            get { return ris; }
        }
    }
    static class View
    {//vista
        public static void input()
        {
            double x, y;
            Console.WriteLine("Inserisci primo fattore");
            double.TryParse(Console.ReadLine(),out x);
            Console.WriteLine("Inserisci secondo fattore");
            double.TryParse(Console.ReadLine(), out y);
            Controller.Evento(x,y);
        }
        public static void output(Prodotto p)
        {
            Console.WriteLine($"Risultato:" + p.risultato);
            Console.ReadLine();
        }
    }
    static class Controller
    {//controller
        public static void Evento(double x, double y)
        {
            Prodotto p = new Prodotto();
            p.fatt1 = x;
            p.fatt2 = y;
            p.calcolo();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            View.input();
        }
    }
}
