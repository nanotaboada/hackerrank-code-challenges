class Result
{
    public static int maxMin(int k, List<int> arr)
    {
        arr.Sort();
        var minUnfairness = int.MaxValue;

        for (var i = 0; i <= arr.Count - k; i++)
        {
            var unfairness = arr[i + k - 1] - arr[i];
            minUnfairness = Math.Min(minUnfairness, unfairness);
        }

        return minUnfairness;
    }
}
