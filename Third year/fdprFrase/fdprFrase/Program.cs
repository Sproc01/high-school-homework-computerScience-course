using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fdprFrase
{
    class Program
    {
        static void Main(string[] args)
        {
            string parola = "";
            int valore;
            string risposta;
            do
            {
                Console.Clear();
                Console.WriteLine("Inserisci una frase:");
                do
                {
                    valore = Console.Read();
                    if ((valore == 32)|(valore==13))
                    {
                        Console.Write("Una delle parole inserite è:");
                        Console.WriteLine(parola);
                        parola = "";
                    }
                    else
                        parola += Convert.ToChar(valore);
                } while (valore != 13);
                Console.ReadLine();
                Console.ReadLine();
                Console.WriteLine("Vuoi ripetere il programma?S/N");
                risposta = Console.ReadLine().ToUpper();
            } while (risposta == "S");

        }
    }
}
