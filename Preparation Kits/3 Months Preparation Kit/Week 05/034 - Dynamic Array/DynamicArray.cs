class Result
{
    public static List<int> dynamicArray(int n, List<List<int>> queries)
    {
        var arr = new List<int>[n];
        var answers = new List<int>();
        var lastAnswer = 0;
        
        for (var i = 0; i < n; i++)
        {
            arr[i] = new List<int>();
        }
        
        foreach (List<int> query in queries)
        {
            var queryType = query[0];
            var x = query[1];
            var y = query[2];
            var idx = (x ^ lastAnswer) % n;

            switch (queryType)
            {
                case 1:
                    arr[idx].Add(y);
                    break;

                case 2:
                    lastAnswer = arr[idx][y % arr[idx].Count];
                    answers.Add(lastAnswer);
                    break;
            }
        }

        return answers;
    }
}