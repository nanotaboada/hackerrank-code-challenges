class Result
{
    public static int minimumAbsoluteDifference(List<int> arr)
    {
        // When the array is sorted, the minimum absolute difference between any
        // two elements will be found between consecutive elements.
        arr.Sort();

        return arr
            .Zip(arr.Skip(1), (a, b) => Math.Abs(b - a))
            .Min();
    }
}
