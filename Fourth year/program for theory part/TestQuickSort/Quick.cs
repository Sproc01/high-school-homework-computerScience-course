using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace NSQuickSort
{
    public class Quick
    {
        static public int contatore = 0;
        static int[] stack = new int[10];
        public static void QuickSort(int[] v, int inizio, int fine)
        {
            int x;
            int y;
            contatore++;
            int i = inizio + 1;
            int j = fine;
            x = v[inizio];
            do
            {
                while (v[j] > x) 
                    j--;
                while (i<=j && v[i]<=x)
                    i++;
                if (i < j)
                {
                    y = v[i];
                    v[i] = v[j];
                    v[j] = y;
                    i++;
                    j--;
                }
            }
            while (i <= j);
            y = v[inizio];
            v[inizio] = v[j];
            v[j] = y;
            if (inizio < j-1)
                QuickSort(v, inizio, j - 1);
            if (j+1 < fine)
                QuickSort(v,j+1,fine);
        }


        public static void QuickSort1(int[] v, int inizio, int fine)
        {
            int x;
            int y;
            int i;
            int j;

            //Console.WriteLine("{0} - {1}", inizio, fine);
            //foreach (int ii in v)
            //    Console.Write("{0} ",ii);
            //Console.WriteLine();

            contatore++;
            x = v[fine];
            i = inizio - 1;
            for (j = inizio ; j <= fine - 1; j++)
                if (v[j] <= x)
                {
                    ++i;
                    y = v[i];
                    v[i] = v[j];
                    v[j] = y;
                }
            y = v[i+1];
            v[i+1] = v[fine];
            v[fine] = y;
            if (inizio < i)
                QuickSort1(v, inizio, i);
            if (i+2 < fine)
                QuickSort1(v, i + 2, fine);
        }

    }
}
