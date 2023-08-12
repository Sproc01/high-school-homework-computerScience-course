using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fdprMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            //dichiaro le variabili
            double media;
            int valore=0;
            double sommavalori = 0;
            string risposta = "S"; 
            while (risposta == "S") 
            {
                Console.WriteLine("Inserisci valori:");
                sommavalori = sommavalori + Convert.ToDouble(Console.ReadLine());
                valore = valore + 1;
                Console.WriteLine("Inserire altrri numeri?S/N");
                risposta = Console.ReadLine().ToUpper();
            }
            Console.WriteLine("sono stati inseriti " + (valore) + " valori");
            //calcolo la media
            media = sommavalori / valore;
            Console.WriteLine("La media è:" + media);
            Console.ReadLine();
        }
    }
}
