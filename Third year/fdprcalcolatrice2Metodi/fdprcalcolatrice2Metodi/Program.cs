using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcolatrice2
{
    class Program
    {
        static double num1;
        static double num2;
        static double risultato;
        static string operatore;

        //static double Leggi1()
        //{
        //    Console.WriteLine("Inserisci il numero 1");
        //    num1 = Convert.ToDouble(Console.ReadLine());
        //    return num1;
        //}

        static void Leggi1(out double num1)
        {
            Console.WriteLine("Inserisci il numero 1");
            num1 = Convert.ToDouble(Console.ReadLine());

        }

        //static double Leggi2()
        //{
        //    Console.WriteLine("Inserire il numero 2");
        //    num2 = Convert.ToDouble(Console.ReadLine());
        //    return num2;
        //}

        static void Leggi2(out double num2)
        {
            Console.WriteLine("Inserire il numero 2");
            num2 = Convert.ToDouble(Console.ReadLine());

        }

        static double somma()
        {
            risultato = num1 + num2;                //non si usano le writeline quando ci sono solo operazioni
            return risultato;

        }

        static double differenza()
        {
            risultato = num1 - num2;
            return risultato;
        }

        static double moltiplicazione()
        {
            risultato = num1 * num2;
            return risultato;
        }

        static double quoziente()
        {
            risultato = num1 / num2;
            return risultato;
        }
        static string Leggioperatore()
        {
            string operatore;
            Console.WriteLine("Inserire l'operatore");
            operatore = Console.ReadLine();
            return operatore;
        }

        static void Main(string[] args)
        {

            //lettura primo valore
            Leggi1(out num1);
            //lettura secondo valore
            Leggi2(out num2);
            risultato = somma();
            //lettura operatore aritmetico
            operatore = Leggioperatore();
            bool falsa = (num2 == 0);

            switch (operatore)
            {
                case ("+"):
                    risultato = somma();
                    break;

                case ("-"):
                    risultato = differenza();
                    break;

                case ("*"):
                    risultato = moltiplicazione();
                    break;

                case ("/"):
                    while (falsa)
                    {
                        if (num1 == 0)
                        {
                            Console.WriteLine("Indeterminata");
                            falsa = false;
                        }

                        else
                        {
                            Console.WriteLine("Errore matematico; non Ë possibile dividere per zero");
                            Leggi2(out num2);
                            falsa = num2 == 0;
                        }
                    }

                    risultato = quoziente();
                    break;

            }
            if (num1 != 0)
                Console.WriteLine("Il risultato Ë " + risultato);
            Console.ReadLine();

        }
    }
}
//non si deve usare il writeline quando ci sono solo delle operazioni 
//ma solo quando ci sono operazioni di lettura o visualizzazione
