class Result
{
    public static int superDigit(string n, int k)
    {
        long superDigit = 0;
        
        foreach (var character in n)
        {
            superDigit += character - '0';
        }
        
        superDigit *= k;
        
        while (superDigit >= 10)
        {
            long sum = 0;
            
            while (superDigit > 0)
            {
                sum += superDigit % 10;
                superDigit /= 10;
            }

            superDigit = sum;
        }
        
        return (int)superDigit;
    }
}
