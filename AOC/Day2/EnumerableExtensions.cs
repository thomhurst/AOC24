namespace Day1;

public static class EnumerableExtensions
{
    public static int Count<T>(this IEnumerable<T> enumerable, Func<T, T, bool> predicate)
    {
        var count = 0;
        var arr = (T[])(enumerable is T[] ? enumerable : enumerable.ToArray());

        for (var i = 0; i < arr.Length - 1; i++)
        {
            var x = arr[i];
            var y = arr[i + 1];
            
            if (predicate(x, y))
            {
                count++;
            }
        }

        return count;
    }
    
    public static bool All<T>(this IEnumerable<T> enumerable, Func<T, T, bool> predicate)
    {
        var arr = (T[])(enumerable is T[] ? enumerable : enumerable.ToArray());

        for (var i = 0; i < arr.Length - 1; i++)
        {
            var x = arr[i];
            var y = arr[i + 1];
            
            if (!predicate(x, y))
            {
                return false;
            }
        }

        return true;
    }
}