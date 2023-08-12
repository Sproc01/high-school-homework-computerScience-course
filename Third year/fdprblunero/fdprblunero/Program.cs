using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fdprblunero
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 counter=0;
            Int32 cicle = 0;
            while (cicle<=80)
            {
                while (counter < 120)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write(" ");
                    counter = counter + 1;
                }
                while (counter < 240)
                {
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.Write (" ");
                    counter = counter + 1;
                }
                while (counter==240)
                {
                    cicle = cicle + 1;
                    counter = 0;
                }
            }
            Console.SetCursorPosition(0, 0);
            Console.ReadLine();
        }
    }
}
