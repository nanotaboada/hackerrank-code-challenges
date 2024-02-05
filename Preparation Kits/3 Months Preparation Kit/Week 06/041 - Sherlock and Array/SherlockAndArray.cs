class Result
{
    public static string balancedSums(List<int> arr)
    {   
        var left = 0;
        var right = arr.Sum();

        foreach(var number in arr)
        {
            right -= number;

            if (left == right)
            {
                return "YES";
            }

            left += number;
        }

        return "NO";
    }
}
