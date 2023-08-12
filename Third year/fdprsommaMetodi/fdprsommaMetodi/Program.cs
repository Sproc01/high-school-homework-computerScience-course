using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fdprsommaMetodi
{
    class Program
    {
        //dentro i metodi niente operazioni di output al di fuori dell'inserimento valori o output risultato
        static double operando1;
        static double operando2;
        static double risultato;
        static string operatore;
        static void Main(string[] args)
        {
                operando1 = lettura1();
                operando2 = lettura2();
                operatore = leggipoeratori();
            switch(operatore)
            {
                case "+":
                    risultato = somma();
                    break;
                case "-":
                    risultato = differenza();
                    break;
                case "*":
                    risultato = prodotto();
                    break;
                case "/":
                    //controllo variabile operando2
                    while(operando2==0)
                    {
                        Console.WriteLine("Errore matematico, impossibile dividere per 0");
                        operando2 = lettura2();
                    }
                    risultato = quoziente();
                    break;
            }
                Console.WriteLine("Il risultato è:" + risultato);
                Console.ReadLine();
        }
        //metodo lettura 1 operando
        static double lettura1()
        {
            Console.WriteLine("Inserisci il primo operando");
            operando1 = Convert.ToDouble(Console.ReadLine());
            return operando1;
        }
        //metodo lettura 2 operando
        static double lettura2()
        {
            Console.WriteLine("Inserisci il secondo operando");
            operando2 = Convert.ToDouble(Console.ReadLine());
            return operando2;
        }
        static string leggipoeratori()
        {
            Console.WriteLine("Inserisci l'operatore:");
            operatore = Console.ReadLine();
            return operatore;
        }
        //metodo che calcola la somma
        static double somma()
        {
            risultato = operando1 + operando2;
            return risultato;
        }
        static double differenza()
        {
            risultato = operando1 - operando2;
            return risultato;
        }
        static double prodotto()
        {
            risultato = operando1 * operando2;
            return risultato;
        }
        static double quoziente()
        {
            risultato = operando1 / operando2;
            return risultato;
        }
    }
}
