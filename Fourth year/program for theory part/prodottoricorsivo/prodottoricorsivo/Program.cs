using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prodottoricorsivo
{
    class Program
    {
        static int Prodotto(int f1, int f2)
        {
            int risultato;
            if (f2 == 0)
                risultato = 0;
            else
                if (f2 > 0)
                risultato = Prodotto(f1, f2 - 1) + f1;
            else
                risultato = Prodotto(f1, f2 + 1) - f1;
            return risultato;
        }
        static int Somma(int f1, int f2)
        {
            int risultato;
            if (f2 == 0)
                risultato = f1;
            else
                if (f2 > 0)
                risultato = Somma(f1, f2 - 1) + 1;
            else
                risultato = Somma(f1, f2 + 1) - 1;
            return risultato;
        }
        static int Prodotto2(int f1, int f2)
        {
            int risultato=0;
            if (f2 > 0)
                for (int i = 0; i < f2; i++)
                    risultato += f1;
            else
                for (int i = 0; i > f2; i--)
                    risultato -= f1;
            return risultato;
        }
        static int Somma2(int f1, int f2)
        {
            int risultato = f1;
            if(f2>0)
            for (int i = 0; i < f2; i++)
                risultato += 1;
            else
                for (int i = 0; i > f2; i--)
                    risultato -= 1;
            return risultato;
        }
        static void Main(string[] args)
        {
            int f1;
            int f2;
            for(; ; )
            {
                Console.WriteLine("inserire primo fattore");
                f1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("inserire secondo fattore");
                f2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("risultato moltiplicazione ricorsiva:" + Prodotto(f1, f2));
                Console.WriteLine("risultato moltiplicazione non ricorsiva:" + Prodotto2(f1, f2));
                Console.WriteLine("risultato somma ricorsiva:" + Somma(f1, f2));
                Console.WriteLine("risultato somma non ricorsiva:" + Somma2(f1, f2));
                Console.ReadLine();
            }
        }
    }
}
