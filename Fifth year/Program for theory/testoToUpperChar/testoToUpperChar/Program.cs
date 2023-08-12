using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace testoToUpperChar
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("f1.txt");
            StreamWriter sw = new StreamWriter("f2.txt");
            char i;
            do
            {
                i = (char)sr.Read();
                if (i >= 'a' && i <= 'z')
                {
                    i = (char)(i + ('A' - 'a'));
                }
                sw.Write(i);
            } while (sr.Peek() != -1);
            sw.Close();
            sr.Close();
        }
    }
}
