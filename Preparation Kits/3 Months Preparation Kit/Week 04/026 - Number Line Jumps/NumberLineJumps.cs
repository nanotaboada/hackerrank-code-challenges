/*
    x1 = 0, v1 = 3, x2 = 4, v2 = 2

                  v1
            /------------\ /------------\ /------------\ /------------\
    x1 ----|----|----|----|----|----|----|----|----|----|----|----|----|----|----
            0    1    2    3    4    5    6    7    8    9    10   11   12   13

                                   v2
                                /-------\ /-------\ /-------\ /-------\
    x2 ----|----|----|----|----|----|----|----|----|----|----|----|----|----|----
            0    1    2    3    4    5    6    7    8    9    10   11   12   13

    distance = speed * time
    
    x1 + (v1 * t) = x2 + (v2 * t)
          x2 - x1 = (v1 - v2) * t
                t = (x2 - x1) / (v1 - v2)
    
    Then (x2 - x1) % (v1 - v2) should be 0

    Because by constraint x1 < x2, then v1 >= v2 to at least have the chance
    of crossing.
*/

class Result
{
    public static string kangaroo(int x1, int v1, int x2, int v2)
    {
        if (v1 <= v2)
        {
            return "NO";
        }

        if ((x2 - x1) % (v1 - v2) == 0)
        {
            return "YES";
        }
        else
        {
            return "NO";
        }
    }
}