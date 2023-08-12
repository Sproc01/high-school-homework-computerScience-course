using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fdprbinMetodi
{
    class Program
    {
        static void Divisioni(ref int resto, ref byte valore)
        {
            resto = valore % 2;
        }
        static void Quoziente( ref byte valore)
        {
            valore/= 2;
        }
        static void Controllo(ref string dec, ref bool errore, ref byte valore, ref string Errore)
        {
            
            try//ci va dentro la parte di codice in cui si può verificare un eccezione
            {
                valore = Convert.ToByte(dec);
                errore = valore < 0 | valore > 255;
            }
            catch (Exception E)//dentro catch va il blocco di istruzioni da eseguire in caso di eccezione, la variabile E è di tipo exception ed è una stringa
            {
                Errore = E.Message;
                errore = true;
            }
           
        }
        static void Main(string[] args)
        {
            string dec;
            int resto=0;
            int pos = 8;
            int ottetto=8;
            byte valore=0;
            bool errore=false;
            string Errore="";
            Console.WriteLine("Inserisci un numero decimale(tra 0 e 255):");
                dec = Console.ReadLine();
            Controllo(ref dec, ref errore, ref valore, ref Errore);
            Console.WriteLine(Errore);
            while (errore)
            {
                Errore = "";
                Console.WriteLine("Ripetere inserimento");
                dec = Console.ReadLine();
                Controllo(ref dec, ref errore, ref valore, ref Errore);
                Console.WriteLine(Errore);
            }
            Console.Clear();
            Console.WriteLine("L'equivalente in binario è:");
            do
            {
                Divisioni(ref resto, ref valore);
                Console.SetCursorPosition(pos - 1, 1);
                Console.WriteLine(resto);
                Quoziente( ref valore);
                ottetto -= 1;
                pos-= 1;
            } while (valore != 0);
            Console.SetCursorPosition(0, 1);
            switch(ottetto)
            {
                case 1:
                    Console.WriteLine("0");
                    break;
                case 2:
                    Console.WriteLine("00");
                    break;
                case 3:
                    Console.WriteLine("000");
                    break;
                case 4:
                    Console.WriteLine("0000");
                    break;
                case 5:
                    Console.WriteLine("00000");
                    break;
                case 6:
                    Console.WriteLine("000000");
                    break;
                case 7:
                    Console.WriteLine("0000000");
                    break;
                case 8:
                    Console.WriteLine("00000000");
                    break;
            }
            Console.ReadLine();
        }
    }
}
