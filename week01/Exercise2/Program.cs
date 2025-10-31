using System;

class Program
{
    static void Main(string[] args)
    {
        //Ask users for the grade
        Console.WriteLine("Type grade percentage");
        string gradeInput = Console.ReadLine();
        string letter = "";
        string sign = "";

        int gradeValue = int.Parse(gradeInput);
        int signValue = gradeValue % 10;

        //Conditions on letters
        if (gradeValue >= 90)
        {
            letter = "A";
        }
        else if (gradeValue >= 80)
        {
            letter = "B";
        }
        else if (gradeValue >= 70)
        {
            letter = "C";
        }
        else if (gradeValue >= 60)
        {
            letter = "D";
        }
        else if (gradeValue < 60)
        {
            letter = "F";
        }
        // Determine the sign
        if (signValue >= 7 && gradeValue < 93 && gradeValue > 60)
        {
            sign = "+";
        }

        else if (signValue < 3 && gradeValue < 93 && gradeValue > 60)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }
            //Print grade letter
            Console.WriteLine($"Your grade is {letter}{sign}");

        //Check pass grade 
        if (gradeValue >= 70)
        {
            Console.WriteLine("You pass. Congratulations!");
        }

        else if (gradeValue < 70)
        {
            Console.WriteLine("You have at least 70% to pass. You can work more and take the exam again.");
        }

    }
}