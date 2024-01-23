class Result
{
    public static string gridChallenge(List<string> grid)
    {
        var rows = grid.Count;
        var columns = grid[0].Length;

        grid = grid
            .Select(row => new string(row.OrderBy(c => c).ToArray()))
            .ToList();

        for (var column = 0; column < columns; column++)
        {
            for (var row = 1; row < rows; row++)
            {
                if (grid[row][column] < grid[row - 1][column])
                {
                    return "NO";
                }
            }
        }
        return "YES";
    }
}
