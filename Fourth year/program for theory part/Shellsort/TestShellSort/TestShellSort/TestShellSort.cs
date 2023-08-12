using System;
using System.Collections.Generic;
using System.Text;
using NSShellSort;

namespace TestShellSort
{
    class Program
    {
        static void Main(string[] args)
        {
            const int DIM = 10000000;
            int[] vettore = new int[DIM];
            Random rand = new Random();
            for (int i = 0; i < DIM; i++)
                vettore[i] = rand.Next(DIM/10);

            
            //vettore[0] = 15;
            //vettore[1] = 19;
            //vettore[2] = 95;
            //vettore[3] = 94;
            //vettore[4] = 4;
            //vettore[5] = 55;
            //vettore[6] = 72;
            //vettore[7] = 98;
            //vettore[8] = 92;
            //vettore[9] = 11;
            
            int[] v2 = (int[])vettore.Clone();
            int[] v3 = (int[])vettore.Clone();


            DateTime inizio;
            DateTime fine;

            inizio = DateTime.Now;
            Array.Sort(v2);
            fine = DateTime.Now;
            Console.WriteLine(inizio);
            Console.WriteLine(fine);
            Console.WriteLine("Tempo impiegato: {0}", millisecondi(fine - inizio));
            Console.WriteLine();


            inizio = DateTime.Now;
            Shell.ShellSort(vettore);
            fine = DateTime.Now;
            Console.WriteLine(inizio);
            Console.WriteLine(fine);
            Console.WriteLine("Tempo impiegato: {0}", millisecondi(fine - inizio));
            controlla(v2);
            Console.WriteLine();

            
            inizio = DateTime.Now;
            Shell.shell(v3, 0, v3.Length-1);
            fine = DateTime.Now;
            Console.WriteLine(inizio);
            Console.WriteLine(fine);
            Console.WriteLine("Tempo impiegato: {0}", millisecondi(fine - inizio));
            controlla(v2);
            Console.WriteLine();

            //foreach (int i in vettore)
            //    Console.WriteLine(i);
            //foreach (int i in v2)
            //    Console.WriteLine(i);

            controlla(vettore);
            Console.ReadLine();

        }

        static void controlla(Array v)
        {
            long i;
            for (i = 0; i < v.Length - 1 && 0 >= ((IComparable)(v.GetValue(i))).CompareTo(v.GetValue(i + 1)); i++) ;
            if (i == v.Length - 1)
                Console.WriteLine("Vettore ordinato");
            else
                Console.WriteLine("Errore: Vettore non ordinato");
        }

        static long millisecondi(TimeSpan m)
        {
            return m.Minutes * 60000 + m.Seconds * 1000 + m.Milliseconds;
        }

    }
}
