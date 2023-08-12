using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

/*
 *  15.04.2012
 *  
 *  Esempio di implementazione ed uso dell'interfaccia IEnumerable<T>
 *  Questa interfaccia deriva da IEnumerable, per cui e necessario
 *  implementarle entrambe
 *  
 */

namespace Enumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            Contenitore cont = new Contenitore();
            foreach (int x in cont)
                Console.WriteLine(x);
            Console.WriteLine();

            // ciclo equivalente al precedente
            IEnumerator<int> ie = (cont as IEnumerable<int>).GetEnumerator();
            ie.Reset();
            while (ie.MoveNext())
                Console.WriteLine(ie.Current);
            Console.WriteLine();

            // ciclo equivalente al precedente
            IEnumerator ie2 = (cont as IEnumerable).GetEnumerator();
            ie2.Reset();
            while (ie2.MoveNext())
                Console.WriteLine(ie2.Current);
            Console.WriteLine();

            Console.ReadLine();
        }
    }

    

    class Contenitore : IEnumerable<int>
    {
        int[] vettore = new int[5] { 1, 8, 6, 4, 2 };

        IEnumerator<int> IEnumerable<int>.GetEnumerator()
        {
            return new Enumeratore<int>(vettore);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new Enumeratore<int>(vettore);
        }
    }

    class Enumeratore<T> : IEnumerator<T>
    {
        T[] vettore;
        int ind;

        public Enumeratore(T[] v)
        {
            vettore = v;
            ind = -1;
        }

        public void Reset()
        { ind = -1; }

        public bool MoveNext()
        {
            if (ind < vettore.Length - 1)
            {
                ind++;
                return true;
            }
            else
                return false;
        }

        T IEnumerator<T>.Current
        {
            get { return vettore[ind]; }
        }

        object IEnumerator.Current
        {
            get { return vettore[ind]; }
        }

        public void Dispose() { }
    }

}
