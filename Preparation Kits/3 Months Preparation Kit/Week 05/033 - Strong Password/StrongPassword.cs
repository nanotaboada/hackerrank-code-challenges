class Result
{
    public static int minimumNumber(int n, string password)
    {
        var missing = 0;

        // It contains at least one digit.
        if (!Regex.IsMatch(password, @"\d"))
        {
            missing++;
        }
        // It contains at least one lowercase English character.
        if (!Regex.IsMatch(password, @"[a-z]"))
        {
            missing++;
        }
        // It contains at least one uppercase English character.
        if (!Regex.IsMatch(password, @"[A-Z]"))
        {
            missing++;
        }
        // It contains at least one special character. 
        if (!Regex.IsMatch(password, @"[\W]"))
        {
            missing++;
        }
        // Its length is at least 6.
        if (n < 6 && (6 - n) > missing)
        {
            return 6 - n;
        }
        else
        {
            return missing;
        }
    }
}