using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fdprVettori
{
    class Program
    {
        static void Main(string[] args)
        {
            int somma = 0;
            int d = 0;
            bool errore;
            Console.WriteLine("Inserisci il numero dei numeri da sommare");
            do
            {
                try
                {
                    d = Convert.ToInt32(Console.ReadLine());
                    errore = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    errore = true;
                }
            } while (errore);
            int[] valori = new int[d];
            Console.WriteLine("Inserire i numeri da sommare");
            for (int i=0; i<d; i++)
            {
                do
                { 
                    try
                    {
                        valori[i] = Convert.ToInt32(Console.ReadLine());
                        errore = false;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        errore = true;
                    }
                } while (errore);
            }
            foreach (int Val in valori)
            {
                somma += Val;
            }
            Console.WriteLine("La somma è: " + somma);
            Console.ReadLine();
        }
    }
}
