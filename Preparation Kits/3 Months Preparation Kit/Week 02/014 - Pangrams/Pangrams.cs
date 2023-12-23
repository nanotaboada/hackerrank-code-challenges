class Result
{
    public static string pangrams(string sentence)
    {
        var alphabet = new List<char>();
        alphabet.AddRange("abcdefghijklmnopqrstuvwxyz");

        var characters = sentence
            .ToLower()
            .Where(character => !char.IsWhiteSpace(character))
            .Distinct()
            .ToList();

        var difference = alphabet
            .Except(characters);
            
        if (difference.Any())
        {
            return "not pangram";
        }
        else
        {
            return "pangram";
        }
    }
}
