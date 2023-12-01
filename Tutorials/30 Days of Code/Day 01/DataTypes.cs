using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

        
        // Declare second integer, double, and String variables.
        int foo = 0;
        double bar = 0;
        string baz = String.Empty;
        
        // Read and save an integer, double, and String to your variables.
        foo = Convert.ToInt32(Console.ReadLine());
        bar = Convert.ToDouble(Console.ReadLine());
        baz = Console.ReadLine();
        
        // Print the sum of both integer variables on a new line.
        Console.WriteLine(i + foo);
        
        // Print the sum of the double variables on a new line.
        Console.WriteLine("{0:N1}", d + bar);
        
        // Concatenate and print the String variables on a new line
        // The 's' variable above should be printed first.
        Console.WriteLine(s + baz);

    }
}