using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fdprVerifica3e
{
    class Program
    {
        static void Visuafreq(int [] frqnumeri, int [] frqlettere, out string output)
        {
            output = "";
            int carattere = 64;
            char cara;
            for (int i = 0; i < frqnumeri.Length; i++)
            {
                if(frqnumeri[i]!=0)
                output = output+$"Il numero {i} compare: {frqnumeri[i]} volte\n";
            }
            for (int i = 0; i < frqlettere.Length; i++)
            {
                carattere++;
                cara = Convert.ToChar(carattere);
                if (frqlettere[i] != 0)
                    output += $"La lettere {cara} compare: {frqlettere[i]} volte\n";

            }
        }
        static void Main(string[] args)
        {
            int carattere;
            string output = "";
            string risposta;
            int[] frqnumeri;
            int[] frqlettere;
            do
            {
                frqlettere = new int []{ 0, 0, 0, 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
                frqnumeri = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};


                Console.WriteLine("inserisci sequenza:");
                do
                {
                    carattere = Console.Read();
                    switch (carattere)
                    {
                        case 48:
                            frqnumeri[0] += 1;
                            break;
                        case 49:
                            frqnumeri[1] += 1;
                            break;
                        case 50:
                            frqnumeri[2] += 1;
                            break;
                        case 51:
                            frqnumeri[3] += 1;
                            break;
                        case 52:
                            frqnumeri[4] += 1;
                            break;
                        case 53:
                            frqnumeri[5] += 1;
                            break;
                        case 54:
                            frqnumeri[6] += 1;
                            break;
                        case 55:
                            frqnumeri[7] += 1;
                            break;
                        case 56:
                            frqnumeri[8] += 1;
                            break;
                        case 57:
                            frqnumeri[9] += 1;
                            break;
                        case 65:
                        case 97: frqlettere[0] += 1;
                            break;
                        case 66:
                        case 98:
                            frqlettere[1] += 1;
                            break;
                        case 67:
                        case 99:
                            frqlettere[2] += 1;
                            break;
                        case 68:
                        case 100:
                            frqlettere[3] += 1;
                            break;
                        case 69:
                        case 101:
                            frqlettere[4] += 1;
                            break;
                        case 70:
                        case 102:
                            frqlettere[5] += 1;
                            break;
                        case 71:
                        case 103:
                            frqlettere[6] += 1;
                            break;
                        case 72:
                        case 104:
                            frqlettere[7] += 1;
                            break;
                        case 73:
                        case 105:
                            frqlettere[8] += 1;
                            break;
                        case 74:
                        case 106:
                            frqlettere[9] += 1;
                            break;
                        case 75:
                        case 107:
                            frqlettere[10] += 1;
                            break;
                        case 76:
                        case 108:
                            frqlettere[11] += 1;
                            break;
                        case 77:
                        case 109:
                            frqlettere[12] += 1;
                            break;
                        case 78:
                        case 110:
                            frqlettere[13] += 1;
                            break;
                        case 79:
                        case 111:
                            frqlettere[14] += 1;
                            break;
                        case 80:
                        case 112:
                            frqlettere[15] += 1;
                            break;
                        case 81:
                        case 113:
                            frqlettere[16] += 1;
                            break;
                        case 82:
                        case 114:
                            frqlettere[17] += 1;
                            break;
                        case 83:
                        case 115:
                            frqlettere[18] += 1;
                            break;
                        case 84:
                        case 116:
                            frqlettere[19] += 1;
                            break;
                        case 85:
                        case 117:
                            frqlettere[20] += 1;
                            break;
                        case 86:
                        case 118:
                            frqlettere[21] += 1;
                            break;
                        case 87:
                        case 119:
                            frqlettere[22] += 1;
                            break;
                        case 88:
                        case 120:
                            frqlettere[23] += 1;
                            break;
                        case 89:
                        case 121:
                            frqlettere[24] += 1;
                            break;
                        case 90:
                        case 122:
                            frqlettere[25] += 1;
                            break;
                    }
                    Visuafreq(frqnumeri, frqlettere, out output);
                } while (carattere != 13);
                Console.ReadLine();
                Console.WriteLine(output);
                do
                {
                    Console.WriteLine("Vuoi ripetere il programma?S/N");
                    risposta = Console.ReadLine().ToUpper();
                } while (risposta!="S"&risposta!="N");
            } while (risposta=="S");
        }
    }
}
