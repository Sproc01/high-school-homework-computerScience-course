using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ordinamento_personalizzato
{
    struct Persona
    {
        public string Nome;
        public string Cognome;
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> lista = new List<Persona>()
            {new Persona {Nome = "mario", Cognome = "blu"},
                new Persona {Nome = "carlo", Cognome = "verdoni"},
                new Persona {Nome = "paolo", Cognome = "neri"}
            };
            lista.Sort(Confronta1);
            foreach (var item in lista)
            {
                Console.WriteLine(item.Cognome + " " + item.Nome);
            }

            Console.WriteLine(lista.ToString());
            Console.ReadLine();
        }
        static int Confronta(Persona p1, Persona p2)
        {
            int x = string.Compare(p1.Cognome, p2.Cognome);
            if (x == 0)
               return string.Compare(p1.Nome, p2.Nome);
            else
                return x;
        }
        static int Confronta1(Persona p1, Persona p2)
        {
            int x = string.Compare(p1.Nome, p2.Nome);
            if (x == 0)
                return string.Compare(p1.Cognome, p2.Cognome);
            else
                return x;
        }
    }
}
