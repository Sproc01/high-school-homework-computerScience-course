using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tipo_object
{
    class Program
    {
        static void Main(string[] args)
        {
            string s="Mario";
            object o;
            int x;
            int y;
            o = s;//il riferimento della variabile s è stato passato alla variabile o; 
                 //essendo o tipo padre si può fare però vengono perse alcune caratteristiche del tipo string
                //tipo padre->tipo figlio
               //s = o; questa istruzione è errata perchè object è il tipo padre mentre gli altri sono tipi object estesi
            x = 7;
            o = x;//boxing
            x = 8;//o vale ancora 7 perchè si crea un altro elemento con il boxing
                 //o+1 istruzione errata perchè non si può fare object+int
            y = (int)o;//unboxing tramite conversione esplicita con cast(int); funziona solo se object è compatibile con int altrimenti da errore,
                      //durante l'esecuzione si fa il controllo se dentro o c'è un tipo intero da un'eccenzione in caso non si possa fare

            //================================================
            //================================================
            //================================================

            object[] vo = new object[4];//vettore tipi object
                                       //il vettore punta a 4 celle che puntano ad altre celle perchè tipo object è riferimento
            vo[0] = 7;//boxing
            vo[1] = "Mario";//copia riferimento
            vo[2] = 2.5;//boxing
            vo[3] = true;//boxing
            foreach (object item in vo)
            {
                Console.WriteLine(item);//nel metodo object è presente un metodo tostring
            }
            Console.ReadLine();
        }
    }
}
