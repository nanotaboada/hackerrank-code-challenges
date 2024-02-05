class Result
{
    public static string gamingArray(List<int> arr)
    {
        var turns = 0;
        var max = int.MinValue;

        foreach (var number in arr)
        {
            if (number > max)
            {
                max = number;
                turns++;
            }
        }
        
        return (turns % 2 != 0) ? "BOB" : "ANDY";
    }
}
