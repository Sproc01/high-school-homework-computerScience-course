using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fdprfrequenza
{
    class Program
    {
        static void Main(string[] args)
        {
            string risposta;
            do
            {
                int numero = 0;
                int fre0 = 0;
                int resto = 1;
                int fre1 = 0;
                int fre2 = 0;
                int fre3 = 0;
                int fre4 = 0;
                int fre5 = 0;
                int fre6 = 0;
                int fre7 = 0;
                int fre8 = 0;
                int fre9 = 0;
                Console.Clear();
                Console.WriteLine("Inserisci un numero:");
                numero = Convert.ToInt32(Console.ReadLine());
                while (numero != 0)
                {
                    resto = numero % 10;
                    numero = numero / 10;
                    //controllo possibili valori resto
                    switch (resto)
                    {
                        case 0:
                            fre0++;
                            break;
                        case 1:
                            fre1++;
                            break;
                        case 2:
                            fre2++;
                            break;
                        case 3:
                            fre3++;
                            break;
                        case 4:
                            fre4++;
                            break;
                        case 5:
                            fre5++;
                            break;
                        case 6:
                            fre6++;
                            break;
                        case 7:
                            fre7++;
                            break;
                        case 8:
                            fre8++;
                            break;
                        case 9:
                            fre9++;
                            break;
                    }
                }
                //stampo frequenze
                if (fre0 != 0)
                    Console.WriteLine("Lo 0 è stato inserito: " + fre0);
                if (fre1 != 0)
                    Console.WriteLine("L'1 è stato inserito: " + fre1);
                if (fre2 != 0)
                    Console.WriteLine("Il 2 è stato inserito: " + fre2);
                if (fre3 != 0)
                    Console.WriteLine("Il 3 è stato inserito: " + fre3);
                if (fre4 != 0)
                    Console.WriteLine("Il 4 è stato inserito: " + fre4);
                if (fre5 != 0)
                    Console.WriteLine("Il 5 è stato inserito: " + fre5);
                if (fre6 != 0)
                    Console.WriteLine("Il 6 è stato inserito: " + fre6);
                if (fre7 != 0)
                    Console.WriteLine("Il 7 è stato inserito: " + fre7);
                if (fre8 != 0)
                    Console.WriteLine("L'8 è stato inserito: " + fre8);
                if (fre9 != 0)
                    Console.WriteLine("Il 9 è stato inserito: " + fre9);
                Console.WriteLine("Vuoi ripetere il propgramma?(S/N)");
                risposta = Console.ReadLine().ToUpper();
            } while (risposta == "S");
        }  
    }
}
