namespace Test.Utilities;

public abstract class TestBase
{
    protected static string Input { get; private set; } = null!;
    
    [Before(Class)]
    public static async Task Setup()
    {
        Input = await File.ReadAllTextAsync("input.txt");
    }
}