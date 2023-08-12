using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fdprIndovinaNumero
{
    class Program
    {
        static void Main(string[] args)
        {
                int numero;
                int numero1 = 0;
                int conta = 0;
                Random casuale = new Random();
                numero = casuale.Next(0, 100)+1;
                do
                {
                    conta++;
                    Console.WriteLine("Prova ad indovinare il numero ");                  
                    numero1 = Convert.ToInt32(Console.ReadLine());
                    if ((numero < numero1)&(numero1!=101))
                        Console.WriteLine("Il numero che hai inserito è troppo grande");
                    if ((numero > numero1) & (numero1 != 101))
                    Console.WriteLine("il numero che hai inserito è troppo piccolo");
                   
                } while (numero1!=101 && numero != numero1) ;
            if (numero == numero1)
                Console.WriteLine($"BRAVOOO! HAI INDOVINATO IL NUMERO IN {conta} TENTATIVI !");
            else
                Console.WriteLine($"Non sei riuscito ad indovinare il numero, hai provato {conta} tentativi");
                Console.ReadLine();
        }

    }
}



