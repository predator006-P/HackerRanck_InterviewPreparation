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

    // Complete the jumpingOnClouds function below.
    static int jumpingOnClouds(int[] c)
    {
        int No_of_Jumps = 0;
        if(c.Length == 2)
        {
            return 1;
        }
        for(int i =0; i < c.Length - 2; i++)
        {
            if(c[i+1] == 0 && c[i+2] == 0)
            {
                No_of_Jumps++;
                i++;
            }
            else if (c[i+1] == 0 && c[i + 2] == 1)
            {
                No_of_Jumps++;
            }
            else if (c[i] == 0 && c[i + 1] == 1)
            {
                No_of_Jumps++;
                i++;
            }
            else { }
            if((i+1) == c.Length - 2) No_of_Jumps++;
        }

        return No_of_Jumps;
    }

    static void Main(string[] args)
    {

        int n = Convert.ToInt32(Console.ReadLine());

        int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp));

        int result = jumpingOnClouds(c);
        Console.WriteLine(result);
    }
}