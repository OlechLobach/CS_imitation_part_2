using System;
using ArrayLibrary;
namespace ArrayApp
{
    class Program
    {
        static void Main()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            var arrayObj = new ArrayLibrary.Array(array);

            Console.WriteLine($"Max: {arrayObj.Max()}");
            Console.WriteLine($"Min: {arrayObj.Min()}");
            Console.WriteLine($"Avg: {arrayObj.Avg()}");
            Console.WriteLine($"Search for 3: {arrayObj.Search(3)}");
            Console.WriteLine($"Search for 6: {arrayObj.Search(6)}");
        }
    }
}