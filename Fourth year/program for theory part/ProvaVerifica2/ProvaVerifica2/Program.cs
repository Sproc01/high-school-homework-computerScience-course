using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaVerifica2
{
    abstract class Persona:IComparable<Persona>
    {
        public string Nome { get; private set; }
        public string Cognome { get; private set; }
        
        public Persona(string n, string c)
        {
            Nome = n;
            Cognome = c;
        }
        public int CompareTo(Persona y)
        {
            return String.Compare(this.Cognome, y.Cognome);
        }
        public override string ToString()
        {
            return Nome + " " + Cognome;
        }
    }
    class HelpPers:IComparer<Persona>
    {
        List<Persona> lista;
        int i;
        public HelpPers(List<Persona> l)
        {
            lista = l;
            i = -1;
        }
        public int Compare(Persona x, Persona y)
        {
            return String.Compare(x.Nome, y.Nome);
        }
    }
    class Studente:Persona
    {
        public string NomeScuola { get; private set; }
        public Studente(string n, string c, string s):base(n,c)
        {
            NomeScuola = s;
        }      
    }
    class Lavoratore:Persona
    {
        public string Azienda { get; private set; }
        public Lavoratore(string n, string c, string a):base(n,c)
        {
            Azienda = a;
        }
    }
    class Popolazione : IEnumerable<Persona>
    {
        List<Persona> popolo;
        
        public int Count
        { get { return popolo.Count; } }
        public Popolazione()
        {
            popolo = new List<Persona>();
        }
        public IEnumerable ordinatiNome()
        {
            List<Persona> lista = new List<Persona>(popolo.Count);
            for (int i = 0; i < popolo.Count; i++)
            {
                lista.Add(popolo[i]);
            }
            lista.Sort(new HelpPers(lista));
            return lista;
        }
        public IEnumerable ordinatiCognome()
        {
            List<Persona> lista = new List<Persona>(popolo.Count);
            for (int i = 0; i < popolo.Count; i++)
            {
                lista.Add(popolo[i]);
            }
            lista.Sort();
            return lista;
        }
        public Persona this[int i]
        {
            get { return popolo[i]; }
        }
        public void Add(Persona p)
        {
            popolo.Add(p);
        }
        public Helpenumpop help()
        {
            return new Helpenumpop(popolo);
        }
        public IEnumerator<Persona> GetEnumerator()
        {
            return popolo.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return popolo.GetEnumerator();
        }
    }

    class Helpenumpop : IEnumerator<Persona>
    {
        int i;
        List<Persona> lista;
        public Helpenumpop(List<Persona> l)
        {
            lista = l;
            i = -1;
        }
        public Persona Current => lista[i];

        object IEnumerator.Current => lista[i];

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            if (i < lista.Count - 1)
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
    }
    class Program
    {
        static void Main(string[] args)
        {
            Popolazione popolo = new Popolazione();
            popolo.Add(new Studente("Mattia", "Vallin", "itis"));
            popolo.Add(new Studente("Matteo", "Balotta", "Scienze Umane"));
            popolo.Add(new Studente("Alberto", "Zampollo", "Ragioneria"));
            popolo.Add(new Studente("Niccolò", "Manzoni", "Liceo"));
            for(int j=0; j<popolo.Count; j++)
            {
                Console.WriteLine(popolo[j]);
            }
            Console.WriteLine();
            Console.WriteLine("ordinati per cognome:");
            IEnumerable i = popolo.ordinatiCognome();
            foreach (var item in i)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("ordinati per nome:");
            IEnumerable g = popolo.ordinatiNome();
            foreach (var item in g)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            Helpenumpop p = popolo.help();
            while(p.MoveNext())
            {
                Console.WriteLine(p.Current);
            }
            p.Reset();
            Console.ReadLine();
        }
    }
}
