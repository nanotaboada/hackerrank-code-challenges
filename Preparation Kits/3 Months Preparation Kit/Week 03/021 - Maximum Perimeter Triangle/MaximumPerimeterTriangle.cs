class Result
{
    public static List<int> maximumPerimeterTriangle(List<int> sticks)
    {
        // Sort the array in descending order
        var sorted = sticks
            .OrderByDescending(stick => stick)
            .ToList();
        
        for (var i = 0; i < sorted.Count - 2; i++)
        {
            var a = sorted[i];
            var b = sorted[i + 1];
            var c = sorted[i + 2];

            // Check if the three longest sticks can form a non-degenerate
            // triangle
            if (IsNonDegenerateTriangle(a, b, c))
            {
                // Return the triangle sides in non-decreasing order
                return new List<int> { c, b, a };
            }
        }
        
        // If no non-degenerate triangle is found, return [-1]
        return new List<int> { -1 };
    }
    
    static bool IsNonDegenerateTriangle(int a, int b, int c)
    {
        // In a non-degenerate triangle, the sum of the lengths of any two sides
        // must be greater than the length of the third side
        return a + b > c
            && a + c > b
            && b + c > a;
    }
}
