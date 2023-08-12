using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace codifica
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "1►2";//codifica a 8 bit codifica il carattere strano con 3 byte
            StreamWriter p = new StreamWriter("F1.txt");
            p.WriteLine(s1);
            p.Close();
            string s2 = "1►2";
            StreamWriter f2 = new StreamWriter("F2.txt",false,Encoding.Unicode);
            f2.WriteLine(s2);
            f2.Close();

            Console.WriteLine("Serain");
        }
    }
}
