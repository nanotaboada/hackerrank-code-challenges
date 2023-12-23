class Result
{
    public static int lonelyinteger(List<int> integers)
    {
        var groups = integers.GroupBy(integer => integer);
        
        var unique = groups
            .Where(group => group.Count() == 1)
            .Select(element => element.Key)
            .Single();
            
        return unique;
    }

}
