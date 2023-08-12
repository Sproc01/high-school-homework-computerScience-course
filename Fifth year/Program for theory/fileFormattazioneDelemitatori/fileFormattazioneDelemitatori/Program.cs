using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace fileFormattazioneDelemitatori
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr;
            StreamWriter sw = new StreamWriter("f1.txt");
            sw.WriteLine("{0}|{1}", "Michele", "Sprocatti");
            sw.WriteLine("|{0}|{1}", "Niccolò", "Zampollo");
            sw.WriteLine("|{0}|{1}|", "Alberto", "Balotta");
            sw.Close();
            sr = new StreamReader("f1.txt");
            string s = sr.ReadToEnd();
            string[] vett = s.Split('|');
            Console.WriteLine(vett[4] +" "+ vett[5]);
            Console.ReadLine();
        }
    }
}
