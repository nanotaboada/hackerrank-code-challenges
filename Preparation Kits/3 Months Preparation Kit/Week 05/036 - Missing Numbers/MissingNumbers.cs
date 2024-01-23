class Result
{
    public static List<int> missingNumbers(List<int> arr, List<int> brr)
    {
        foreach (var element in arr)
        {
            brr.Remove(element);
        }
        
        return brr
            // Only include a missing number once, even if it is missing
            // multiple times.
            .Distinct()
            // Return the missing numbers sorted ascending.
            .OrderBy(element => element)
            .ToList();
    }
}