class Result
{
    public static List<int> gradingStudents(List<int> grades)
    {
        var grading = new List<int>();

        foreach (var grade in grades)
        {
            if (grade < 38 || grade % 5 < 3)
            {
                // no rounding
                grading.Add(grade);
            }
            else
            {
                var rounded = grade + (5 - grade % 5);
                grading.Add(rounded);
            }
        }

        return grading;
    }
}
