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
    public static string twoArrays(int k, List<int> A, List<int> B)
    {
        A.Sort();
        B.Sort();
        B.Reverse();
        
        for (int i = 0; i <= A.Count-1; i++)
        {
            bool relation = A[i] + B[i] >= k;
            
            if (!relation)
            {
                return "NO";
            }
        }
        
        return "YES";
    }
}