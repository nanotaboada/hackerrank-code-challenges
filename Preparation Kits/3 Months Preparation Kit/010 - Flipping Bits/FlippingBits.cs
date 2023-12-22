class Result
{
    /*
     * Complete the 'flippingBits' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts LONG_INTEGER n as parameter.
     */

    public static long flippingBits(long n)
    {
        /*
            A 32-bit unsigned integer has a minimum value of 0 and a maximum
            value of 4,294,967,295 (inclusive).
        
            00000000000000000000000000000000 = 0 (minimum)
            00000000000000000000000000000001 = 1
            00000000000000000000000000000010 = 2
            00000000000000000000000000000011 = 3
            ... skipped ...
            11111111111111111111111111111111 = 4294967295 (maximum)
        */

        long maximum = (long)Math.Pow(2, 32) - 1;
        
        /*
            Subtracting any given number within the range to the maximum will 
            indeed produce the expected "flipping" of the bits, for example:

            11111111111111111111111111111111 = 4294967295
          - 00000000000000000000000000101010 = 42 (2^1 + 2^3 + 2^5)
            --------------------------------
            11111111111111111111111111010101 = 4294967253 (4294967295 - 42)
        */
    
        return maximum - n;
    }
}
