using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {


        
        Random random = new Random();
        int magicNumber = random.Next(1, 101);


        int guess = -1;

        Console.WriteLine("Welcone to the guess a random number game! Guess a number 1-100");

        do
        {
            Console.WriteLine("Guess a Number");
            string guessRaw = Console.ReadLine();
            guess = int.Parse(guessRaw);



            if (magicNumber < guess)
            {
                Console.WriteLine("You've guessed to high");
              
            }

            if (magicNumber > guess)
            {
                Console.WriteLine("You've guessed to low");
             
            }

            if (magicNumber == guess)
            {
                Console.WriteLine("Correct");
            }
            
            

        } while (guess != magicNumber);












    }
}