using System;
using System.Diagnostics.CodeAnalysis;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int number = -1;
        int listCount = 0;
        int largestNumber;
        int smallestNumber;
        int sum = 0;
        int avg = 0;




        string numberRaw = "";
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when you are finished.");

        while (number != 0)
        {
            Console.Write("Enter number: ");
            numberRaw = Console.ReadLine();
            number = int.Parse(numberRaw);

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        largestNumber = numbers[0];
        smallestNumber = numbers[0];

        for (int i = 0; i < numbers.Count; i++)
        {
            
            sum = sum + numbers[i];
            listCount++;
            
            if (numbers[i] > largestNumber)
            {
                largestNumber = numbers[i];
            }

            if (numbers[i] < smallestNumber)
            {
                smallestNumber = numbers[i];
            }

            
        }


        avg = sum / listCount;
        Console.WriteLine($"the sum is: {sum}");
        Console.WriteLine($"the average is: {avg}");
        Console.WriteLine($"the largest number is: {largestNumber}");
        Console.WriteLine($"the smallest number is: {smallestNumber}");



















    }
}