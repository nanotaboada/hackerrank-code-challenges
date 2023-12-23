class Result
{
    public static List<int> matchingStrings(List<string> inputs, List<string> queries)
    {
        List<int> matchingStrings = new List<int>();
        
        foreach (string query in queries)
        {
            List<string> matches = inputs.Where(q => q == query).ToList();
            matchingStrings.Add(matches.Count);
        }
        
        return matchingStrings;
    }
    
}
