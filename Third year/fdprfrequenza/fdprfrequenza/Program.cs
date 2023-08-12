using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fdprfrequenza
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero=0;
            int resto=1;
            int fre1=0;
            int fre2=0;
            int fre3=0;
            int fre4=0;
            int fre5=0;
            int fre6=0;
            int fre7 = 0;
            int fre8=0;
            int fre9=0;
            Console.WriteLine("Inserisci un numero:");
            numero = Convert.ToInt32(Console.ReadLine());
            while (resto != 0) 
            {
                resto = numero % 10;
                numero = numero / 10;
                if (resto == 1)
                    fre1++;
                if (resto == 2)
                    fre2++;
                if (resto == 3)
                    fre3++;
                if (resto == 4)
                    fre4++;
                if (resto == 5)
                    fre5++;
                if (resto == 6)
                    fre6++;
                if (resto == 7)
                    fre7++;
                if (resto == 8)
                    fre8++;
                if (resto == 9)
                    fre9++;
            }
            if (fre1 != 0)
                Console.WriteLine("L'1 è stato inserito: " + fre1);
            if (fre2 != 0)
                Console.WriteLine("Il 2 è stato inserito: " + fre2);
            if (fre3 != 0)
                Console.WriteLine("Il 3 è stato inserito: " + fre3);
            if (fre4 != 0)
                Console.WriteLine("Il 4 è stato inserito: " + fre4);
            if (fre5 != 0)
                Console.WriteLine("Il 5 è stato inserito: " + fre5);
            if (fre6 != 0)
                Console.WriteLine("Il 6 è stato inserito: " + fre6);
            if (fre7 != 0)
                Console.WriteLine("Il 7 è stato inserito: " + fre7);
            if (fre8 != 0)
                Console.WriteLine("L'8 è stato inserito: " + fre8);
            if (fre9 != 0)
                Console.WriteLine("Il 9 è stato inserito: " + fre9);
            Console.ReadLine();
        }
    }
}
