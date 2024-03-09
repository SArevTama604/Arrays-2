internal class Program
{
    private static void Main(string[] args)
    {
        int[] numbers = { 5, 12, 8, 88, 7 };
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine("Sum: " + sum);
    }
}