class Result
{
    public static int sansaXor(List<int> arr)
    {
        var elements = arr.Count;

        if (elements % 2 == 0)
        {
            // If the number of elements is even,
            // XOR of all elements is 0.
            return 0;
        }
        else
        {
            var result = 0;

            // Iterate through the array by skipping every second element
            for (int index = 0; index < elements; index += 2)
            {
                // XOR the current element with the result
                result ^= arr[index];
            }

            // Return the final XOR result
            return result;
        }
    }
}
