class Result
{
    public static int SuperDigit(string n, int k)
    {
        var superDigit = 0;

        var p = new StringBuilder();
        p.Insert(0, n, k);

        var digits = GetDigits(p.ToString());
        superDigit = digits.Sum();

        while(superDigit >= 10)
        {
            digits = GetDigits(superDigit.ToString());
            superDigit = digits.Sum();
        }

        return superDigit;
    }

    public static int[] GetDigits(string number)
    {
        return number
            .Select(character => (int)char.GetNumericValue(character))
            .ToArray();
    }
}