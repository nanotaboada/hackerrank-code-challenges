class Result
{
    public static int marsExploration(string s)
    {
        var received = s;
        var expected = string.Concat(Enumerable.Repeat("SOS", received.Length / 3));
        
        return received
            .Zip(expected, (charReceived, charExpected) => charReceived != charExpected ? 1 : 0)
            .Sum();
    }
}
