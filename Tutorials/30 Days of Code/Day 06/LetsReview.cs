using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class Solution {
    static void Main(String[] args)
    {    
        int lines = Convert.ToInt32(Console.ReadLine());
        
        for (int i = 0; i < lines; i++)
        {
            string input = Console.ReadLine();
            char[] characters = input.ToCharArray();
            StringBuilder even = new StringBuilder();
            StringBuilder odd = new StringBuilder();
            
            for (int j = 0; j < characters.Length; j++)
            {
                // even
                if (j % 2 == 0)
                {
                    even.Append(characters[j]);
                }
                // odd
                else
                {
                    odd.Append(characters[j]);
                }
            }
            
            Console.WriteLine("{0} {1}", even.ToString(), odd.ToString());
        }
    }
}
