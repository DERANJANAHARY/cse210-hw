
//Two features are added
//Let the user choose to use the default scripture or enter a custom reference and text. 
//Let the user choose how many words to hide each Enter press (difficulty: 1–5).
class Program
{
    static void Main()
    {
        Console.WriteLine(">>> Scripture Memorizer <<<");
        Console.WriteLine("1. Use default scripture");
        Console.WriteLine("2. Enter my own scripture");
        Console.Write("Choose (1 or 2): ");
        string choice = Console.ReadLine();

        Reference reference;
        string text;

        if (choice == "2")
        {
            Console.Write("Enter book name (e.g. John): ");
            string book = Console.ReadLine();

            Console.Write("Enter chapter number: ");
            int chapter = int.Parse(Console.ReadLine());

            Console.Write("Enter verse number: ");
            int verse = int.Parse(Console.ReadLine());

            Console.Write("Enter the scripture text: ");
            text = Console.ReadLine();

            reference = new Reference(book, chapter, verse);
        }
        else
        {
            // Default sample scripture
            reference = new Reference("Proverbs", 3, 5);
            text = "Trust in the Lord with all thine heart and lean not unto thine own understanding.";
        }

        Console.Write("\nChoose difficulty (1–5 words hidden per Enter): ");
        int difficulty = int.Parse(Console.ReadLine());

        Scripture scripture = new Scripture(reference, text);

        scripture.Display();

        while (true)
        {
            string input = Console.ReadLine().ToLower();

            if (input == "quit")
                break;

            scripture.HideRandomWords(difficulty);
            scripture.Display();

            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("All words are now hidden. Well-done!");
                break;
            }
        }
    }
}