using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fdprCerchio
{
    class Cerchio
    {
        static void Main(string[] args)
        {
            double raggio;
            double circonferenza, area;
            string risposta="S";
            while (risposta=="S")
            {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            //inserimento dati
            Console.SetCursorPosition(10,10);//stabilisce le coordinate int e top, dove va a scrivere il testo
            Console.Write("Inserire raggio:");
            raggio = Convert.ToDouble(Console.ReadLine());
            //calcolo area
            area = Math.PI * Math.Pow(raggio, 2);//Math.Pow è l'elevamento a potenza, Math.PI invece è il valore di pgreco
            //calcolo circoferenza
            circonferenza = 2 * Math.PI * raggio;
            //output risultati
            Console.SetCursorPosition(10, 11);
            Console.WriteLine("L'area del cerchio:" + area);
            Console.SetCursorPosition(10, 12);
            Console.WriteLine("la circonferenza:" + circonferenza);
                Console.WriteLine("Vuoi ripetere il programma? S/N");
            risposta=Console.ReadLine().ToUpper();
            }
        }
    }
}
