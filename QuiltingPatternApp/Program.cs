using System;

namespace QuiltingPatternApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;

            Console.WriteLine("Welcome to the quilting pattern app! Enter 'exit' to quit");
            string userCommand = Console.ReadLine();
            while (isRunning == true)
            {
                switch (userCommand)
                {
                    case "exit":
                        Console.WriteLine("goodbye!");
                        isRunning = false;
                        break;

                    default:
                        Console.WriteLine("unrecognized command! please try again.");
                        userCommand = Console.ReadLine();
                        break;
                }
            }
        }
    }
}
