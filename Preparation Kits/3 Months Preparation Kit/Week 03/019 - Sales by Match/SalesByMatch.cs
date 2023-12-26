class Result
{
    public static int sockMerchant(int n, List<int> ar)
    {
        var socksByColor = ar.GroupBy(color => color);
        var pairsByColor = socksByColor.Select(socks => socks.Count() / 2);
        
        return pairsByColor.Sum();
    }

}
