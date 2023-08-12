using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parametri
{
    class Program
    {
        const int b = 7;
        static void Main(string[] args)
        {
            int a=6;
            M1(ref a);
        }
        static void M1(ref int x)
        {
            x = 7;
            Console.WriteLine(x);
        }
        //aumentare dimensione vettore; dim è l'incremento
        static void Resize(ref int[] v, int dim)
        {
            int[] v1 = new int[v.Length + dim];
            for (int i = 0; i < v1.Length; i++)
                v1[1] = v[i];
            v = v1;

        }
    }
}
