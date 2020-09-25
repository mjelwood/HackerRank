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

    //Notes:
    // Best to start loop at 1
    // To right align one way is create string of empty space based on passed in value
    // C# has String which an override allows for duplicating a character n times

    // Complete the staircase function below.
    static void staircase(int n)
    {

        for (int i = 1; i <= n; i++)
        {
            String space = new String(' ', n - i);
            String s = new String('#', i);

            Console.WriteLine(space + s);
        }
    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        staircase(n);
    }
}
