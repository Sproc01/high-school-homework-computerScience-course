using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace generici
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int>{ 1, 2, 3, };
            List<string> ls = new List<string>() { "1", "2" };
            Console.WriteLine("{0}  {1}", count<int>(li), count(ls));

            gen1<int> g_int = new gen1<int>();
            g_int.add(1);
            g_int.add(2);
            g_int.add(3);
            int pos;

            g_int.cerca(2, out pos);
            Console.WriteLine(pos);

            Func<int, int, bool> deleg_p1 = p1;
            g_int.cerca2(2, out pos, deleg_p1);
            Console.WriteLine(pos);

            g_int.cerca2(2, out pos, new Func<int, int, bool>(p1));
            Console.WriteLine(pos);

            g_int.cerca2(2, out pos, p1);
            Console.WriteLine(pos);

            double tot = g_int.somma(m3);
            Console.WriteLine(tot);
            Console.ReadLine();

            m4(7);
            Console.ReadLine();

            // prova controvarianza

            Func<CBase, bool> b = m1;
            Func<CDer, bool> d = m1;

            // prova covarianza

            Func<CBase> b1 = m2;

            Lista<CBase> ld = new Lista<CBase>();
            CDer x = new CDer();
            ld.Add1(x);
            ld.Add2(x);

        }

        static int count<T>(List<T> l)
        {
            return l.Count;
        }

        static public bool p1(int x1, int x2)
        {
            return x1 == x2;
        }

        static bool m1(CBase x)
        {
            return true;
        }

        static CDer m2()
        {
            return new CDer();
        }

        static double m3(int valore, double totale)
        {
            return valore + totale;
        }

        static void m4(Mia m)
        {
            Console.WriteLine(m.dato);
        }
 
    }

    class gen1<T> 
    {
        const int DIM = 10;
        private T[] dati = new T[DIM];
        private int pos = 0;

        public void add(T elemento)
        {
            if (pos < DIM)
                dati[pos++] = elemento;
        }

        public bool cerca(T val,out int pos)
        {
            bool trovato = false;
            for (pos = 0; pos < DIM; pos++)
                if (dati[pos].Equals(val))
                {
                    trovato = true;
                    break;
                }
            return trovato;
        }

        public bool cerca2(T val, out int pos, Func<T,T,bool> pred)
        {
            bool trovato = false;
            for (pos = 0; pos < DIM; pos++)
                if (pred(val, dati[pos]))
                {
                    trovato = true;
                    break;
                }
            return trovato;
        }

        public double somma(Func<T, double,double> add)
        {
            double totale =0;
            for (pos = 0; pos < DIM; pos++)
                totale = add(dati[pos], totale);
            return totale;
        }
        public U somma<U>(Func<T, U, U> add)
        {
            U totale = default(U);
            for (pos = 0; pos < DIM; pos++)
                totale = add(dati[pos], totale);
            return totale;
        }
    }

    class CBase
    {

    }

    class CDer : CBase
    {

    }

    class Lista<T>
    {
        public void Add1<U>(U item) where U : T
        {/*...*/
        }

        public void Add2(T item) 
        {/*...*/
        }

    }

    class Mia
    {
        public int dato;
        public Mia(int x) 
        {
            dato = x;
            d1 = new Func<int, int, bool>(M1);
        }

        public static implicit operator Mia(int i)
        {
            return new Mia(i);
        }

        Func<int,int,bool> d1;

        bool M1(int x, int y)
        {
            return true;
        }
    }
   // delegate bool Del(int x, int y);
    

}
