using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int userFavoriteNumber = SquareNumber(userNumber);

        DisplayResult(userName, userNumber, userFavoriteNumber);

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            return Console.ReadLine();
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter a number: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static int SquareNumber(int userNumber)
        {
            return userNumber * userNumber;
        }

        static void DisplayResult(string userName, int userNumber, int userFavoriteNumber)
        {
            Console.WriteLine($"{userName}, the square of your number is {userFavoriteNumber}");
        }   
    }
}