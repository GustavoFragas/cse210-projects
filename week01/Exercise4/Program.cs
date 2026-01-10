using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int sum = 0;
        float average = 0;
        int largestNumber = int.MinValue;
        int smallestPositiveNumber = int.MaxValue;
        
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type '0' when finished.");

        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "0")
            {
                break;
            }
            else
            {
                int number = int.Parse(input);
                numbers.Add(number);                
            }

        }

        foreach (int num in numbers)
        {
            sum += num;
            if (num > largestNumber)
            {
                largestNumber = num;
            }
            if (num < smallestPositiveNumber && num > 0)
            {
                smallestPositiveNumber = num;
            }
        }
        if (numbers.Count > 0)

        {
            average = (float)sum / numbers.Count;
        }

        var aleatoryList = numbers.OrderBy(x => Random.Shared.Next()).ToList();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");
        Console.WriteLine($"The smallest number is: {smallestPositiveNumber}");
        Console.WriteLine("The sorted list is:");
        foreach (int num in aleatoryList)
        {
            Console.WriteLine(num);
        }
    }
}