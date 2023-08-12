using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaVerfica
{
    class Persona:IComparable<Persona>
    {
        string nome;
        DateTime nascita;
        public Persona(string n, DateTime d)
        {
            nome = n;
            nascita = d;
        }
        public string Nome
        { get { return nome; } }
        public DateTime Nascita
        { get { return nascita; } }


        public int CompareTo(Persona y)
        {
            if ((DateTime.Now - this.nascita) > (DateTime.Now - y.nascita))
                return -1;
            if ((DateTime.Now - this.nascita) < (DateTime.Now - y.nascita))
                return 1;
            return 0;
        }

        public override string ToString()
        {
            return nome + ":" + nascita.ToShortDateString();
        }
    }
    class Helpord : IComparer<Persona>
    {
        public int Compare(Persona x, Persona y)
        {
                if ((DateTime.Now - x.Nascita) > (DateTime.Now - y.Nascita))
                    return 1;
                if ((DateTime.Now - x.Nascita) < (DateTime.Now - y.Nascita))
                    return -1;
                return 0;
        }
    }
    class Gruppo:IEnumerable
    {
        List<Persona> lista;

        public Gruppo(List<Persona> l)
        {
            lista = new List<Persona>(l);
        }

        public IEnumerator GetEnumerator()
        {
            return new EnumeratorGruppo(lista);
        }

        public IEnumerable GetOrdinati()
        {
            List<Persona> l = new List<Persona>(lista);
            l.Sort();
            return l;
        }
        public IEnumerable GetInversi()
        {
            List<Persona> l = new List<Persona>(lista);
            l.Sort(new Helpord());
            return l;
        }
    }
    class EnumeratorGruppo : IEnumerator<Persona>
    {
        int i;
        List<Persona> list;

        public EnumeratorGruppo( List<Persona> lista)
        {
            i = -1;
            list = lista;
        }

        public object Current
        {
            get => list[i];
        }

        Persona IEnumerator<Persona>.Current
        {
            get => list[i];
        }

        public bool MoveNext()
        {
            if (i < list.Count-1)
            {
                i++;
                return true;
            }
            else
                return false;

        }

        public void Reset()
        {
            i = -1;
        }

        public void Dispose()
        {
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> l = new List<Persona>() { new Persona("gino", new DateTime(2001, 12, 28)), new Persona("pino", new DateTime(1998, 12, 5)), new Persona("zorro", new DateTime(2002, 11, 15)) };
            Gruppo g = new Gruppo(l);
            foreach (var item in g)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            IEnumerable f = g.GetInversi();
            foreach (var item in f)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            IEnumerable z = g.GetOrdinati();
            foreach (var item in z)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
