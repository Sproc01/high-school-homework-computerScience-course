using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fdprEstrazioneVettori
{
    class Program
    {
        static void Risultato(int numindovinati, out string risultato)
        {
            risultato = "";
            switch (numindovinati)
            {
                case 0:
                    risultato = "Sei stato sfortunato, riprova la prossima settimana";
                    break;
                case 1:
                    risultato = "Estratto";
                    break;
                case 2:
                    risultato = "Ambo";
                    break;
                case 3:
                    risultato = "Terna";
                    break;
                case 4:
                    risultato = "Quaterna";
                    break;
                case 5:
                    risultato = "Ottimo risultato, cinquina";
                    break;
            }
        }
        static void estrazione(int [] estratti)
        {
            Random estratto = new Random();
            for (int i = 0; i < estratti.Length; i++)
            {
                estratti[i] = estratto.Next(1, 91);
            }
        }
        static void Inputdati(int[] input)
        {
            int x = 0;//posizione cursore
            Console.WriteLine("Tenta la fortuna, sono stati estratti 5(da 1 a 90) numeri prova ad indovinarli");
            for (int i = 0; i < input.Length; i++)
            {
                Console.SetCursorPosition(x, 1);
                input[i] = Convert.ToInt16(Console.ReadLine());
                x += 10;
            }
        }
        static void ControlloRisultati(int[] input, int [] estratti, ref int numindovinati)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if ((input[i] == estratti[0]) | (input[i] == estratti[1]) | (input[i] == estratti[2]) | (input[i] == estratti[3]) | (input[i] == estratti[4]))
                {
                    numindovinati++;
                }
            }
        }
        static void Main(string[] args)
        {
            int[] input = new int[5];//input dell'utente
            int[] estratti = new int[5];//estrazioni casuali
            int numindovinati = 0;
            string risultato="";
            estrazione(estratti);//estrazione casuali numeri
            Inputdati(input);//input dati
            Console.WriteLine("Sono stati estratti "+estratti[0] + ";" + estratti[1] + ";" + estratti[2] + ";" + estratti[3] + ";" + estratti[4]);
            ControlloRisultati(estratti, input, ref numindovinati);//controllo numeri indovinati
            Console.Write("Risultato: ");
            Risultato(numindovinati, out risultato);//controllo possibili risultati lotteria
            Console.WriteLine(risultato);
            Console.ReadLine();
        }
    }
}
