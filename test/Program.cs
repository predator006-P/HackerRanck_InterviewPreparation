using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
using test;

class Solution
{

    // Complete the sockMerchant function below.
    static int SockMerchant(int n, int[] ar)
    {
        int[] t_ar = ar;
        int pair_no = 0;
        int t_pair_no = 1;
        int tmp;


        /* Tömb rendezés */

        //Array.Sort(t_ar);

        t_ar = SortClass.QuickSort(ar, n);


        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(t_ar[i]);
        }

        tmp = t_ar[0];
        for (int i = 0; i < (n - 1); i++)
        {

            if (t_ar[i + 1] == tmp)
            {
                t_pair_no++;
            }
            else
            {
                pair_no += (t_pair_no / 2);
                t_pair_no = 1;
                tmp = t_ar[i + 1];
            }
        }
        pair_no += (t_pair_no / 2);
        return pair_no;
    }

    static void Main(string[] args)
    {
        int a = 1 / 2;
        Console.WriteLine($"a={a}");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
        
        int result = SockMerchant(n, ar);

        Console.WriteLine();
        Console.WriteLine(result);

   
    }
}