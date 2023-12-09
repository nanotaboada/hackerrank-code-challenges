using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /*
            Enter your code here. Read input from STDIN. Print output to STDOUT.
            Your class should be named Solution
        */
        
        var fine = 0;
        
        var first = Console.ReadLine();
        var second = Console.ReadLine();
        
        var returned = first.Split(' ');
        var due = second.Split(' ');
        
        var returnedDate = new DateTime(
            Convert.ToInt32(returned[2]),  // year
            Convert.ToInt32(returned[1]),  // month
            Convert.ToInt32(returned[0]),  // day
            0,0,0, DateTimeKind.Utc
        );

        var dueDate = new DateTime(
            Convert.ToInt32(due[2]),  // year
            Convert.ToInt32(due[1]),  // month
            Convert.ToInt32(due[0]),  // day
            0,0,0, DateTimeKind.Utc
        );

        var timespan = returnedDate - dueDate;

        // returned on or before the expected return date, no fine will be charged
        if (returnedDate <= dueDate)
        {
            fine = 0;
        }
        // returned after the expected return day but still within the same
        // calendar month and year as the expected return date
        else if (returnedDate.Month == dueDate.Month
                && returnedDate.Year == dueDate.Year)
        {
            fine = 15 * timespan.Days;
        }
        // returned after the expected return month but still within the same
        // calendar year as the expected return date
        else if (returnedDate.Year == dueDate.Year)
        {
            fine = 500 * (returnedDate.Month - dueDate.Month);
        }
        // returned after the calendar year in which it was expected
        else if (returnedDate.Year > dueDate.Year)
        {
            fine = 10000;
        }

        Console.WriteLine(fine.ToString());
    }
}