class Result
{
    public static int migratoryBirds(List<int> arr)
    {
        return arr
            .GroupBy(bird => bird)
            .OrderByDescending(group => group.Count())
            .ThenBy(group => group.Key)
            .First()
            .Key;
    }
}
