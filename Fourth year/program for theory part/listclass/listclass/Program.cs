using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listclass
{
    class Program
    {
        static bool predicato(string s)
        {
            return s[0] == 'g';
        }
        static void inserimentorange(List<string> nomi, int indice, string [] nomi1)
        {
            for (int i = 0; i < nomi1.Length; i++)
            {
                nomi.Insert(indice, nomi1[i]);
                indice++;
            }
        }
        static void removerange(List<string> nomi, int indice1, int indice2)
        {
            for (int i = indice1; indice1 < indice2; indice1++)
            {
                nomi.Remove(nomi[i]);
            }
        }
        static int indexof(List<string> nomi, string nome)
        {
            for (int i = 0; i < nomi.Count; i++)
            {
                if (nomi[i] == nome)
                    return i;
            }
            return -1;
        }
        static void Inserimento(List<string> nomi, string nome)
        {
            nomi.Add(nome);
        }
        static void Clear(List<string> nomi)
        {
            nomi.RemoveRange(0, nomi.Count);
        }

        static void Main(string[] args)
        {
            int pos;
            List<string> nomi = new List<string>(7);
            nomi.Add("giulia");
            nomi.Add("michele");
            nomi.Add("francesco");
            foreach (var item in nomi)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            Console.WriteLine("inserire elemento da inserire");
            Inserimento(nomi, Console.ReadLine());
            Console.ReadLine();
            foreach (var item in nomi)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            Console.WriteLine("Inserisci nome da cercare");
            pos= nomi.IndexOf(Console.ReadLine());
            Console.WriteLine("pos index of:"+pos);
            Console.ReadLine();
            Console.WriteLine("Inserisci nome da cercare");
            pos = indexof(nomi,Console.ReadLine());
            Console.WriteLine("pos mio:"+pos);
            Console.ReadLine();
            Clear(nomi);
            foreach (var item in nomi)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            string [] nomi1 = { "kappa", "pollo" };
            nomi.InsertRange(0, nomi1);
            foreach (var item in nomi)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            Clear(nomi);
            inserimentorange(nomi, 0, nomi1);
            foreach (var item in nomi)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            nomi.RemoveRange(0, 1);
            foreach (var item in nomi)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            nomi.Add("giulia");
            nomi.Add("michele");
            nomi.Add("francesco");
            foreach (var item in nomi)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            removerange(nomi, 0, 2);
            foreach (var item in nomi)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            nomi.Add("giulia");
            nomi.Add("gaia");
            nomi.Add("francesco");
            List<string> find=new List<string>(nomi.FindAll(predicato));
            foreach (var item in find)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
