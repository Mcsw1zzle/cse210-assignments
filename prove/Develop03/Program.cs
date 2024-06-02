using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {   
        
        Scripture scripture = new Scripture("For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

         bool allWordsHidden = false;

        while (true)
        {
            Console.Clear();
            scripture.Display();

            if (!allWordsHidden)
            {
                Console.WriteLine("Press Enter to hide three words or type 'quit' to exit...");
                string input = Console.ReadLine();
                if (input.ToLower() == "quit")
                {
                    return;
                }

                scripture.HideWords();
                allWordsHidden = scripture.AllWordsHidden();
            }
            else
            {
                Console.WriteLine("All words are hidden. Press Enter to exit...");
                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    return;
                }
            }
        }
    }

}