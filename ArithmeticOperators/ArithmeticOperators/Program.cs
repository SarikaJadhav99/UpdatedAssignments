using System;

namespace ArithmeticOperators
{
    class Arithmetic
    {
        public int TwoNumbersAddition(int firstTerm, int secondTerm)
        {
            return firstTerm + secondTerm;
        }

        public int TwoNumbersSubstraction(int firstTerm,int secondTerm)
        {
            return firstTerm - secondTerm;
        }

        public int TwoNumbersMultiplication(int firstTerm, int secondTerm)
        {
            return firstTerm * secondTerm;
        }

        public double TwoNumbersDivision(int firstTerm, int secondTerm)
        {
            return firstTerm / secondTerm;
        }
        static void Main(string[] args)
        {
             Arithmetic operation = new Arithmetic();


            Console.Write("Enter a number : ");
            int firstTerm = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another number : ");
            int secondTerm = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Addition of two numbers is : {operation.TwoNumbersAddition(firstTerm,secondTerm)}");
            Console.WriteLine(value: $"Substraction of two numbers is : {operation.TwoNumbersSubstraction(firstTerm, secondTerm)}");
            Console.WriteLine($"Multiplication of two numbers is : {operation.TwoNumbersMultiplication(firstTerm, secondTerm)}");
            Console.WriteLine($"Division of two numbers is : {operation.TwoNumbersDivision(firstTerm, secondTerm)}");
           
            Console.ReadLine();
        }
    }
}
