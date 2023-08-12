using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fdpres13metodi
{
    class Program
    {
        static string controllo(double altezza, double peso)
        {
            string risultato;
            if (altezza - 100 < peso)
                risultato = "sovrappeso";
            else
            {
                if (altezza - 100 > peso)
                    risultato = "sottopeso";
                else
                    risultato = "normale";
            }
            return risultato;
        }
        static void Main(string[] args)
        {
            double altezza;
            double peso;
            string risultato;
            Console.WriteLine("Inserire altezza in cm.");
            altezza = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Inserire il peso in kg:");
            peso = Convert.ToDouble(Console.ReadLine());
            risultato=controllo(altezza, peso);
            Console.WriteLine($"sei {risultato}");
            Console.ReadLine();
        }
    }
}
