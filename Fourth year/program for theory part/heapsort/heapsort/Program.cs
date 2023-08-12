using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heapsort
{
    class Program
    {
        static void Scambia(ref int x, ref int y)
        {
            int t;
            t = y;
            y = x;
            x = t;
        }
        static void Maxheap(int[] a, int i, int heapsize)
        {
            bool continua = true;
            int largest;
            do
            {
                int l = 2 * i + 1; //left
                int r = 2 * (i + 1);//right
                if (l < heapsize && a[l] > a[i])
                    largest = l;
                else
                    largest = i;
                if (r < heapsize && a[r] > a[largest])
                    largest = r;
                if (largest != i)
                {
                    Scambia(ref a[largest], ref a[i]);
                    i = largest;
                }
                else
                    continua = false;
            } while (continua);

        }
        static bool controllo(int[] a)
        {
            bool ordinato = true;
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] > a[i + 1])
                    ordinato = false;
            }
            return ordinato;
        }
        static void Buildheap(int[] a)
        {
            int heapsize = a.Length;
            for (int i = (a.Length / 2); i >= 0; i--)
                Maxheap(a, i, heapsize);
        }
        static void Heapsort(int[] a)
        {
            int heapSizeA = a.Length;
            for (int i = a.Length - 1; i >= 1; i--)
            {
                Scambia(ref a[0], ref a[i]);
                heapSizeA--;
                Maxheap(a, 0, heapSizeA);
            }
        }
        static void Main(string[] args)
        {
            int[] a = new int[10000000];
            for (int i = 0; i < a.Length; i++)
            {
                int x = new Random().Next(0, 100);
                a[i] = x;
            }
            Buildheap(a);
            Heapsort(a);
            Console.WriteLine("Il vettore è ordinato:" + controllo(a));
            Console.ReadLine();
        }
    }
}
