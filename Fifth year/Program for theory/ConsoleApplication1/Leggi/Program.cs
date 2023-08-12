using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Leggi
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr1 = new StreamReader("f1.txt");
            string stringa = sr1.ReadLine();
            Console.WriteLine(stringa);

            StreamReader sr2 = new StreamReader("f2.txt",Encoding.ASCII);
            stringa = sr2.ReadLine();
            Console.WriteLine(stringa);

            Console.ReadLine();
        }
    }
}
