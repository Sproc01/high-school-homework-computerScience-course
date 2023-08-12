using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fdprVerifica
{
    class Program
    {//Michele Sprocatti
        static void InputData(ref int giorno, ref int mese, ref int anno)
        {
            int data;
            string datac;//variabile usata per controllo lunghezza input
            int resto;
            do
            {
                Console.WriteLine("Inserisci data:(formato ggmmaaaa)");
                datac = Console.ReadLine();
                if (datac.Length == 8)
                {
                    data = Convert.ToInt32(datac);
                    resto = data % 10000;
                    data = data / 10000;
                    anno = resto;
                    resto = data % 100;
                    data = data / 100;
                    mese = resto;
                    resto = data % 100;
                    giorno = resto;
                }
                else
                    Console.WriteLine("Errore lunghezza data");
            } while (datac.Length != 8);//ciclo controllo lunghezza input
        }
        static bool OkData(int giorno, int mese, int anno, ref bool errore)
        {
            switch(mese)
            {
                //controllo valore data, corretto o meno
                case 1:
                    if (giorno < 32)
                        errore = false;   
                    break;
                case 2:
                    if (giorno < 29)
                        errore = false;
                    else
                    {
                        if ((anno % 4 == 0 && anno % 100 != 0) || anno % 400 == 0)//controllo anno bisestile
                        {
                            if (giorno < 30)
                                errore = false;
                        }
                    } 
                    break;
                case 3:
                    if (giorno < 32)
                        errore = false;
                    break;
                case 4:
                    mese = 04;
                    if (giorno < 31)
                        errore = false;
                    break;
                case 5:
                    if (giorno < 32)
                        errore = false;
                    break;
                case 6:
                    if (giorno < 31)
                        errore = false;
                    break;
                case 7:
                    if (giorno < 32)
                        errore = false;
                    break;
                case 8:
                    if (giorno < 32)
                        errore = false;
                    break;
                case 9:
                    if (giorno < 31)
                        errore = false;
                    break;
                case 10:
                    if (giorno < 32)
                        errore = false;
                    break;
                case 11:
                    if (giorno < 31)
                        errore = false;
                    break;
                case 12:
                    if (giorno < 32)
                        errore = false;
                    break;
            }
            return errore;
        }
        static void Main(string[] args)
        {
            int giorno=0;
            int mese=0;
            int anno=0;
            bool errore=true;//variabile controllo errore dati
            //ciclo per controllo dati input
            do
            {
                InputData(ref giorno, ref mese, ref anno);//metodo input dati
                OkData(giorno, mese, anno, ref errore);//metodo controllo input
                if (errore)
                    Console.WriteLine("errore ripetere input");
            } while (errore);
            //output
            Console.WriteLine("Il giorno è: " + giorno);
            Console.WriteLine("Il mese è: " + mese);
            Console.WriteLine("L'anno è: " + anno);
            Console.ReadLine();
        }
    }
}
