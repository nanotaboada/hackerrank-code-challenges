using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        
        int inputs = Int32.Parse(Console.ReadLine());
        var phonebook = new Dictionary<string, string>();
        
        for (int i = 0; i < inputs; i++)
        {
            var friend = Console.ReadLine().Split(" ");
            phonebook.Add(friend[0], friend[1]);
        }
        
        var name = String.Empty;
        
        while ((name = Console.ReadLine()) != null)
        {
            if (phonebook.ContainsKey(name))
            {
                Console.WriteLine(name + "=" + phonebook[name]);
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }
        
    }
}
