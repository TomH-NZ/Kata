using System;

namespace FizzBuzzKata
{
    public static class Program
    {
        static void Main(string[] args)
        {
            for (int index = 1; index <= 100; index++)
            {
                Console.WriteLine(FizzBuzz.Calculator(index));
            }
            Console.ReadLine();
        }
    }

    public static class FizzBuzz
    {
        public static string Calculator(int inputValue)
        {
            if (inputValue % 3 == 0 && inputValue % 5 == 0) //if the method is returning a single value, then the curly braces are not needed.
            
                return "FizzBuzz";
            

            else if (inputValue % 3 == 0)
            {
                return "Fizz";
            }

            else if (inputValue % 5 == 0)
            {
                return "Buzz";
            }
            
            return inputValue.ToString();
        }
    }
}
