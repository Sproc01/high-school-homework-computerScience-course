using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fdprsequenza
{
    class Program
    {
        static void Main(string[] args)
        {
            // assegno variabili
            int numero=1;
            int counter=0;
            double resto;
            int contdispari=0;
            int contpari = 0;
            int contpos = 0;
            int contneg = 0;
            int maggiore=0;
            int minore=65535;
            Console.WriteLine("inserire una sequenza di numeri che terminano con 0:");
            numero = Convert.ToInt16(Console.ReadLine());
            if (numero == 0)
                Console.WriteLine("Sequenza vuota");
            else
            {
                while (numero != 0)
                {
                    resto = numero % 2;
                    counter += 1;
                    if (numero > 0)
                        contpos++;
                    else
                        contneg++;
                    if (resto == 0)
                        contpari += 1;//+= 1 aumenta di 1
                    else
                        contdispari++;//++ aumenta variabile di 1
                   
                    if (numero > maggiore) 
                        maggiore = numero;
                    if (numero < minore)
                        minore = numero;
                    numero = Convert.ToInt16(Console.ReadLine());
                }
                //output
                Console.WriteLine($"Inserite {counter} cifre");
                if (contpos != 0)
                    Console.WriteLine($"I numeri positivi sono:{contpos}");
                if (contneg != 0)
                    Console.WriteLine($"I numeri negativi sono:{contneg}");
                if (contpari != 0)
                    Console.WriteLine($"I numeri pari sono:{contpari}");
                if (contdispari != 0)
                    Console.WriteLine($"I numeri dispari sono:{contdispari}");
                Console.WriteLine($"minimo:{minore}, massimo:{maggiore}");
            }
                Console.ReadLine();
            
        }
    }
}
