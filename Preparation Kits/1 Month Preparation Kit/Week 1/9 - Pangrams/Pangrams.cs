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
    public static string pangrams(string sentence)
    {
        var alphabet = new List<char>();
        alphabet.AddRange("abcdefghijklmnopqrstuvwxyz");

        var characters = sentence
            .ToLower()
            .Where(character => !char.IsWhiteSpace(character))
            .Distinct()
            .ToList();

        var difference = alphabet
            .Except(characters);
            
        if (difference.Any())
        {
            return "not pangram";
        }
        else
        {
            return "pangram";
        }
    }
}
