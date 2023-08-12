
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fdprcubo
{
    class Program
    {
        static void Main(string[] args)
        {
            int facceDado=1;
            while(facceDado!=0)
            {
                    if (facceDado == 1)
                {
                    Console.WriteLine("-----");
                    Console.WriteLine("|   |");
                    Console.WriteLine("| o |");
                    Console.WriteLine("|   |");
                    Console.Write("-----");
                }

                
                    if (facceDado == 2)
                    {
                        Console.WriteLine("-----");
                        Console.WriteLine("|o  |");
                        Console.WriteLine("|   |");
                        Console.WriteLine("|  o|");
                        Console.Write("-----");
                    }
                    
                    if (facceDado == 3)
                    {
                        Console.WriteLine("-----");
                        Console.WriteLine("|o  |");
                        Console.WriteLine("| o |");
                        Console.WriteLine("|  o|");
                        Console.Write("-----");
                    }
                    
                      if (facceDado == 4)
                            {
                                Console.WriteLine("-----");
                                Console.WriteLine("|o o|");
                                Console.WriteLine("|   |");
                                Console.WriteLine("|o o|");
                                Console.Write("-----");
                            }
                    
                        if (facceDado == 5)
                    {
                        Console.WriteLine("-----");
                        Console.WriteLine("|o o|");
                        Console.WriteLine("| o |");
                        Console.WriteLine("|o o|");
                        Console.Write("-----");
                    }
                    
                        if (facceDado == 6)
                         {
                        Console.WriteLine("-----");
                        Console.WriteLine("|o o|");
                        Console.WriteLine("|o o|");
                        Console.WriteLine("|o o|");
                        Console.Write("-----");

                         }
                    facceDado++;
                    Console.ReadLine();
                    Console.Clear();
                }
                
            }
    }
}

