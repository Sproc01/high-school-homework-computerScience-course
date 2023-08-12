using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fdprConversionedecbin
{
    class Program
    {
        static void Main(string[] args)
        {
            //dichiaro variabili
            int numerodec;
            double numerobin;
            int resto;
            int esponente;
            double somma;
            //insertimento dati
            Console.WriteLine("Inserisci numero decimale:");
            //assegno valori alle variabili
            numerodec = Convert.ToInt32(Console.ReadLine());
            esponente = 0;
            numerobin = 0;
            somma = 0;
            while(numerodec!=0)
            {
                    resto = numerodec % 2;
                numerodec = numerodec / 2;
                Console.WriteLine("numero="+resto);
                somma=resto*Math.Pow(10,esponente)+somma;
                esponente = esponente + 1;
                numerobin = somma;

            }
            //output
            Console.WriteLine("Il numero in binario è: "+numerobin);
                Console.ReadLine();
        }
    }
}
