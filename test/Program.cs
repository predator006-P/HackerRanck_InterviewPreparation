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

    // Complete the countingValleys function below.
    static int countingValleys(string s)
    {
        int No_of_Valleys = 0;
        int level = 0;
        int marker = 0;

        foreach (char c in s)
        {
            if (c == 'U')
            {
                level++;
            }
            else if (c == 'D')
            {
                level--;
            }
            else 
            {
                Console.WriteLine("Wrong sequence has been added.");
                break;
            }
            if ((level < 0) && (marker == 0))
            {
                No_of_Valleys++;
                if (marker == 0) marker = 1;
            }
            else if (level == 0)
            {
                marker = 0;
            }
            //Console.WriteLine("level: " + level);
            //Console.WriteLine("marker: " + marker);
        }

        //Console.WriteLine("level: " + level);
        //Console.WriteLine("No. of valleys: " + No_of_Valleys);
        return No_of_Valleys;
    }

    static void Main(string[] args)
    {

        int n = Convert.ToInt32(Console.ReadLine());

        string s = Console.ReadLine();

        int result = countingValleys(s);
        Console.WriteLine(result);
    }
}