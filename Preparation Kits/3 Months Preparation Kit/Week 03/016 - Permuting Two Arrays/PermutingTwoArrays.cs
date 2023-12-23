class Result
{
    public static string twoArrays(int k, List<int> A, List<int> B)
    {
        A.Sort();
        B.Sort();
        B.Reverse();
        
        for (int i = 0; i <= A.Count-1; i++)
        {
            bool relation = A[i] + B[i] >= k;
            
            if (!relation)
            {
                return "NO";
            }
        }
        
        return "YES";
    }
}