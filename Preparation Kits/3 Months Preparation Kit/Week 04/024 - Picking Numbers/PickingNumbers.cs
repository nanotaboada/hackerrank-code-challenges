class Result
{
    public static int pickingNumbers(List<int> a)
    {
        // [ 1, 1, 2, 2, 4, 4, 5, 5, 5 ]

        var longest = 0;
                
        // Dictionary to store the frequencies of each number
        var frequencies = new Dictionary<int, int>();
        
        // Populate frequencies with the number as the Key and the count of
        // occurrences or frequency as the Value
        foreach (var number in a)
        {
            if (frequencies.ContainsKey(number))
            {
                frequencies[number]++;
            }
            else
            {
                frequencies[number] = 1;
            }
        }

        /*
            ---------------
            | Key | Value |
            ---------------
            |  1  |   2   |
            |  2  |   2   |
            |  4  |   2   |
            |  5  |   3   |
            ---------------
        */

        // Iterate through the numbers
        foreach (var number in frequencies.Keys) // 1
        {
            // Get the frequency of the current number
            var frequency = frequencies[number]; // 2

            // Get the frequency of the next number (if it exists)
            var nextFrequency = frequencies.ContainsKey(number + 1) // 2
                ? frequencies[number + 1]
                : 0;

            // Calculate the length by adding the current and next frequency
            var length = frequency + nextFrequency; // 2 + 2 = 4

            // Update the maximum subsequence length
            longest = Math.Max(longest, length); // 4
        }
        
        return longest;
    }
}

