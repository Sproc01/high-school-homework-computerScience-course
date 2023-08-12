using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fdprEstrazioneVenezia
{
    class Program
    {
        static void Main(string[] args)
        {
            int input1;
            int input2;
            int input3;
            int input4;
            int input5;//input dell'utente
            int random1;
            int random2;
            int random3;
            int random4;
            int random5;//estrazioni casuali
            bool erroreEstrazione;
            int numindovinati=0;
            Random estratto = new Random();
            do
            {
                //string.format("{0,3}";Numero); riserva uno spazio di 3 caratteri a numero
                random1 = estratto.Next(1, 91);
                random2 = estratto.Next(1, 91);
                random3 = estratto.Next(1, 91);
                random4 = estratto.Next(1, 91);
                random5 = estratto.Next(1, 91);
                erroreEstrazione = (random1 == random2) | (random1 == random3) | (random1 == random4) | (random1 == random5) | (random2 == random1) | (random2 == random3) | (random2 == random4) | (random2 == random5) | (random3 == random1) | (random3 == random2) | (random3 == random4) | (random3 == random5) | (random4 == random1) | (random4 == random2) | (random4 == random3) | (random4 == random5) | (random5 == random1) | (random5 == random2)|(random5 == random3) | (random5 == random4);
            } while (erroreEstrazione);
            Console.WriteLine("Tenta la fortuna, sono stati estratti 5 numeri prova ad indovinarli");
            //input 5 numeri
            input1 = Convert.ToInt16(Console.ReadLine());
            Console.SetCursorPosition(10, 1);
            input2 = Convert.ToInt16(Console.ReadLine());
            Console.SetCursorPosition(20, 1);
            input3 = Convert.ToInt16(Console.ReadLine());
            Console.SetCursorPosition(30, 1);
            input4 = Convert.ToInt16(Console.ReadLine());
            Console.SetCursorPosition(40, 1);
            input5 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(random1+";"+random2+";"+random3 + ";" + random4 + ";" + random5);
            //incremento variabile per i risultati
            if ((input1 == random1) | (input1 == random2) | (input1 == random3) | (input1 == random4) | (input1 == random5))
            {
                Console.WriteLine("1 numero indovinato");
                numindovinati++;
            }
            if ((input2 == random1) | (input2 == random2) | (input3 == random3) | (input4 == random4) | (input5 == random5))
            {
                Console.WriteLine("1 numero indovinato");
                numindovinati++;
            }
            if ((input3 == random1) | (input3 == random2) | (input3 == random3) | (input3 == random4) | (input3 == random5))
            {
                Console.WriteLine("1 numero indovinato");
                numindovinati++;
            }
            if ((input4 == random1) | (input4 == random2) | (input4 == random3) | (input4 == random4) | (input4 == random5))
            {
                Console.WriteLine("1 numero indovinato");
                numindovinati++;
            }
            if ((input5 == random1) | (input5 == random2) | (input5 == random3) | (input5 == random4) | (input5 == random5))
            {
                Console.WriteLine("1 numero indovinato");
                numindovinati++;
            }
            //controllo possibili risultati lotteria
            Console.Write("Risultato: ");
            switch (numindovinati)
            {
                case 0:
                    Console.WriteLine("Sei stato sfortunato riprova la prossima settimana");
                    break;
                case 1:
                    Console.WriteLine("Estratto");
                    break;
                case 2:
                    Console.Write("ambo");
                    break;
                case 3:
                    Console.Write("terna");
                    break;
                case 4:
                    Console.Write("quaterna");
                    break;
                case 5:
                        Console.WriteLine("Hai indovinato tutti e cinque i numeri");
                break;
            }
        Console.ReadLine();
        }
    }
}
