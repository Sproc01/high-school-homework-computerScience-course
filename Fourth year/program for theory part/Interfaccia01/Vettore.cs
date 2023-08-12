using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaccia01
{
    // una versione primitiva della classe Vettore
    class Vettore 
    {
        object[] vett;

        public Vettore(int len)
        {
            vett = new object[len];
        }

        public int Length
        {
            get { return vett.Length; }
        }

        public Persona this[int indice]
        {
            get
            {
                return (Persona)vett[indice];
            }
            set
            {
                vett[indice] = value;
            }
        }

        public void Sort()
        {
            for (int i = 0; i < vett.Length; i++)
                for (int j = 0; j < vett.Length - 1 - i; j++)
                    if (vett[j] == null || ((Persona)vett[j]).CompareTo(vett[j + 1]) == 1)
                        scambia(ref vett[j], ref vett[j + 1]);
        }

        private void scambia(ref object a, ref object b)
        {
            object c = a;
            a = b;
            b = c;
        }

    }

    // una versione più evoluta della classe Vettore

    class Vettore<T> where T : IComparable, IComparable<T>
    {
        T[] vett;

        public Vettore(int len)
        {
            vett = new T[len];
        }

        public int Length
        {
            get { return vett.Length; }
        }

        public T this[int indice]
        {
            get
            {
                return vett[indice];
            }
            set
            {
                vett[indice] = value;
            }
        }

        public void Sort()
        {
            for (int i = 0; i < vett.Length; i++)
                for (int j = 0; j < vett.Length - 1 - i; j++)
                    if (vett[j] == null  || ((IComparable<T>)vett[j]).CompareTo(vett[j + 1]) == 1)
                        scambia(ref vett[j], ref vett[j + 1]);
        }

        private void scambia(ref T a, ref T b)
        {
            T c = a;
            a = b;
            b = c;
        }
    }

}
