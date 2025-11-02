using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userNumber = -1;
        do
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished:");
            userNumber = int.Parse(Console.ReadLine());

            //Add to the list only when a typed number is not 0
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }

        } while (userNumber != 0);

        // Compute the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        // Compute the average
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is {average}");

        // Find the largest number
        int maxFound = numbers[0];

        foreach (int number in numbers)
        {
            if (number > maxFound)
            {
                // if this number is greater than the max found
                maxFound = number;
            }
        }

        Console.WriteLine($"The max is: {maxFound}");        


    }
}