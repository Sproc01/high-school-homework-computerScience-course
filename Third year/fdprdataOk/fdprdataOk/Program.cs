using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fdprdataOk
{
    class Program
    {
        static void InputData(int data, out int Giorno, out int Mese, out int Anno)
        {
            Anno = data % 10000;
            data = data / 10000;
            Mese = data % 100;
            data = data / 100;
            Giorno = data % 100;
        }
        static bool DataOk(int mese, int giorni, int anno)
        {
            bool DataOk=false;
            switch(mese)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    DataOk = giorni > 0 & giorni < 32;
                    break;
                case 2:
                    if(bisestile(anno))
                    {
                        DataOk = (giorni > 0 & giorni < 30);
                    }
                    else
                    {
                        DataOk = (giorni > 0 & giorni < 29);
                    }
                    break;
                default:
                    DataOk = giorni < 31;
                    break;
            }
            return DataOk;
        }
        static bool bisestile(int anno)
        {
            return ((anno % 4 == 0 && anno % 100 != 0) || anno % 400 == 0);
        }
        static void Main(string[] args)
        {
            int Giorno=0;
            int Anno=0;
            int Mese=0;
            bool errore;
            do
            {
                errore = false;
                Console.WriteLine("Inserisci la data da controllare(nel formato ggmmaaaa");
                int data = Convert.ToInt32(Console.ReadLine());
                errore = !(Convert.ToString(data).Length != 8);
                if(!errore)
                {
                    InputData(data, out Giorno, out Mese, out Anno);
                    errore = !(DataOk(Mese, Giorno, Anno));
                }
                if (errore)
                {
                    Console.WriteLine("inserito valore errato");
                }
            } while (errore);
        }
    }
}
