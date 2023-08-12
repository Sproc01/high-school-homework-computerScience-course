using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yield_VS_Enumerable
{
    class Numbers:IEnumerable<int>, IEnumerator<int>
    {
        List<int> list;
        int num;
        int indice;
        public Numbers()
        {
            list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            indice = -1;
        }
        public int Num
        {
            set => num = value;
        }

        public int Current => indice;

        object IEnumerator.Current => indice;

        public void Dispose()
        {
        }

        public IEnumerator<int> GetEnumerator()
        {
            return this;
        }

        public IEnumerable<int> getmultipli()
        {
            foreach (var item in list)
            {
                if (item % num == 0)
                    yield return item;
            }
        }

        public bool MoveNext()
        {
            if (indice < list.Count)
            {
                indice += 1;
                return true;
            }
            else
                return false;
        }

        public void Reset()
        {
            indice = -1;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Numbers vett = new Numbers();
            vett.Num = 3;
            IEnumerable t = vett.getmultipli();
            Console.WriteLine("Vettore completo");
            foreach (var item in vett)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Vettore dei multipli");
            foreach (var item in t)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
