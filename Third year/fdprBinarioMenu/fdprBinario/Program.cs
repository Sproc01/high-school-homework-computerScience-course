using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fdprBinario
{
    class Program
    {
        static int Menu(string [] opzioni)
        {
            int Risposta=1;
            do
            {
                Console.Clear();
                Console.WriteLine("Menu:");
                for(int i=0; i<opzioni.Length; i++)
                {
                    Console.WriteLine(i + 1 + ": "+opzioni[i]);
                }
                try
                {
                    Risposta = Convert.ToInt16(Console.ReadLine());
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message+ "\n Premere invio per continuare il programma");
                    Console.ReadLine();
                }
            } while (Risposta > 4| Risposta < 1);

            return Risposta;
        }
        static void Main(string[] args)
        {
            string[] opzioni = { "Inserisci valore", "Conversione in binario", "Conversione in esadecimale", "Esci dal programma" };
            int risposta;
            Console.Clear();
            risposta=Menu(opzioni);
        }
    }
}
