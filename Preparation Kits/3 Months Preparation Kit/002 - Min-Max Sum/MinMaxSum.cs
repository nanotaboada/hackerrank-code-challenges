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
    public static void miniMaxSum(List<int> integers)
    {
        double minimum = 0;
        double maximum = 0;
        
        List<int> minimums = integers.OrderBy(integer => integer).Take(4).ToList();
        List<int> maximums = integers.OrderByDescending(integer => integer).Take(4).ToList();
        
        minimums.ForEach(min => minimum = minimum + min);
        maximums.ForEach(max => maximum = maximum + max);
        
        Console.WriteLine("{0} {1}", minimum.ToString(), maximum.ToString());
    }

}
