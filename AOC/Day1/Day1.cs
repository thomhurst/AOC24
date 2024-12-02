namespace Day1;

public class Day1
{
    public int GetTotalDistance(string input)
    {
        var (list1, list2) = GetLists(input);
        
        return list1
            .Zip(list2, GetDifference)
            .Sum();
    }
    
    public int GetSimilarityScore(string input)
    {
        var (left, right) = GetLists(input);

        return left
            .Select(x => x * right.Count(y => y == x))
            .Sum();
    }

    private (IEnumerable<int> left, IEnumerable<int> right) GetLists(string input)
    {
        var lists = input.Split(Environment.NewLine, StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries)
            .Select(x => x.Split(' ', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries))
            .Select(x => (int.Parse(x[0]), int.Parse(x[1])))
            .ToArray();

        var left = lists.Select(x => x.Item1).Order();
        var right = lists.Select(x => x.Item2).Order();

        return (left, right);
    }

    private int GetDifference(int x, int y)
    {
        return Math.Abs(x - y);
    }
}