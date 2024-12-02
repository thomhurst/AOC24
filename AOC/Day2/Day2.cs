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
    
    private static bool IsSafeWithDampener(IReadOnlyCollection<int> report)
    {
        var safeCountThreshold = report.Count - 2;
        
        var isAscending = report.ElementAt(1) > report.ElementAt(0);
        return report.Count((x, y) => IsSafe(isAscending, y, x)) >= safeCountThreshold;
    }

    private static bool IsSafe(IReadOnlyCollection<int> report)
    {
        var isAscending = report.ElementAt(1) > report.ElementAt(0);
        return report.All((x, y) => IsSafe(isAscending, y, x));
    }

    private static bool IsSafe(bool isAscending, int first, int second)
    {
        if (isAscending)
        {
            return first > second && first <= second + 3;
        }

        return first < second && first >= second - 3;
    }

    private static IEnumerable<IReadOnlyCollection<int>> GetReports(string input)
    {
        return input.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
            .Select(x => x.Split(' '))
            .Select(x => x.Select(int.Parse).ToArray());
    }
}