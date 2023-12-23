class Result
{
    public static List<int> breakingRecords(List<int> scores)
    {
        var minimum = scores[0];
        var maximum = scores[0];
        var brokeMostPointsRecord = 0;
        var brokeLeastPointsRecord = 0;
        
        foreach (var score in scores)
        {
            if (score > maximum)
            {
                maximum = score;
                brokeMostPointsRecord++;
            }
            if (score < minimum)
            {
                minimum = score;
                brokeLeastPointsRecord++;
            }
        }

        return new List<int>() { brokeMostPointsRecord, brokeLeastPointsRecord };
    }
}
