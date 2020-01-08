using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    class SortClass
    {
        internal static int[] QuickSort(int [] t_ar,int n)
        {
            int tmp;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < (n - i - 1); j++)
                {
                    if (t_ar[j + 1] < t_ar[j])
                    {
                        tmp = t_ar[j];
                        t_ar[j] = t_ar[j + 1];
                        t_ar[j + 1] = tmp;
                    }
                }
            }
            return t_ar;
        }
    }
}
