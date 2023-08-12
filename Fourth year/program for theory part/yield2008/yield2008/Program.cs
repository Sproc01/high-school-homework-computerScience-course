using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace yield2008
{
    class Yield
    {
        public class NumberList : IEnumerable<int>
        {
            
            // Creare una matrice di numeri interi.
            public static int[] ints = { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377 };

            // Definire un metodo che restituisce soltanto i numeri pari.
            public static IEnumerable<int> GetEven()
            {
                // Utilizzare yield per restituire i numeri pari dell'elenco.
                foreach (int i in ints)
                {
                    if (i == 5)
                        yield break;
                    if (i % 2 == 0)
                        yield return i;
                }
            }

            // Definire un metodo che restituisce soltanto i numeri dispari.
            public static IEnumerable<int> GetOdd()
            {
                // Utilizzare yield per restituire soltanto i numeri dispari.
                foreach (int i in ints)
                    if (i % 2 == 1)
                        yield return i;
            }

            // Definire un metodo di istanza che restituisce tutti i numeri.
            // Notare il nome e il tipo ritornato.
            public IEnumerator<int> GetEnumerator()
            {
                //foreach (int i in ints)
                //    yield return i;
                for (int j = 0; j< 3; j++)
                    yield return 300;
                
            }

        IEnumerator IEnumerable.GetEnumerator()
        {
            //for (int j = 0; j < 3; j++)
            //    yield return 300;
            yield return 10;
            yield return 20;
            yield return 30;
        }


}

        static void Main(string[] args)
        {
            foreach (int item in new NumberList())
            {
                Console.WriteLine(item);
            }

            // Visualizzare i numeri pari.
            Console.WriteLine("Even numbers");
            IEnumerable<int> q = NumberList.GetEven();
            IEnumerator<int> en = q.GetEnumerator();
            Type t = en.GetType();
            Type t1 = q.GetType();
            //en.Reset();                           // da errore -> non è supportato
            while (en.MoveNext())
                Console.WriteLine(en.Current);
            Console.WriteLine();

            NumberList.ints = new int[] { 10, 20, 3, 7 };
            Console.WriteLine("Even numbers");
            foreach (int i in q)
                Console.WriteLine(i);
            Console.WriteLine();

            // Visualizzare i numeri dispari.
            Console.WriteLine("Odd numbers");
            foreach (int i in NumberList.GetOdd())
                Console.WriteLine(i);
            Console.WriteLine();

            // Visualizzare tutti i numeri.
            Console.WriteLine("All numbers");
            NumberList nl = new NumberList();
            foreach (int i in nl)
                Console.WriteLine(i);
            Console.WriteLine();

            //visualizza tutti i numeri utilizzando l'interfaccia non generica
            NumberList n2 = new NumberList();
            IEnumerable ie2 = n2;
            IEnumerator e2 = ie2.GetEnumerator();
            while (e2.MoveNext())
                Console.WriteLine(e2.Current);


            if ((nl as IEnumerable<int>) != null)
                Console.WriteLine("nl implementa IEnumerable<int>");
            Console.WriteLine();



            // esempio di uso di una classe che implementa l'interfaccia IEnumerable
            prova(0);
            prova(1);

            Console.ReadLine();
        }

        static void prova(int t)
        {
            Elementi v = new Elementi();
            v.tipo = t;
            foreach (int i in v)
                Console.WriteLine(i);
            Console.WriteLine();
        }
    }

    class Elementi : IEnumerable
    {   public int tipo;

        public IEnumerator GetEnumerator()
        {   if (tipo==0)
            {
            Enumeratore e = new Enumeratore();
            return e;
             }
        else
        {
            Enumeratore2 e = new Enumeratore2();
            return e;
        }   
        }
    }

    class Enumeratore : IEnumerator
    {
        int x;

        public object Current
        {
            get
            {
                return x;
            }
        }

        public bool MoveNext()
        {
            x++;
            return (x < 3);
        }

        public void Reset()
        {
            x = -1;
        }
    }
    class Enumeratore2 : IEnumerator
    {
        int x=4;

        public object Current
        {
            get
            {
                return x;
            }
        }

        public bool MoveNext()
        {   
            x--;
            return (x > 0);
        }

        public void Reset()
        {
            x = 4;
        }
    }
}
