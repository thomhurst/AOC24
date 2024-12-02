using Test.Utilities;

namespace Day1;

public class Tests : TestBase
{
    [Test]
    public void Part1()
    {
        var safeCount = new Day2.Day2().CountSafe(Input);
        
        Console.WriteLine(safeCount);
    }
    
    [Test]
    public void Part2()
    {
        var safeWithDampenerCount = new Day2.Day2().CountSafeWithDampener(Input);
        
        Console.WriteLine(safeWithDampenerCount);
    }
}