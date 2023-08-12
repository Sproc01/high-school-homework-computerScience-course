
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace fdprDado
{
    class Program
    {
        static void Main(string[] args)
        {
            int facceDado = 0;
            bool fine=true;
            bool facce=true;
            Random casuale = new Random();
             while (fine)
             {
                if (!facce)
                    fine = false;
                else
                {
                    facceDado++;
                    Console.Clear();
                }
                switch (facceDado)//controllo possibili valori faccedado
                {
                    case 1:
                        Console.WriteLine("-----");
                        Console.WriteLine("|   |");
                        Console.WriteLine("| o |");
                        Console.WriteLine("|   |");
                        Console.Write("-----");
                        break;
                    case 2:
                        Console.WriteLine("-----");
                        Console.WriteLine("|o  |");
                        Console.WriteLine("|   |");
                        Console.WriteLine("|  o|");
                        Console.Write("-----");
                        break;
                    case 3:
                        Console.WriteLine("-----");
                        Console.WriteLine("|o  |");
                        Console.WriteLine("| o |");
                        Console.WriteLine("|  o|");
                        Console.Write("-----");
                        break;
                    case 4:
                        Console.WriteLine("-----");
                        Console.WriteLine("|o o|");
                        Console.WriteLine("|   |");
                        Console.WriteLine("|o o|");
                        Console.Write("-----");
                        break;
                    case 5:
                        Console.WriteLine("-----");
                        Console.WriteLine("|o o|");
                        Console.WriteLine("| o |");
                        Console.WriteLine("|o o|");
                        Console.Write("-----");
                        break;
                    case 6:
                        Console.WriteLine("-----");
                        Console.WriteLine("|o o|");
                        Console.WriteLine("|o o|");
                        Console.WriteLine("|o o|");
                        Console.Write("-----");
                        break;
                    default:
                        if (facceDado == 7)//faccedado assume valore casuale
                            facce = false;
                        Console.WriteLine("è uscito:");
                        facceDado = casuale.Next(1, 7);
                        break;
                }
                    Thread.Sleep(1000);
             }
            Console.ReadLine();
        }
    }
}

