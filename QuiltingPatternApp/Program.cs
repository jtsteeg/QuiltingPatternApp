using System;
using System.Collections.Generic;

namespace QuiltingPatternApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            List<Shape> quiltPatternList = new List<Shape>();
            Console.WriteLine("Welcome to the quilting pattern app!");
            while (isRunning == true)
            {
                Console.Write("Please enter one of the following:\ntriangle - add a triangle\nrectangle - add a rectangle\nsquare - add a square\nsee pattern - review list of shapes entered\nexit - quit program\n");
                string userCommand = Console.ReadLine().ToLower();
                switch (userCommand)
                {
                    case "exit":
                        Console.WriteLine("goodbye!");
                        isRunning = false;
                        break;

                    case "triangle":
                        var triangle = Triangle.promptTriangle();
                        quiltPatternList.Add(triangle);
                        break;

                    case "rectangle":
                        var rectangle = Rectangle.promptRectangle();
                        quiltPatternList.Add(rectangle);
                        break;

                    case "square":
                        var square = Square.promptSquare();
                        quiltPatternList.Add(square);
                        break;

                    case "see pattern":
                        if (quiltPatternList.Count < 1)
                        {
                            Console.Write("First add a shape to the pattern! ");
                            break;
                        }
                        else
                        {
                            foreach (var shape in quiltPatternList)
                            {
                                shape.drawShape();
                            }
                            Console.WriteLine("");
                            break;
                        }

                    default:
                        Console.Write("unrecognized command! ");
                        break;
                }
            }
        }
    }
}
