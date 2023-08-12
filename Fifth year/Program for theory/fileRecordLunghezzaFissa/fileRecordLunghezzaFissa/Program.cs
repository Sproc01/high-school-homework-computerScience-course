using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace fileRecordLunghezzaFissa
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr;
            StreamWriter sw=new StreamWriter("f1.txt");
            sw.WriteLine("{0, -10} {1,-10}", "Michele", "Sprocatti");
            sw.WriteLine("{0, -10} {1,-10}", "Niccolò", "Zampollo");
            sw.WriteLine("{0, -10} {1,-10}", "Alberto", "Balotta");
            sw.Close();
            sr = new StreamReader("f1.txt");
            string s=sr.ReadToEnd();
            string nome = s.Substring(46, 10);
            string cognome = s.Substring(56, 10);
            Console.WriteLine(nome + cognome);
            Console.ReadLine();
        }
    }
}
