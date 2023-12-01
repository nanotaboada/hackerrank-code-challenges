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
    public static List<int> countingSort(List<int> integers)
    {
        int[] frequency = new int[100];
        Array.Fill(frequency, 0);

        for (int i = 0; i < integers.Count; i++)
        {
            frequency[integers[i]]++;
        }

        return frequency.ToList();
    }

}
