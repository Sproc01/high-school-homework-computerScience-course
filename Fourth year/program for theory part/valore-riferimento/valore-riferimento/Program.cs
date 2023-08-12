using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valore_riferimento
{
    class Program
    {
        static void Main(string[] args)
        {
            int i1;
            int i2;
            i1 = 7;
            i2 = i1;
            i1 = 10;
            //i1 vale 10 e i2 vale 7 perchè sono tipi valore se fossero riferimento i2 avrebbe come valore 10

            int[] v1;
            int[] v2;
            v1 = new int[] { 1, 2, 3 };
            v2 = v1;
            v1[0] = 10;
            v1 = new int[] { 7 };
        }
    }
}
