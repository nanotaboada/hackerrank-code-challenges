/*
    ---------------------------------
    | steps | direction | sea level |
    ---------------------------------
    |   1   |     D     |    -1     |
    |   2   |     D     |    -2     |
    |   3   |     U     |    -1     |
    |   4   |     U     |     0     |
    |   5   |     D     |    -1     |
    |   6   |     D     |    -2     |
    |   7   |     U     |    -1     |
    |   8   |     D     |    -2     |
    |   9   |     U     |    -1     |
    |   10  |     U     |     0     |
    |   11  |     U     |     1     |
    |   12  |     U     |     2     |
    ---------------------------------

     sea level    
     4 |    
     3 |
     2 |                                                           U
     1 |                                                      U
     0 X----|----|----|----U----|----|----|----|----|----U----|----|---- steps
    -1 |    D         U __/     D         U         U __/
    -2 |         D        !          D         D        !
    -3 |
    -4 |
    
       ! The hiker is leaving one valley

*/

class Result
{
    public static int countingValleys(int steps, string path)
    {
        var altitude = 0;
        var valleys = 0;
        var directions = path.ToCharArray();

        for (var step = 0; step < steps; step++)
        {
            // If the direction is Uphill
            if (directions[step] == 'U')
            {
                // and the altitude is -1
                if (altitude == -1)
                {
                    // then the hiker is leaving one valley
                    valleys++;
                }

                altitude++;
            }

            if (directions[step] == 'D')
            {
                altitude--;
            }
        }

        return valleys;
    }
}
