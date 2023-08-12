using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fdprRead
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int tasto;
            char chtasto;
            do
            {
                Console.WriteLine("Inserisci sequenza caratteri");
                tasto = Console.Read();
                while (tasto != 13)
                {
                    Console.WriteLine("valore tasto={0}, carattere corrispondente{1}", tasto, Convert.ToChar(tasto));
                    tasto = Console.Read();
                }
                Console.Read();
                Console.WriteLine("Vuoi inserire una nuova sequenza?");
                chtasto = Convert.ToChar(Console.Read());
                Console.ReadLine();
            }while((chtasto=='s')| (chtasto == 'S'));*/

            int tasto;
            char chtasto;
            string risposta;
            do
            {
                Console.WriteLine("Inserisci sequenza caratteri");
                do
                {
                    tasto = Console.Read();
                    if(tasto!=13)
                    Console.WriteLine("valore tasto={0}, carattere corrispondente{1}", tasto, Convert.ToChar(tasto));
                } while ((tasto != 13));

                //Console.Read();
                Console.WriteLine("Vuoi inserire una nuova sequenza?");
                risposta = Console.ReadLine();
            }while((risposta=="s")| (risposta == "S"));
        }
    }
}
