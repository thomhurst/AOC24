using Test.Utilities;

namespace Day1;

public class Tests : TestBase
{
    [Test]
    public void Part1()
    {
        var distance = new Day1().GetTotalDistance(Input);
        
        Console.WriteLine(distance);
    }
    
    [Test]
    public void Part2()
    {
        var similaryScore = new Day1().GetSimilaryScore(Input);
        
        Console.WriteLine(similaryScore);
    }
}