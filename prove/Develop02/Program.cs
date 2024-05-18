using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        
        Prompt prompt1 = new Prompt();
        int number = 1;
        Prompt prompts = new Prompt();
        FileWork filework = new FileWork();

        prompts.AddPrompt();
        // prompts.GetPrompt();

        while (number == 1)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                prompts.GetPrompt();
                
            }
            else if (choice == 2)
            {
                prompts.Display();
                filework.LoadDisplay();
            }
            else if (choice == 3)
            {
                prompts.ClearEntries();
                filework.LoadFile();
            }
            else if (choice == 4)
            {
                prompts.GetFileName();
            }
            else
            {
                number = 2;
            }
        }
    }
}
// I went above and beyond with this project by adding the ability for the author to either recieve a random prompt or to freewrite.
// It is working great and displays both options when the display command is called.