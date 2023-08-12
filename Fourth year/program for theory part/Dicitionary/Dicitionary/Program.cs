using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dicitionary
{
    class Program
    {
        static void ricerca(Dictionary <string,int> classe)
        {
            string nome;
            Console.WriteLine("Inserire nome elemento da ricercare");
            nome = Console.ReadLine();
            string[] nomi = classe.Keys.ToArray();
            int pos=Array.IndexOf(nomi, nome);
            if(pos!=-1)
                Console.WriteLine("Elemento:"+nome+" "+classe[nome]);
            else
                Console.WriteLine("Elemento non trovato");
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Dictionary<string, int> classe = new Dictionary<string, int>();
            classe.Add("A", 3);
            classe.Add("B", 7);
            classe.Add("Z", 9);
            classe.Add("S", 10);
            classe.Add("G", 8);
            Console.WriteLine("Vedere il voto di?");
            Console.WriteLine(classe[Console.ReadLine()]);
            Console.ReadLine();
            ricerca(classe);
        }
    }
}
