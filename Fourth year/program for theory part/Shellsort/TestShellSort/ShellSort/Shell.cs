using System;
using System.Collections.Generic;
using System.Text;

// La complessità di questo algoritmo è:  O(n^1.2)

namespace NSShellSort
{
    public class Shell
    {
        public static void ShellSort(int[] vettore)
        {
            int x;
            int m;
            // determino il vettore con i passi
            int lung = vettore.Length;
            int dim = (int)Math.Log(lung,2) - 1;
            int[] passo = new int[dim];
            int p = 0;
            for (int i = dim - 1; i >= 0; i--)
            {
                passo[i] = p * 2 + 1;
                p = passo[i];
            }
            // faccio il sort usando i vari passi
            for (int i = 0; i < dim; i++)
            {
                p = passo[i];
                for (int l = p; l < lung; l++)
                {
                    x = vettore[l];
                    m = l - p;
                    while (m >= 0 && x < vettore[m])
                    {
                        vettore[m + p] = vettore[m];
                        m -= p;
                    }
                    vettore[m + p] = x;
                }
            }
        }

        // versione con una diversa sequenza di passi
        public static void shell(int[] a, int l, int r)
        {
            int h;
            for (h = 1; h <= (r - l) / 9; h = 3 * h + 1) ;
            for (; h > 0; h /= 3)
                for (int i = l + h; i <= r; i++)
                {
                    int j = i;
                    int v = a[i];
                    while (j >= l + h && v < a[j - h])
                    {
                      a[j] = a[j - h];
                      j -= h;
                    }
                    a[j] = v;
                }
        }
    }
}
