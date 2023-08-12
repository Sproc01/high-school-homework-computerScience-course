using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;//permette di usare la classe thread

namespace fdprProva
{
    class Program
    {
        static void Main(string[] args)
        {
            Random casuale=new Random();/*random è una classe
            random=variabile dinamiche nell'heap(contiene l'indirizzo di memoria di dove è stata allocata la variabile) 
            new random serve per creare una variabile di nome casuale, 
            la variabile casuale eredita i metodi della classe random
            variabile statiche nello stack*/
            int numero = 0;
            int contatore = 0;
            Random facce = casuale;//COPIO L'INDIRIZZO DELLA VARIABILE CASUALE E LO ASSEGNO A FACCE
            while (contatore!=6)
            {
                numero = casuale.Next(1,7);//numero massimo tra parentesi, estremo massimo escluso, minimo compreso, (da 0 a x, x escluso); 
                                           //next è un metodo appartenente alla classe random
                                           //next ha 3 overloads quindi 3 definizioni possibili
                                           /*3 Overloads sono:
                                             Next()   Returns a non-negative random integer.
                                             Next(Int32)  Returns a non-negative random integer that is less than the specified maximum.
                                             Next(Int32, Int32)  Returns a random integer that is within a specified range.*/
                contatore++;//il ++ se è prefisso prima si incrementa e poi assegna nel postfisso invece prima si assegna poi si incrementa
                Console.WriteLine($"il numero casuale è {numero}, il contatore è {contatore}");
                Thread.Sleep(1000);//blocca il programma per un numero di millisecondi
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
