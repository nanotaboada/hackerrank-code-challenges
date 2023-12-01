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
        // Constraints
        // 6 x 6
        // -9 <= matrix[i][j] <= 9
        // -9 <= i,j <= 5
                
        List<List<int>> matrix = new List<List<int>>();

        for (int i = 0; i < 6; i++)
        {
            matrix.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }
        
        int rows = matrix.Count;
        int columns = matrix[0].Count;

        // Initialize with the minimum possible sum, which is
        // elements in an hourglass (7), times the lowest boundary (-9)
        int maximumSum = -9 * 7;
        
        /*  j
          i X X X    X X X
            0 X 0    0 X 0
            X X X    X X X

            X X X    X X X
            0 X 0    0 X 0
            X X X    X X X
        */
        
        // matrix[4][4] is the initial coordinate of the last (4th) hourglass
        // rows-2 and columns-2
        for (int i = 0; i < rows-2; i++)
        {
            for (int j = 0; j < columns-2; j++)
            {
                int sum = matrix[i][j] + matrix[i][j+1] + matrix[i][j+2]
                        + matrix[i+1][j+1]
                        + matrix[i+2][j] + matrix[i+2][j+1] + matrix[i+2][j+2];
                
                maximumSum = Math.Max(sum, maximumSum);
            }
        }
        
        Console.WriteLine(maximumSum);
    }
}
