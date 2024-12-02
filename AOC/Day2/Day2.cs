using Day1;

namespace Day2;

public class Day2
{
    public int CountSafe(string input)
    {
        return GetReports(input)
            .Count(IsSafe);
    }
    
    public int CountSafeWithDampener(string input)
    {
        return GetReports(input)
            .Count(IsSafeWithDampener);
    }
    
    private bool IsSafeWithDampener(IReadOnlyCollection<int> report)
    {
        var safeCountThreshold = report.Count;
        
        var isAscending = report.ElementAt(1) > report.ElementAt(0);
        return report.Count((x, y) => isAscending ? y > x && y <= x + 3 : y < x && y >= x - 3) >= safeCountThreshold - 2;
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