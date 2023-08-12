using System;
using System.Text;
using System.Collections;

namespace enumeratore
{
    /* Classe di esempio che implementa una collezione personalizzata con 3 soli interi
     * Supporta l'interfaccia IEnumerable, per poter usare il foreach
    */
    class MyInsieme : IEnumerable
    {
        private int dato1;
        private int dato2;
        private int dato3;
        public int this[int indice]
        {
            get
            {
                switch (indice)
                {
                    case 1: return dato1;
                        break;
                    case 2: return dato2;
                        break;
                    case 3: return dato3;
                        break;
                    default: return 0;
                }
            }
            set
            {
                switch (indice)
                {
                    case 1: dato1 = value;
                        break;
                    case 2: dato2 = value;
                        break;
                    case 3: dato3 = value;
                        break;
                }
            }
        }

        public IEnumerator GetEnumerator()
        {
            return new MyEnumeratore(this);
        }
    }

    class MyEnumeratore : IEnumerator
    {
        private int posizione = 0;
        private MyInsieme x;
        public MyEnumeratore(MyInsieme t)
        {
            x = t;
        }

        public object Current
        {
            get
            {
                if (posizione > 0 && posizione <= 3)
                    return x[posizione];
                else
                    throw new Exception("Posizione corrente errata nell'insieme");
            }
        }

        public bool MoveNext()
        {
            if (posizione < 3)
            {
                posizione++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            posizione = 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyInsieme ms = new MyInsieme();
            ms[1] = 10;
            ms[2] = 20;
            ms[3] = 30;
            foreach (int x in ms)
                Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
