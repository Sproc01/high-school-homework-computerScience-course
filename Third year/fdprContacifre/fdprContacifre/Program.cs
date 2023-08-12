using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fdprContacifre
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int numcifre;
            Console.WriteLine("Inserire numero:");
            numero = Convert.ToInt16(Console.ReadLine());
            numcifre = 0;
            while (numero != 0)
            {
                numero = numero / 10;
                numcifre = numcifre + 1;
            }
            Console.WriteLine("Sono state inserite: " + numcifre);
            Console.ReadLine();
        }
    }
}
