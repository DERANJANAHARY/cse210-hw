using System;

class Program
{
    static void Main(string[] args)
    {   //Ask the user for the first name
        Console.WriteLine("What is your first name?");
        String first_name = Console.ReadLine();

        //Ask the user for the last name
        Console.WriteLine("What is your last name?");
        String last_name = Console.ReadLine();

        //Print the introducing phrase
        Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}");
    }
}