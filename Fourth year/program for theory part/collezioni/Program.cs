using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace collezioni
{
    struct Lista
    {
        public int numelementi;
        public int[] vett = new int[10];
    }

    struct ListaObject
    {
        public int numelementi;
        public object[] vett = new object[10];
    }

    class Program
    {
        static void Add(Lista l, int val)
        {
            if (l.numelementi == l.vett.Length)
            {
                int[] tmp = new int[l.vett.Length + 10];
                for (int i = 0; i < l.vett.Length; i++)
                    tmp[i] = l.vett[i];
                l.vett = tmp;
            }
            l.vett[l.numelementi] = val;
            l.numelementi++;
        }

        static void AddObject(ListaObject l, object val)
        {
            if (l.numelementi == l.vett.Length)
            {
                object[] tmp = new object[l.vett.Length + 10];
                for (int i = 0; i < l.vett.Length; i++)
                    tmp[i] = l.vett[i];
                l.vett = tmp;
            }
            l.vett[l.numelementi] = val;
            l.numelementi++;
        }

        static void AddInt(ListaObject l, int val)
        {
            AddObject(l,val);

        }

        static int Count(Lista l)
        {
            return l.numelementi;
        }

        static void Main(string[] args)
        {
            ListaObject l1 = new ListaObject();
            ListaObject l2 = new ListaObject();

            AddObject(l1, 7);
            AddObject(l1, "pippo");

            AddInt(l1, 7);
            //AddInt(l1, "pippo");

            List<int> l3=new List<int>();
            l3.Add(7);
            l3.Add("pippo");
        }
    }
}
