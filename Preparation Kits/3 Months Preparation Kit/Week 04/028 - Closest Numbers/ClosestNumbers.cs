class Result
{
    public static List<int> closestNumbers(List<int> arr)
    {
        // When the array is sorted, the minimum absolute difference between any
        // two elements will be found between consecutive elements.
        arr.Sort();

        var min = arr
            .Zip(arr.Skip(1), (a, b) => Math.Abs(b - a))
            .Min();

        return arr
            .Zip(arr.Skip(1), (a, b) => new { left = a, right = b })
            .Where(pair => Math.Abs(pair.left - pair.right) == min)
            .SelectMany(pair => new List<int> { pair.left, pair.right })
            .ToList();
    }
}
