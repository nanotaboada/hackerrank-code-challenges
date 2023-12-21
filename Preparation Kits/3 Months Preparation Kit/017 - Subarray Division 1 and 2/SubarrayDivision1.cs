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

/*
    Example

    s = [ 2, 2, 1, 3, 2 ]
    d = 4
    m = 2

        0                            1                            2                            3
    |-- i --|                    |-- i --|                    |-- i --|                    |-- i --|
    ---------------------    ---------------------    ---------------------    ---------------------
    | 2 | 2 | 1 | 3 | 2 |    | 2 | 2 | 1 | 3 | 2 |    | 2 | 2 | 1 | 3 | 2 |    | 2 | 2 | 1 | 3 | 2 |
    ---------------------    ---------------------    ---------------------    ---------------------
    | j | j |                    | j | j |                    | j | j |                    | j | j |
      0   1                        1   2                        2   3                        3   4  

    Constraints

    1 <= n <= 100
    1 <= s[i] <= 5, where (0 <= 1 < n)
    1 <= d <= 31
    1 <= m <= 12
*/

class Result
{
    public static int birthday(List<int> s, int d, int m)
    {
        int ways = 0;
        
        // loop through contiguous segments (i + m)
        for (int i = 0; i <= s.Count - m; i++)
        {
            int sum = 0;
            
            // loop within each segment (m times)
            for (int j = i; j < i + m; j++)
            {
                sum += s[j];
            }

            if (sum == d)
            {
                ways++;
            }
        }
        
        return ways;
    }

}
