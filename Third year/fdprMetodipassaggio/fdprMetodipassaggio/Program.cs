using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fdprMetodipassaggio
{
    class Program
    {
        //metodo lettura valori
        static void lettura(ref double b, ref double B, ref double h)
        {
            bool errore;
            //controllo errori input
            do
            {
                Console.WriteLine("Inserire prima base");
                try
                {
                    b = Convert.ToDouble(Console.ReadLine());
                    errore = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    errore = true;
                }
            } while (errore);
            //controllo errori input
            do
            {
                Console.WriteLine("Inserire seconda base");
                try
                {
                    B = Convert.ToDouble(Console.ReadLine());
                    errore = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    errore = true;
                }
            } while (errore);
            //controllo errori input
            do
            {
                Console.WriteLine("Inserire altezza");
                try
                {
                    h = Convert.ToDouble(Console.ReadLine());
                    errore = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    errore = true;
                }
            } while (errore);
        }
        //metodo calcolo dell'area
        static void CalcoloArea(out double Area, double b, double B, double h)
        {
            Area = (b + B) * h / 2;
        }
        static void Main(string[] args)
        {
            double b=0, B=0, h=0;
            double Area=0;
            lettura(ref b, ref B, ref h);
            CalcoloArea(out Area, b, B, h);
            Console.WriteLine("area del trapezio è:" + Area);
            Console.ReadLine();
        }
    }
}
