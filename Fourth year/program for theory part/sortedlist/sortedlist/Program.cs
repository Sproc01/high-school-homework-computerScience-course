using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortedlist
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, int> classe = new SortedList<string, int>();
            classe.Add("michele", 9);
            classe.Add("hermann", 2);
            classe.Add("giovanni", 3);
            foreach (KeyValuePair<string,int> item in classe)
            {
                Console.WriteLine(item.Key + item.Value);
            }
            Console.ReadLine();
            classe.RemoveAt(2);
            foreach (KeyValuePair<string, int> item in classe)
            {
                Console.WriteLine(item.Key + item.Value);
            }
            Console.ReadLine();
            Console.WriteLine("inserire nome da cercare");
            int pos=classe.IndexOfKey(Console.ReadLine());
            Console.WriteLine(classe.Values[pos]);
            Console.ReadLine();
        }
    }
}
