using System;

namespace CoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = DateTime.Now;
            Console.WriteLine("Hello World!");
            Console.WriteLine($"Date: {dateTime:d} Time: {dateTime:t}");
            Console.WriteLine($"Date: {dateTime.Date} Time: {dateTime.TimeOfDay}");
            Console.WriteLine("\nPress any key...");
            Console.ReadKey(true);
        }
    }
}
