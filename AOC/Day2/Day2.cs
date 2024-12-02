namespace Day1;

public class Day2
{
    public int CountSafe(string input)
    {
        var reports = GetReports(input);

        return reports.Count(IsSafe);
    }

    private bool IsSafe(IReadOnlyCollection<int> report)
    {
        var isAscending = report.ElementAt(1) > report.ElementAt(0);
        return report.All((x, y) => isAscending ? y > x && y <= x + 3 : y < x && y >= x - 3);
    }

    private static IEnumerable<IReadOnlyCollection<int>> GetReports(string input)
    {
        return input.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
            .Select(x => x.Split(' '))
            .Select(x => x.Select(int.Parse).ToArray());
    }
}