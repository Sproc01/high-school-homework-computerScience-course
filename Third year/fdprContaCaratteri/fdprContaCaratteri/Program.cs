using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fdprContaCaratteri
{
    class Program
    {
        static void Main(string[] args)
        {
            char carattere;
            string caratterenum = "";
            string caratterelett = "";
            string caratteresimb = "";
            string risposta;
            do
            {
                Console.Clear();
                Console.WriteLine("Inserisci una sequenza di caratteri:");
                do
                {
                    carattere = Convert.ToChar(Console.Read());
                    /*if (47 < carattere & carattere < 58)
                        caratterenum = caratterenum + carattere + ' ';
                    else
                    {
                        if (carattere > 64 & carattere < 91 | carattere < 123 & carattere > 96)
                            caratterelett = caratterelett + carattere + ' ';
                        else
                        {
                            if (carattere != 13)
                                caratteresimb = caratteresimb + carattere + ' ';
                        }
                    }*/
                    if(char.IsNumber(carattere))//controlla se è numero
                        caratterenum = caratterenum + carattere;
                    else
                        if(char.IsLetter(carattere))//controlla se è lettera
                        caratterelett = caratterelett + carattere;
                    else
                        caratteresimb = caratteresimb + carattere;
                } while (carattere != 13);
                Console.ReadLine();
                Console.WriteLine("Sono numeri:" + caratterenum);
                Console.WriteLine("Sono lettere:" + caratterelett);
                Console.WriteLine("Sono simboli:" + caratteresimb);
                Console.WriteLine("\nVuoi ripetere il programma?S/N");
                risposta = Console.ReadLine().ToUpper();
            } while (risposta == "S");
        }
    }
}
