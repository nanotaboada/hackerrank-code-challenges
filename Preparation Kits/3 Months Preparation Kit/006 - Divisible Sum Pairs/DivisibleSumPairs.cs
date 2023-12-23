class Result
{
    public static int divisibleSumPairs(int n, int k, List<int> ar)
    {
        var count = 0;

        for (var i = 0; i < n; i++)
        {
            // j = i + 1 satisfies i < j
            for (var j = i + 1; j < n; j++)
            {
                if ((ar[i] + ar[j]) % k == 0)
                {
                    count++;
                }
            }
        }

        return count;
    }
}
