using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class Solution
{
    static void Main(String[] args)
    {
        /* 
            Enter your code here. Read input from STDIN. Print output to STDOUT.
            Your class should be named Solution 
        */

        var input = true;
        var line = string.Empty;
        var output = string.Empty;

        while (input)
        {
            line = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(line))
            {
                input = false;
            }
            else
            {
                var operation = line.Split(";")[0];
                var type = line.Split(";")[1];
                var name = line.Split(";")[2];
                
                if (operation == "S")
                {
                    output = SplitAndLowercase(type, name);
                    Console.WriteLine(output);
                }
                
                if (operation == "C")
                {
                    output = CombineAndCamelCase(type, name);
                    Console.WriteLine(output);
                }
            }
        }
    }
    
    static string SplitAndLowercase(string type, string name)
    {
        var typeName = new StringBuilder();

        var splitted = name.Select(character => char.IsUpper(character)
            ? " " + char.ToLower(character)
            : character.ToString());

        if (type == "M")
        {
            var method = string.Concat(splitted).Replace("()", "").Trim();
            typeName.Append(method);
        }
        else
        {
            typeName.Append(string.Concat(splitted).Trim());
        }

        return typeName.ToString();
    }
    
    static string CombineAndCamelCase(string type, string name)
    {
        var typeName = new StringBuilder();

        var combined = name.Split(" ")
            .Select(word => char.ToUpper(word.First())+ word[1..]);

        if (type == "M")
        {
            typeName.Append(char.ToLower(string.Concat(combined)[0]));
            typeName.Append(string.Concat(combined)[1..]);
            typeName.Append("()");
        }

        if (type == "C")
        {
            typeName.Append(string.Concat(combined));
        }

        if (type == "V")
        {
            typeName.Append(char.ToLower(string.Concat(combined)[0]));
            typeName.Append(string.Concat(combined)[1..]);
        }

        return typeName.ToString();
    }
}
