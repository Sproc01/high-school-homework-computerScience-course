using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fdprCodiceAlfaNumerico
{
    class Program
    {
        static void Main(string[] args)
        {
            int carattere;
            int numeri;
            int lettere;
            int fuorange;
            string risposta;
            do
            {
                Console.WriteLine("Inserisci una sequenza di caratteri:");
                numeri = 0;
                fuorange = 0;
                lettere = 0;
                do
                {
                    carattere = Console.Read();
                    if (47 < carattere & carattere < 58)
                        numeri++;
                    else
                    {
                        if (carattere > 64 & carattere < 91 | carattere < 123 & carattere > 96)
                            lettere++;
                        else
                        {
                            if (carattere != 13)
                                fuorange++;
                        }
                    }
                } while (carattere != 13);
                Console.WriteLine("I numeri inseriti sono:" + numeri + " Le lettere scritte sono:" + lettere + " I caratteri che non sono lettere nè numeri sono:" + fuorange);
                Console.ReadLine();
                Console.WriteLine("Vuoi ripetere il programma?S/N");
                risposta = Console.ReadLine().ToUpper();
            } while (risposta == "S");
        }
    }
}
