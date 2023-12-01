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

class Result
{
    public static List<int> matchingStrings(List<string> inputs, List<string> queries)
    {
        List<int> matchingStrings = new List<int>();
        
        foreach (string query in queries)
        {
            List<string> matches = inputs.Where(q => q == query).ToList();
            matchingStrings.Add(matches.Count);
        }
        
        return matchingStrings;
    }
    
}