using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubblesort3
{
    class Program
    {
        static void scambia(ref int x,ref int y)
        {
            int tmp;
            tmp = x;
            x= y;
            y = tmp;
        }
        static void Bubblesort3(int [] v, int num)
        {
            int ultimoScambio = num - 1;
            int pos;
            while(ultimoScambio!=0)
            {
                pos = 0;
                for (int j = 0; j < ultimoScambio; j++)
                {
                    if(v[j]>v[j+1])
                    {
                        scambia(ref v[j],ref v[j+1]);
                        pos = j;
                    }
                }
                ultimoScambio = pos;
            }
        }
        static void Bubblesort4(int[] v, int numfine, int numinizio)
        {
            int ultimoScambio = numfine - 1;
            int pos;
            while (ultimoScambio != 0)
            {
                pos = 0;
                for (int j = numinizio; j < ultimoScambio; j++)
                {
                    if (v[j] > v[j + 1])
                    {
                        scambia(ref v[j],ref v[j+1]);
                        pos = j;
                    }
                }
                ultimoScambio = pos;
            }
        }
        static void Main(string[] args)
        {
            const int dim = 5;
            int[] v = new int[dim] { 8,7,9,4,3 };
            for (int i = 0; i < v.Length; i++)
                Console.WriteLine("Elemento: " + i + " è " + v[i]);
            Console.ReadLine();
            //Bubblesort3(v,v.Length);
            //for (int i = 0; i < v.Length; i++)
                //Console.WriteLine("Elemento: " +i+" è "+ v[i]);
            //Console.ReadLine();
            Bubblesort4(v, v.Length, 1);
            for (int i = 0; i < v.Length; i++)
                Console.WriteLine("Elemento: " + i + " è " + v[i]);
            Console.ReadLine();
        }
    }
}
