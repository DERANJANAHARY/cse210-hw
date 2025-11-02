using System;

class Program
{
    static void Main(string[] args)
    {
        /*Ask for a magic number
        Console.WriteLine("What is the magic number?");
        string magicInput = Console.ReadLine();
        int magicNumber = int.Parse(magicInput);*/

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);


        //Ask for a guess number
        int guessNumber = -1; 
        do
        {
            Console.WriteLine("What is your guess number?");
            guessNumber = int.Parse(Console.ReadLine());

            //Compare and display the result
            if (magicNumber > guessNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guessNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (magicNumber == guessNumber)
            {
                Console.WriteLine("You guessed it!");
            }
            
        } while (magicNumber != guessNumber);   

    }
}