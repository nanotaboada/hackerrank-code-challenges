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
    In mathematics, a square matrix is a matrix with the same number of
    rows and columns.

    For example, consider the following 3-by-3 matrix: 

    Rows &         Principal      Secondary      Example
    Columns        Diagonal       Diagonal       with values
    -----------    -----------    -----------    -----------
    M00 M01 M02    XXX OOO OOO    OOO OOO XXX     1   2   3
    M10 M11 M12    OOO XXX OOO    OOO XXX OOO     4   5   6
    M20 M21 M22    OOO OOO XXX    XXX OOO OOO     7   8   9

    The primary diagonal is formed by the elements M00, M11 and M22.
    The condition is row = column.
    
    In this example:
    [0,0] = 1
    [1,1] = 5
    [2,2] = 9

    The secondary diagonal is formed by the elements M02, M11 and M20.
    The condition is row = numberOfRows - column - 1
    
    In this example:
    [0, 3-0-1] or [0, 2] = 3
    [1, 3-1-1] or [1, 1] = 5
    [2, 3-2-1] or [3, 0] = 7

*/

class Result
{
    public static int diagonalDifference(List<List<int>> matrix)
    {
        List<int> principalDiagonal = new List<int>();
        for (int i = 0; i < matrix.Count; i++)
        {
            principalDiagonal.Add(matrix[i][i]);
        }

        List<int> secondaryDiagonal = new List<int>();
        for (int i = 0; i < matrix.Count; i++)
        {
            secondaryDiagonal.Add(matrix[i][matrix.Count - i - 1]);
        }

        int absoluteDifference = Math.Abs(principalDiagonal.Sum() - secondaryDiagonal.Sum());
        
        return absoluteDifference;
    }

}

