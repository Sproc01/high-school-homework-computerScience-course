using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fdprCarattere
{
    class Program
    {
        static void Main(string[] args)
        {
            int carattere;
            string caratterenum="";
            string caratterelett = "";
            string caratteresimb = "";
            string risposta;
            do
            {
                Console.Clear();
                Console.WriteLine("Inserisci una sequenza di caratteri:");
                do
                {
                    carattere = Console.Read();
                    if (47 < carattere & carattere < 58)
                        caratterenum = caratterenum + Convert.ToChar(carattere)+' ';
                    else
                    {
                        if (carattere > 64 & carattere < 91 | carattere < 123 & carattere > 96)
                            caratterelett= caratterelett + Convert.ToChar(carattere)+' ';
                        else
                        {
                            if (carattere != 13)
                                caratteresimb = caratteresimb + Convert.ToChar(carattere)+' ';
                        }
                    }
                } while (carattere != 13);
                Console.ReadLine();
                Console.WriteLine("Sono numeri:'" + caratterenum + "'");
                Console.WriteLine("Sono lettere:'" + caratterelett + "'");
                Console.WriteLine("Sono simboli:'" + caratteresimb + "'");
                Console.WriteLine("\nVuoi ripetere il programma?S/N");
                risposta = Console.ReadLine().ToUpper();
            } while (risposta == "S");
        }
    }
}
