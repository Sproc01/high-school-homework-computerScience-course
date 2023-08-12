using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classdipendente
{
    class dipendete
    {
        private string _nome;
        private string _cognome;
        private int _ore;

        public dipendete(string nome, string cognome, int ore)
        {
            _nome = nome;
            _cognome = cognome;
            _ore = ore;
        }
        public void visualizza()
        {
            Console.WriteLine("Nome:" + _nome);
            Console.WriteLine("Cognome:" + _cognome);
            Console.WriteLine("Ore effettuate:" + _ore+"\n");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<dipendete> azienda = new List<dipendete>();
            azienda.Add(new dipendete ( "alfredo", "strano",3 ));
            azienda.Add(new dipendete("Michele", "Sprocatti", 24));
            foreach (var item in azienda)
            {
                item.visualizza();
            }
            Console.ReadLine();
        }
    }
}
