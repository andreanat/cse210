using System;

class Program
{
    static void Main(string[] args)
    {
      menu:
      Console.WriteLine("Welcome to your Journal!");
      Console.WriteLine("1. Write");
      Console.WriteLine("2. Display");
      Console.WriteLine("3. Load");
      Console.WriteLine("4. Save");
      Console.WriteLine("5. Quit");
      
      string choice = Console.ReadLine();

      switch (choice){
        case "1":
        PromptGenerator promptgenerator = new PromptGenerator();
        promptgenerator.MyMethod();
        goto menu;

        case "2":
        break;
        case "3":
        break;
        case "4":
        break;
        case "5":
        Console.WriteLine("Exiting...");
        return;
        default:
        Console.WriteLine("Invalid choice, please try again.");
        goto menu;

      }
    }
}