class Result
{
    public static void plusMinus(List<int> integers)
    {
        int elements = integers.Count;
        double positives = 0, negatives = 0, zeros = 0;
        
        foreach (int integer in integers)
        {
            if (integer < 0)
            {
                negatives++;
            }
            else if (integer > 0)
            {
                positives++;
            }
            else
            {
                zeros++;
            }
        }
        
        Console.WriteLine("{0:N6}", positives / elements);
        Console.WriteLine("{0:N6}", negatives / elements);
        Console.WriteLine("{0:N6}", zeros / elements);
    }

}
