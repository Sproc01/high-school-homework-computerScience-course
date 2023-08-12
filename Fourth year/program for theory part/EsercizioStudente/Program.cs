using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EsercizioStudente
{
    class Studente
    {
        string nome;
        string cognome;

        public Studente(string n, string c)
        {
            nome = n;
            cognome = c;
        }
        
        public string Scuola
        {
            get;
            set;
        }
        public static bool operator ==(Studente s1, Studente s2)
        {
            return s1.nome == s2.nome && s1.cognome == s2.cognome;
        }
        public static bool operator !=(Studente s1, Studente s2)
        {
            return !(s1 == s2);
        }
        public override int GetHashCode()
        {
            return nome.GetHashCode() ^ cognome.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            return this == (Studente)obj;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Studente m = new Studente ("mario","rossi");
            m.Equals(m);
            //Console.WriteLine(m.get_Scuola());
        }
    }
}
