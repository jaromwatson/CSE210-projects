using System;

class Program
{
    static void Main(string[] args)
    {

        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);
        int birthyear;
        PromptUserBirthYear(out birthyear); 

        DisplayResult(userName, squaredNumber, birthyear);



        
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("What is your name? ");
            string userName = Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber()
        {
            
            Console.Write("What is your favorite number? ");
            string userNumberx = Console.ReadLine();
            int x = int.Parse(userNumberx);
            return x;
        }

        static void PromptUserBirthYear(out int x)
        {
            
            Console.Write("What is your birth year? ");
            string userNumberx = Console.ReadLine();
            x = int.Parse(userNumberx);
        }

        static int SquareNumber(int number)
        {
            return number * number; 
        }

        static void DisplayResult(string userName, int number, int birthyear)
        {
            Console.WriteLine($"{userName}, the square of your number is {number}");
            int x = 2026 - birthyear;
            Console.WriteLine($"{userName}, you will turn {x} this year");
        }















    }
}