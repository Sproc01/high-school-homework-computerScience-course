using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hash
{
    class Program
    {

        static void Main(string[] args)
        {
            //creazione hashset
            HashSet<string> classe = new HashSet<string> {"A","C","B","Z" };
            classe.Add("D");//metodo add
            classe.Remove("A");//metodo remove
            foreach (var item in classe)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            HashSet<string> classe1 = new HashSet<string> { "A", "Z" };
            classe1.UnionWith(classe);//metodo unionwith
            foreach (var item in classe1)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            classe1.IntersectWith(classe);//metodoinsertwith
            foreach (var item in classe1)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            classe1.Clear();//metodoclear
            foreach (var item in classe1)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
