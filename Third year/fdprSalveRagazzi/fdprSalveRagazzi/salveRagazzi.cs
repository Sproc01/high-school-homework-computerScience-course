using System;//system è il posto da dove prende le classi, cambiandolo le classi si possono riconoscere solo se precedute dal loro namespace che le contiene
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// C#  è un linguaggio ad oggetti
namespace fdprSalveRagazzi
{
    class salveRagazzi /* Nome classe principale, contiene i membri dati e metodi tra i quali il metodo principale main*/
    {
        static void Main(string[] args) //metodo principale, contiene le istruzioni relative all'algoritmo di risoluzione del problema
                                        // viene eseguito all'esecuzione del programma
        {
            string risposta;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.
            Console.Clear();

            System.Console.WriteLine("Salve Ragazzi");
            Console.WriteLine("Premi Invio per continuare");
            risposta=Console.ReadLine();
            Console.WriteLine(risposta);
            Console.ReadLine();

        }
    }
}
