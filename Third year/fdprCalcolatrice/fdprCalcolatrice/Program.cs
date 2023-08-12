using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fdprCalcolatrice
{
    class Program
    {
        static void Main(string[] args)
        {

            double primo;
            double secondo;
            double risultato;
            string operatore;
            Console.WriteLine("Inserire primo operando:");
            primo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Inserire l'operazione che si vuole fare:");
            operatore = Console.ReadLine();
            Console.WriteLine("Inserire secondo operando:");
            secondo = Convert.ToDouble(Console.ReadLine());
            switch(operatore)
            {
                case "+":
                    risultato = primo + secondo;
                    break;
                case "-":
                    risultato = primo - secondo;
                    break;
                case "*":
                    risultato = primo * secondo;
                    break;
                case "/":
                    while(secondo==0)
                    {
                        Console.WriteLine("Il secondo numero è 0, errore matematico, prego inserire di nuovo il secondo operando:");
                        secondo = Convert.ToDouble(Console.ReadLine());
                    }
                    risultato = primo / secondo;
                    break;
            }
            Console.Write("Il risultato è: ");
            Console.WriteLine(risultato);
            Console.ReadLine();
        }
    }
}
