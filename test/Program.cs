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

class Solution
{

    // Complete the repeatedString function below.
    static long repeatedString(string s, long n)
    {
        //string new_s = "";
        long No_of_a = 0;

        //if (n == s.Length)
        //{
        //    new_s = s;
        //}
        //else if (n < s.Length)
        //{
        //    for (int i = 0; i < n; i++)
        //    {
        //        new_s = new_s + s[i].ToString();
        //    }
        //}
        //else 
        //{
        //    for (int i = 0; i < n; i++)
        //    {
        //        new_s = new_s + s[i % s.Length].ToString();
        //    }
        //}

        //for (int i = 0; i < new_s.Length; i++)
        //{
        //    if(new_s[i] == 'a')
        //    {
        //        No_of_a++;
        //    }
        //}

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == 'a')
            {
                No_of_a++;
            }
        }

        No_of_a = (n / s.Length * No_of_a);

        for (int i = 0; i < (n % s.Length); i++)
        {
            if (s[i] == 'a')
            {
                No_of_a++;
            }
        }

        return No_of_a;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(0 % 4);

        string s = Console.ReadLine();

        long n = Convert.ToInt64(Console.ReadLine());

        long result = repeatedString(s, n);

        Console.WriteLine(result);

    }
}