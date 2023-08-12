using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayindexof
{
    class Program
    {
        static int trovaindice(int [] v,int elemento)
        {
            int indice = -1;
            bool trovato = false;
            for (int i = 0; i < v.Length&& !trovato; i++)
                if (elemento == v[i])
                {
                    indice = i;
                    trovato = true;
                }
            return indice;
        }
        static void Main(string[] args)
        {
            int[] vettore = new int[] { 1,5,7,9};
            Console.WriteLine(Array.IndexOf(vettore, 5));
            Console.ReadLine();
            Console.WriteLine(trovaindice(vettore, 5));
            Console.ReadLine();
        }
    }
}
