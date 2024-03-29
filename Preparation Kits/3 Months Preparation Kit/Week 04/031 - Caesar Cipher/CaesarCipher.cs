class Result
{
    // https://en.wikipedia.org/wiki/Caesar_cipher
    
    public static string caesarCipher(string s, int k)
    {
        var plaintext = s;
        var ciphertext = new StringBuilder(plaintext.Length);
        var shift = k;

        foreach (var character in plaintext)
        {
            char substitute;

            if (character >= 'a' && character <= 'z')
            {
                substitute = (char)((character - 'a' + shift) % 26 + 'a');
            }
            else if (character >= 'A' && character <= 'Z')
            {
                substitute = (char)((character - 'A' + shift) % 26 + 'A');
            }
            else
            {
                substitute = character;
            }

            ciphertext.Append(substitute);
        }

        return ciphertext.ToString();
    }

}

