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
    
    public int GetSimilaryScore(string input)
    {
        var (list1, list2) = GetLists(input);

        return list1
            .Select(x => x * list2.Count(y => y == x))
            .Sum();
    }

    private (IEnumerable<int> list1, IEnumerable<int> list2) GetLists(string input)
    {
        var lists = input.Split(Environment.NewLine, StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries)
            .Select(x => x.Split(' ', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries))
            .Select(x => (int.Parse(x[0]), int.Parse(x[1])))
            .ToArray();

        var list1 = lists.Select(x => x.Item1).Order();
        var list2 = lists.Select(x => x.Item2).Order();

        return (list1, list2);
    }

    private int GetDifference(int x, int y)
    {
        return Math.Abs(x - y);
    }
}