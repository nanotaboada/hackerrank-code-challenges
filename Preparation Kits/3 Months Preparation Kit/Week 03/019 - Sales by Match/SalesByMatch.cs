class Result
{

    /*
     * Complete the 'sockMerchant' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER_ARRAY ar
     */

    public static int sockMerchant(int n, List<int> ar)
    {
        var socksByColor = ar.GroupBy(color => color);
        var pairsByColor = socksByColor.Select(socks => socks.Count() / 2);
        
        return pairsByColor.Sum();
    }

}
