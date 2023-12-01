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
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        int count = 0;
        string binary = Convert.ToString(n, 2);
        var groups = binary.Split("0");

        foreach (var group in groups)
        {
            if (group.Count() > count)
            {
                count = group.Count();
            }
        }
        
        Console.WriteLine(count);
    }
}
