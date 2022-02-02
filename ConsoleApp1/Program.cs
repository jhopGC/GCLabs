using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's the length of the room?");
            string length = Console.ReadLine();
            Console.WriteLine("What's the width of the room?");

            //I feel like using var now.
            var width = Console.ReadLine();

            double parsedLength = Convert.ToDouble(length);

            var parsedWidth = double.Parse(width);

            double perimeter = 2 * parsedLength + 2 * parsedWidth;

            var area = parsedWidth * parsedLength;

            Console.WriteLine("The area is " + area);
            Console.WriteLine("The perimeter is " + perimeter);
        }
    }
}
