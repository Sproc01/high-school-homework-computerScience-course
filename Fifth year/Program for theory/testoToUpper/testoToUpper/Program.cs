using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace testoToUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringa;
            StreamReader sr = new StreamReader("f1.txt");
            stringa = sr.ReadLine();
            StreamWriter sw = new StreamWriter("f2.txt");
            while (stringa!=null)
            {
                sw.WriteLine(stringa.ToUpper());
                stringa = sr.ReadLine();
            }
            sr.Close();
            sw.Close();
        }
    }
}
