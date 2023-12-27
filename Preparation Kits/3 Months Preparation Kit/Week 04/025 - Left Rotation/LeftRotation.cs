class Result
{
    public static List<int> rotateLeft(int d, List<int> arr)
    {
        return arr
            .Skip(d)
            .Concat(arr.Take(d))
            .ToList();
    }
}