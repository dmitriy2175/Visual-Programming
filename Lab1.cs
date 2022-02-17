using System;
using System.Collections.Generic;
using System.Linq;



namespace lab1
{
    public class HW1
    {
        private static long  res = 0;
        public static long QueueTime(int[] customers, int n)
        {
            long[] cassa = new long[n];
            int p = 0;
            Array.Fill(cassa, 0);
            while (p<customers.Length)
            {
                for (int i = 0; i < cassa.Length; i++)
                {
                    if (cassa[i] == 0)
                    {
                        if (p >= customers.Length) break;
                            cassa[i] = customers[p];
                            p++;
                        }
                }
                cassa = CassaRefactor(cassa);
            }
            long max = 0;
            for (int i = 0; i<cassa.Length; i++)
            {
                if (cassa[i] > max) max = cassa[i];
            }
            res += max;

            return res;
        }
        private static long[] CassaRefactor(long[] cassa)
        {
            long min = cassa[0];
            for (int i = 0; i < cassa.Length; i++)
            {
                if (cassa[i] < min) min = cassa[i];
            }
            for (int i = 0; i < cassa.Length; i++)
            {
                cassa[i] -= min;
            }
            res += min;
            return cassa;
        }
    }

    public class Program
    {
        public static void Main()
        {
            int[] a = { 3,5,2,7,1,4,1};
            Console.WriteLine(HW1.QueueTime(a, 3));

        }
    }

}





