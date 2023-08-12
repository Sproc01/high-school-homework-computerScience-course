using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fdprexaMetodi
{
    class Program
    {
        static void Divisioni(ref int resto, ref int dec)
        {
            resto = dec % 16;
        }
        static void Quoziente(ref int dec)
        {
            dec = dec / 16;
        }
        static void Controllo(ref int dec)
        {
            Console.WriteLine("valore errato, ripetere inserimento");
            dec = Convert.ToInt32(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            int dec;
            int resto = 0;
            int pos = 2;
            int cifre = 2;
            string output="";
            Console.WriteLine("Inserisci un numero decimale(tra 0 e 255):");
            dec = Convert.ToInt32(Console.ReadLine());
            while (dec < 0 | dec > 255)
            {
                Controllo(ref dec);
            }
            Console.Clear();
            Console.WriteLine("L'equivalente in esadecimale è:");
            do
            {
                Divisioni(ref resto, ref dec);
                switch(resto)
                {
                    case 10:
                        output = "A";
                        break;
                    case 11:
                        output = "B";
                        break;
                    case 12:
                        output = "C";
                        break;
                    case 13:
                        output = "D";
                        break;
                    case 14:
                        output = "E";
                        break;
                    case 15:
                        output = "F";
                        break;
                }
                Console.SetCursorPosition(pos - 1,1);
                Quoziente(ref dec);
                if (resto < 10)
                    Console.WriteLine(resto);
                else
                    Console.WriteLine(output);
                pos -= 1;
                cifre -= 1;
            } while (dec != 0);
            Console.SetCursorPosition(0, 1);
            switch(cifre)
            {
                case 1:
                    Console.WriteLine("0");
                    break;
                case 2:
                    Console.WriteLine("00");
                    break;
            }
            Console.ReadLine();
        }
    }
}
