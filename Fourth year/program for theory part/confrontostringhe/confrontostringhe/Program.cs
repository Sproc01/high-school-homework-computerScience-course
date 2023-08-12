using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace confrontostringhe
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1;
            string s2;
            do
            {
                Console.Write("inserire 1 stringa:");
                s1 = Console.ReadLine();
            } while (s1 == "");//controllo stringa non vuote
            do
            {
                Console.Write("inserire 2 stringa:");
                s2 = Console.ReadLine();
            } while (s2 == "");//controllo stringa non vuote
            int ris;
            ris=Confronto(s1,s2);
               //ris= string.Compare(s1, s2);
               //ris=string.CompareOrdinal(s1,s2);
            Console.WriteLine(ris);
            Console.ReadLine();
        }
        static int Confronto(string s1, string s2)//equivalente compareordinal
        {
            int ris = 0;//ris=1 prima maggiore della seconda, ris=0 uguali; ris=-1 seconda maggiore prima
                for (int i = 0; i <= (s1.Length - 1) && ris != 1 && ris != -1 && i <= (s2.Length - 1); i++)
                {
                    if (s1[i] > s2[i])
                        ris = 1;
                    else
                    {
                        if (s1[i] < s2[i])
                        ris = -1;
                    }
                }
            if (s1.Length > s2.Length)
                ris = 1;
            else
            {
                if (s1.Length > s2.Length)
                    ris = -1;
            }
            return ris;
        }
    }
}
