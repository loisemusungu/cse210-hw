using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int> ();

        while (true)
        {
            Console.Write("Enter a number (0 to stop): ");
            string input = Console.ReadLine();

            int number;
            if(int.TryParse(input, out number))
            {
                if (number == 0)
                {
                    break;
                }
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }

        if(numbers.Count > 0)
        {
            int total = numbers.Sum();
            Console.WriteLine($"The sum is {total}.");

            double average = (double)total / numbers.Count();
            Console.WriteLine($"The average is {average}.");

            int max = numbers.Max();
            Console.WriteLine($"The max number is {max}.");
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }  
    }
}