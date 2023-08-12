using System;
using System.Collections.Generic;
using System.Text;

namespace mergeNonRicorsivo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v1;
            int[] v2;
            const int DIM = 8000000;
            DateTime inizio;
            DateTime fine;

            carica(out v1, out v2, DIM);

            inizio = DateTime.Now;
            Array.Sort(v2);
            fine = DateTime.Now;
            Console.WriteLine(inizio);
            Console.WriteLine(fine);
            Console.WriteLine("QuickSort - Tempo impiegato: {0}", millisecondi(fine - inizio));
            controlla(v2);
            Console.WriteLine();

            inizio = DateTime.Now;
            merge(v1, DIM);
            fine = DateTime.Now;
            Console.WriteLine(inizio);
            Console.WriteLine(fine);
            Console.WriteLine("MergeSort - Tempo impiegato: {0}", millisecondi(fine - inizio));
            Console.WriteLine();
            controlla(v1);

            Console.ReadLine();
        }

        static void carica(out int[] v1, out int[] v2, int numero)
        {
            v1 = new int[numero];
            Random rand = new Random();
            for (int i = 0; i < numero; i++)
                v1[i] = rand.Next(10000);
            // creo un secondo vettore uguale al primo
            v2 = (int[])v1.Clone();
        }

        static void controlla(int[] v)
        {
            long i;
            for (i = 0; i < v.Length - 1 && v[i] <= v[i + 1]; i++) ;
            if (i == v.Length - 1)
                Console.WriteLine("Vettore ordinato");
            else
                Console.WriteLine("Errore: Vettore non ordinato");
        }

        static long millisecondi(TimeSpan m)
        {
            return m.Minutes * 60000 + m.Seconds * 1000 + m.Milliseconds;
        }

        static void merge1(int[] v, int[] b, int sinis, int dest, int card)
        {
            int maxi;
            int i, j, k;
            k = sinis;
            i = sinis;
            maxi = sinis + card - 1;
            j = sinis + card;
            do
            {
                if (v[i] <= v[j])           // <= per avere la stabilità dell'ordinamento
                {
                    b[k] = v[i];
                    i++;
                }
                else
                {
                    b[k] = v[j];
                    j++;
                }
                k++;
            } while (i <= maxi && j <= dest);
            while (i <= maxi)                 //copio i rimanenti del sottovettore sin..
            {                                 //in fondo al vettore
                v[dest] = v[maxi];
                maxi--;
                dest--;
            }
            for (int m = sinis; m < k; m++)      //ricopio gli elementi dal vettore b a v
                v[m] = b[m];
        }
        static void merge(int[] v, int DIM)
        {
            int sinis;
            int dest=-1;
            int card=1;
            int[] b = new int[DIM];

            do{
                do
                {
                    sinis = dest + 1;
                    int comodo = sinis + 2 * card - 1;
                    if (comodo < DIM)
                        dest = comodo;
                    else
                        dest = DIM-1;
                    merge1(v, b, sinis, dest, card);
                } while (dest + card < DIM-1);
                card=2*card;
                dest=-1;
            }while (card<DIM);
        }
    }
}
