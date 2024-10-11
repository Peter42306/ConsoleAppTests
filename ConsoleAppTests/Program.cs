
class Program
{
    static void Main(string[] args)
    {
        foreach (var number in GetEvenNumbers(100))
        {
            Console.Write($"{number}, ");  // Output: 0, 2, 4, 6, 8, 10
        }
    }

    // method to get even numbers up to max
    static IEnumerable<int> GetEvenNumbers(int max)
    {
        for (int i = 0; i <= max; i++)
        {
            if (i % 2 == 0)
            {
                yield return i;
            }
        }
    }
}

