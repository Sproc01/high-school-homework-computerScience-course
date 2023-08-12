using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaccia01
{
    class Persona : IComparable, IComparable<Persona>
    {
        string nome;
        int voto;
        string giudizio;

        public Persona(string n, int v, string g)
        {
            nome = n;
            voto = v;
            giudizio = g;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", nome, voto, giudizio);
        }

        public int CompareTo(object pers)
        {
            return string.Compare(this.nome, ((Persona)pers).nome);
        }

        public int CompareTo(Persona pers)
        {
            if (pers != null)
                return string.Compare(this.nome, pers.nome);
            else return -1;
        }

    }

}
