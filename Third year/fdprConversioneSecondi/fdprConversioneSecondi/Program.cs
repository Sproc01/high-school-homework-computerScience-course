using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fdprConversioneSecondi
{
    class Program
    {
        static void Main(string[] args)
        {
            //dichiaro variabii
            double sec, min, ore;
            Console.Write("Inserire un tempo in secondi: ");
            sec = Convert.ToDouble(Console.ReadLine());
            min = sec * 0.0167;
            ore = sec * 0.000278;
            Console.WriteLine($"In minuti {min}, in ore: {ore}" );
            Console.ReadLine();
        }
    }
}
