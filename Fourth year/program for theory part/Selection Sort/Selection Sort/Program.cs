using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] s;
            
        }

        static void OrdinaSelezione(int[] v)
        {
            int temp, posMin;
            for (int i = 0; i < (v.Length - 1); i++)
            {
                //pos = Trovamin(i);
                //Scambia(pos,i);

                posMin = i;
                for (int k = i + 1; k < (v.Length - 1); k++)
                {
                    if (v[k] > v[posMin])
                        posMin = k;
                }
                
            }
        }
    }

}
