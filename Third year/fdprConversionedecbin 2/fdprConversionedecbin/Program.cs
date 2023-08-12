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
            int resto;
            int pos;
            int counter;
            //insertimento dati
            Console.WriteLine("Inserisci numero decimale:");
            //assegno valori alle variabili
            numerodec = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("IL valore convertito è:");
            pos = 7;
            counter = 0;
            while(numerodec!=0)
            {
                    resto = numerodec % 2;
                numerodec = numerodec / 2;
                Console.SetCursorPosition(pos, Console.CursorTop);
                Console.Write(resto);
                pos = pos - 1;
                counter = counter +1;
            }
            Console.SetCursorPosition(0,Console.CursorTop);
            while(counter!=8)
            {
                Console.Write("0");
                counter = counter +1;
            }
            Console.SetCursorPosition(0, 0);
            Console.ReadLine();
        }
    }
}
