using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using library;

namespace triangoloclass
{
    class Program
    {
        static void Main(string[] args)
        {
            double l1, l2, l3;
            Triangolo t;
            int r=10;
            double l;
            string risposta;
            do
            {
                    Console.WriteLine("Inserisci il primo lato");
                    while (!double.TryParse(Console.ReadLine(), out l1))
                    {
                        Console.WriteLine("Ripetere input");
                    }
                    Console.WriteLine("Inserisci il secondo lato");
                    while (!double.TryParse(Console.ReadLine(), out l2))
                    {
                        Console.WriteLine("Ripetere input");
                    }
                    Console.WriteLine("Inserisci il terzo lato");
                    while (!double.TryParse(Console.ReadLine(), out l3))
                    {
                        Console.WriteLine("Ripetere input");
                    }
                    try
                    {
                        t = new Triangolo(l1, l2, l3);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        Console.ReadLine();
                        return;
                    }
                do
                {
                    Console.WriteLine("1-Vuoi calcolare il preimetro del triangolo?");
                    Console.WriteLine("2-Vuoi calcolare l'area del triangolo?");
                    Console.WriteLine("3-Visualizzare informazioni triangolo");
                    Console.WriteLine("4-Visualizzare misura primo lato");
                    Console.WriteLine("5-Visualizzare misura secondo lato");
                    Console.WriteLine("6-Visualizzare misura terzo lato");
                    Console.WriteLine("7-Cambiare misura primo lato");
                    Console.WriteLine("8-Cambiare misura secondo lato");
                    Console.WriteLine("9-Cambiare misura terzo lato");
                    int.TryParse(Console.ReadLine(), out r);
                    switch (r)
                    {
                        case 1:
                            Console.WriteLine("Perimetro" + t.Getperimetro());
                            break;
                        case 2:
                            Console.WriteLine("Area" + t.Getarea());
                            break;
                        case 3:
                            Console.WriteLine(t.visualizza());
                            break;
                        case 4:
                            Console.WriteLine("lato 1:" + t.getlato1());
                            break;
                        case 5:
                            Console.WriteLine("lato 2:" + t.getlato2());
                            break;
                        case 6:
                            Console.WriteLine("lato 3:" + t.getlato3());
                            break;
                        case 7:
                            Console.WriteLine("Inserisci nuova misura:");
                            if (double.TryParse(Console.ReadLine(), out l))
                                t.Setlato1(l);
                            break;
                        case 8:
                            Console.WriteLine("Inserisci nuova misura:");
                            if(double.TryParse(Console.ReadLine(), out l))
                                t.Setlato2(l);
                            break;
                        case 9:
                            Console.WriteLine("Inserisci nuova misura:");
                            if (double.TryParse(Console.ReadLine(), out l))
                                t.Setlato3(l);
                            break;
                    }
                } while (r<10);
                Console.WriteLine("Vuoi creare un nuovo triangolo?S/N");
                risposta = Console.ReadLine().ToUpper();
            } while (risposta=="S");
           
        }
    }
}
