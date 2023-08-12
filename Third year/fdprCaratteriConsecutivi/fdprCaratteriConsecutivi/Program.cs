using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fdprCaratteriConsecutivi
{
    class Program
    {
        static void Main(string[] args)
        {
            int carattere;
            string sequenza="";
            int carattereprec=0;
            string risposta;
            do
            {
                Console.WriteLine("Inserisci una sequenza di caratteri consecutivi");
                do
                {
                    carattere = Console.Read();
                    if (carattere != carattereprec)
                    {
                        carattereprec = carattere;
                        sequenza += Convert.ToChar(carattere);
                    }
                } while (carattere != 13);
                Console.Write("Hai inserito questi caratteri: ");
                Console.Write(sequenza);
                Console.ReadLine();
                Console.ReadLine();
                Console.WriteLine("Vuoi ripetere il programma?S/N");
                risposta = Console.ReadLine().ToUpper();
            } while (risposta == "S");
        }
    }
}
