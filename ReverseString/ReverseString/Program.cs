using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Statement:");

            string statement = Console.ReadLine();
            string[] str = statement.Split(' ');

            Console.WriteLine("Reversed statement is:");

            Array.Reverse(str);
            foreach (var element in str)
            {
                Console.Write($"{element}{' '}");
            }

            Console.ReadLine();
        }
    }
}
