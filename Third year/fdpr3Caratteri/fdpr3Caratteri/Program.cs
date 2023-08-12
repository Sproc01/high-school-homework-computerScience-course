using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fdpr3Caratteri
{
    class Program
    {
        static void Errore(ref int carattere, ref string sequenza)
        {
                Console.WriteLine("inserimento errato, ripetere input dati");
        }
        static void Corretto(ref int carattere, ref string sequenza)
        {
            Console.WriteLine("inserimento Corretto");
            sequenza += Convert.ToChar(carattere);
        }
        static void Reinserimento(ref int carattere, ref bool intervallo, ref string sequenza)
        {
                Console.ReadLine();
                Console.WriteLine("è stata inserita un carattere non numero, ripetere input errato in poi");
                carattere = Console.Read();
            if(!intervallo)
            {
                Corretto(ref carattere, ref sequenza);
            }
        }
        static void Main(string[] args)
        {
            int carattere=0;
            Console.WriteLine("Inserire 3 numeri");
            bool intervallo=false;
            string sequenza="";
            do
            {
                for (int contatore=0; contatore<3; contatore++)
                {
                    carattere = Console.Read();
                    intervallo = (carattere < 48 | carattere > 57) & carattere != 13;
                    if (intervallo)
                    {
                        intervallo = false;
                        Errore(ref carattere, ref sequenza);
                        do
                        {
                            Reinserimento(ref carattere, ref intervallo, ref sequenza);
                        } while (intervallo);
                    }
                    else
                        Corretto(ref carattere, ref sequenza);
                }
            } while (intervallo);
            Console.WriteLine("Sono stati scritti i seguenti numeri: " + sequenza);
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
