using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace argomentiparametri
{
    class Program
    {
        static void M1(string s="ciao", int n=7, double d=0.5)
        {
            Console.WriteLine("{0} / {1} / {2}",s,n,d);
        }
        static void M2(params string [] x)//parametri numero variabile
        {
            foreach (string item in x)
            {
                Console.WriteLine(item);
            }

        }
        static void Main(string[] args)
        {
            M1(d: 8.5);//la precendeza è data agli argomenti rispetto ai valori dati nell'intestazione del metodo
            M2(new string[] { "1","2"});//si può passare un vettore o dati sciolti
            Console.ReadLine();
        }
    }
}
