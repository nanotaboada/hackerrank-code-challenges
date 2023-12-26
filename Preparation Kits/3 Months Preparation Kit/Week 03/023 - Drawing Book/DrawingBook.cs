class Result
{
    public static int pageCount(int n, int p)
    { 
        // 42
        var pages = n;
        
        // 11
        var target = p;
        
        /*  
            Forwards

            | |1| --> |2|3| --> |4|5| --> |6|7| --> |8|9| --> |10|11|
                   1         2         3         4         5

            11 / 2 = 5.5 (rounds to 6)
        */
        var forwardTurns = target / 2;
        
        /*
            Backwards

                |10|11| <-- |12|13| <-- |14|15| <-- |16|17| <-- |18|19|
                         16          15          14          13
            <-- |20|21| <-- |22|23| <-- |24|25| <-- |26|27| <-- |28|29|
             12          11          10          9           8
            <-- |30|31| <-- |32|33| <-- |34|35| <-- |36|37| <-- |38|39|
             7           6           5           4           3
            <-- |40|41| <-- |42|43|
             2           1      

            42 / 2 - 11 / 2 = 15.5 (rounds to 16)
        */
        var backwardTurns = pages / 2 - target / 2;
        
        return Convert.ToInt32(Math.Min(forwardTurns, backwardTurns));
    }

}

