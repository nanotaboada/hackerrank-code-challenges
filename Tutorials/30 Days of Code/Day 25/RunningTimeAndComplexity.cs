using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        var T = int.Parse(Console.ReadLine());
        
        for(var i = 0; i < T; i++)
        {
            var n = int.Parse(Console.ReadLine());
            
            if(IsPrime(n))
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not prime");
            }
        }
    }
    
    /*
        The time complexity of the algorithm is O(Sqrt(n)).
        
        1. The loop runs from i = 2 to i = Sqrt(n)
        2. The loop increments i by 1 in each iteration.
        
        In the worst case, the loop will run for Sqrt(n) iterations, and each
        iteration involves a constant amount of work. Therefore, the time
        complexity of the algorithm is proportional to the square root of the
        input number n, resulting in O(Sqrt(n)) time complexity. This makes the
        algorithm more efficient than a naive approach with O(n) time complexity,
        where you would check divisibility up to n-1.
    */
    static bool IsPrime(int n)
    {
        if (n <= 1) return false;

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0) return false;
        }

        return true;
    }
}