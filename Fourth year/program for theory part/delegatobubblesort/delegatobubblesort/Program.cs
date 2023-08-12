using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegatobubblesort
{
    delegate bool miodelegato(int x, int y);
    class Program
    {
        static bool ordinasce(int n1,int n2)
        {
            return n1 > n2;
        }
        static bool ordinadesc(int n1, int n2)
        {
            return n1 < n2;
        }
        static int ordinadecuno(int n1, int n2)
        {
            if (n1 < n2)
                return 1;
            else
                if (n1 == n2)
                return 0;
            else
                return -1;
        }
        static bool ordinapari(int n1, int n2)
        {
            return (n1%2!=0)&&(n2%2==0);
        }
        static int ordinapari1(int n1, int n2)
        {
            if ((n1 % 2 != 0) && (n2 % 2 == 0))
                return 1;
            else
                if (n1 == n2)
                return 0;
            else
                return -1;
        }
        static bool Dispari(int n1)
        {
            return n1 % 2 != 0;
        }
        static void sort(int [] v, miodelegato confronto)//confronto metodo delegato
        {
            for (int i = 1; i < v.Length; i++)
            {
                for (int y = 0; y < (v.Length - i); y++)
                {
                    if (confronto(v[y], v[y + 1]))//associa confronto ai metodi delegati
                    {
                        int tmp = v[y];
                        v[y] = v[y + 1];
                        v[y + 1] = tmp;
                    }
                                             
                }
            }
        }
        static void Main(string[] args)
        {
            int[] vettore = new int[] { 5, -7, 8, 10, -5, -20, 6, -30 };
            sort(vettore, ordinasce);//passaggio come metodo delegato
            foreach (int item in vettore)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            sort(vettore, ordinadesc);//passaggio come metodo delegato
            foreach (int item in vettore)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            sort(vettore, ordinapari);//passaggio come metodo delegato
            foreach (int item in vettore)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            Array.Sort(vettore, ordinadecuno);//passaggio come metodo delegato
            foreach (int item in vettore)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            Array.Sort(vettore, ordinapari1);//passaggio come metodo delegato
            foreach (int item in vettore)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            int indispari=Array.FindIndex(vettore, Dispari);//passaggio come metodo delegato
            int numpari = 0;
            if (indispari == -1)
                numpari = vettore.Length;
            else
                numpari = indispari;
            Console.WriteLine("ci sono: "+numpari);
            Console.ReadLine();
        }
        //metodo clone()
        static void provaclone()
        {
            int[][] vv = new int[][] { new int[] { 1, 2 }, new int[] { 3, 4, 5 } };
        }
    }
}
