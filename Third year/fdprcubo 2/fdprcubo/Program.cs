
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
            int facceDado = 1;
            bool fine = true;
            Random casuale = new Random();
             while (fine)
             {
                if (facceDado == 7)
                {
                    fine = false;
                    facceDado = casuale.Next(1,7);
                    Console.WriteLine("è uscito:");
                }
                    if (facceDado == 1)
                    {
                        Console.WriteLine("-----");
                        Console.WriteLine("|   |");
                        Console.WriteLine("| o |");
                        Console.WriteLine("|   |");
                        Console.Write("-----");
                    }
                    else
                    {
                        if (facceDado == 2)
                        {
                            Console.WriteLine("-----");
                            Console.WriteLine("|o  |");
                            Console.WriteLine("|   |");
                            Console.WriteLine("|  o|");
                            Console.Write("-----");
                        }
                        else
                        {
                            if (facceDado == 3)
                            {
                                Console.WriteLine("-----");
                                Console.WriteLine("|o  |");
                                Console.WriteLine("| o |");
                                Console.WriteLine("|  o|");
                                Console.Write("-----");
                            }
                            else
                            {
                                if (facceDado == 4)
                                {
                                    Console.WriteLine("-----");
                                    Console.WriteLine("|o o|");
                                    Console.WriteLine("|   |");
                                    Console.WriteLine("|o o|");
                                    Console.Write("-----");
                                }
                                else
                                {
                                    if (facceDado == 5)
                                    {
                                        Console.WriteLine("-----");
                                        Console.WriteLine("|o o|");
                                        Console.WriteLine("| o |");
                                        Console.WriteLine("|o o|");
                                        Console.Write("-----");
                                    }
                                        else
                                        {   if (facceDado == 6)
                                            {
                                                Console.WriteLine("-----");
                                                Console.WriteLine("|o o|");
                                                Console.WriteLine("|o o|");
                                                Console.WriteLine("|o o|");
                                                Console.Write("-----");
                                            }
                                        }
                                }
                            }
                        }
                    }
                    facceDado++;
                    Thread.Sleep(1000);
                    if (fine)
                    Console.Clear();
             }
            Console.ReadLine();
        }
    }
}

