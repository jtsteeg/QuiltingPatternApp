using System;
using System.Collections.Generic;

namespace QuiltingPatternApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            int shapeLength;
            string shapecolor;
            List<Shape> quiltPatternList = new List<Shape>();


            Console.WriteLine("Welcome to the quilting pattern app! Type 'triangle' to add a triangle to the pattern. Enter 'exit' to quit");
            string userCommand = Console.ReadLine();
            while (isRunning == true)
            {
                switch (userCommand)
                {
                    case "exit":
                        Console.WriteLine("goodbye!");
                        isRunning = false;
                        break;

                    case "triangle":
                        Console.WriteLine("What size?");
                        shapeLength = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("What color?");
                        shapecolor = Console.ReadLine();
                        Triangle T = new Triangle(shapeLength, shapecolor);
                        quiltPatternList.Add(T);
                        Console.WriteLine($"you just added a Triangle size {T.Length} and color {T.Color}!");
                        Console.WriteLine($"would you like to enter another shape to the pattern?");
                        userCommand = Console.ReadLine();
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
