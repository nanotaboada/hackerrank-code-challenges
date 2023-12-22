class Result
{
    public static List<int> countingSort(List<int> integers)
    {
        int[] frequency = new int[100];
        Array.Fill(frequency, 0);

        for (int i = 0; i < integers.Count; i++)
        {
            frequency[integers[i]]++;
        }

        return frequency.ToList();
    }

}
