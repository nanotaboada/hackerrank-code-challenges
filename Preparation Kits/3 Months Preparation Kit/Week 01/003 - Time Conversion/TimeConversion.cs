class Result
{
    public static string timeConversion(string time)
    {
        DateTime military = DateTime.ParseExact(time, "hh:mm:sstt", CultureInfo.InvariantCulture);
        
        return military.ToLongTimeString();
    }

}
