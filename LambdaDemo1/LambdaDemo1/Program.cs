using System;
using System.Linq;

namespace LambdaDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> Square = x => x * x;
            Console.WriteLine(Square(5));

            int[] numbers = { 2, 3, 4, 5 };
            var squaredNumbers = numbers.Select(x => x * x);
            Console.WriteLine(string.Join(" ", squaredNumbers));

            Func<int, int, bool> TestForEquality = (x, y) => x == y;
            Console.WriteLine(TestForEquality(5,2));

            int[] numbers1 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            int oddNumbers = numbers.Count(n => n % 2 == 1);
            Console.WriteLine($"There are {oddNumbers} odd numbers in {string.Join(" ", numbers1)}");

            Console.WriteLine("Hello World!");
        }
    }
}
