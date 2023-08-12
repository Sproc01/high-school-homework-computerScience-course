using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fdprcontaNumeri
{
    class Program
    {
        static void Main(string[] args)
        {
            double valore;
            valore = 0;
            double valoreinserito;
            Console.WriteLine("Inserire valori numerici");
            valoreinserito = 1;
            while (valoreinserito != 0)
            {
                valoreinserito = Convert.ToDouble(Console.ReadLine());
                valore = valore + 1;
            }
            Console.WriteLine("sono stati inseriti " + (valore-1)+" valori");
            Console.ReadLine();
        }
    }
}
