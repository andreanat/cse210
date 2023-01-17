using System;

class Program
{
    static void Main(string[] args)
    {
    while (true) {
      Console.WriteLine("Welcome to your Journal!");
      Console.WriteLine("1. Write");
      Console.WriteLine("2. Display");
      Console.WriteLine("3. Load");
      Console.WriteLine("4. Save");
      Console.WriteLine("5. Quit");
      
      int input = int.Parse(Console.ReadLine());
      
      if (input == 1) {
        // Code 
      } else if (input == 2) {
        // Code 
      } else if (input == 3) {
        // Code 
      } else if (input == 4) {
        // Code 
      } else if (input == 5) {
        Console.WriteLine("Exiting...");
        break;
      } else {
        Console.WriteLine("Invalid input, please try again.");
    }
    }
    }
}