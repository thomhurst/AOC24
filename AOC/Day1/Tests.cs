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
        var similarityScore = new Day1().GetSimilarityScore(Input);
        
        Console.WriteLine(similarityScore);
    }
}