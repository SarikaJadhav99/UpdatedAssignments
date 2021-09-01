using System;

namespace PatternPrinting
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the string : ");
            string str = Console.ReadLine();

            Console.WriteLine("String : " + str);

            // To print odd index characters
            for (int i = 1; i <= str.Length; i += 2)
            {
                Console.WriteLine(str.Substring(0, i));
            }

            //To print pyramid pattern
            int rows;
            string word;

            Console.WriteLine("Enter the number of rows : ");
            rows = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the word : ");
            word = Console.ReadLine();

            for (int i = 1; i <= rows; i++)
            {
                for (int j = rows; j > i; j--)
                {
                    Console.Write("  ");
                }

                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write(word[k - 1] + " ");
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}
