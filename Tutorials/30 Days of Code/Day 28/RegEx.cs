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
        // https://regex-generator.olafneumann.org/?sampleText=sample%40gmail.com&flags=Li&selection=0%7CMultiple%20characters
        var pattern = "[a-z]+@gmail\\.com";
        var regex = new Regex(pattern, RegexOptions.IgnoreCase);
        
        var names = new List<string>();
        int N = Convert.ToInt32(Console.ReadLine().Trim());

        for (int NItr = 0; NItr < N; NItr++)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
            string firstName = firstMultipleInput[0];
            string emailID = firstMultipleInput[1];
            
            if (regex.IsMatch(emailID))
            {
                names.Add(firstName);
            }
        }
        
        names.Sort();
        names.ForEach(name => Console.WriteLine(name));
    }
}
