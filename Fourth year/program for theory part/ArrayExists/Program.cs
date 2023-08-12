using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prova
{
    delegate bool mioDelegato<T>(T s);
    class Program
    {
        static void Main(string[] args)
        {
            int[] vettore= new int [] {1,2,-3};
            int a = Array.IndexOf(vettore, 7);
            mioDelegato<string> m;
            m = m1;
            Console.WriteLine(m("pippo"));
            m = m2;
            Console.WriteLine(m("pippo"));
            Console.WriteLine(Array.Exists(vettore, esiste));
            
            Console.ReadLine();

        }
        static bool m1(string s)
        {
            Console.WriteLine("Ciao" + s);
            return true;
        }
        static bool m2(string s)
        {
            Console.WriteLine("Hello" + s);
            return false;
        }
        static bool esiste(int i)
        {
            if (i > 2)
                return true;
            else
                return false;
        }
    }

}
