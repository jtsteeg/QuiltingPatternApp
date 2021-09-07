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


            Console.Write("Welcome to the quilting pattern app! Please enter one of the following to begin:\ntriangle - add a triangle\nrectangle - add a rectangle\nsquare - add a square\nsee pattern - review list of shapes entered\nexit - quit program\n");
            string userCommand = Console.ReadLine().ToLower();
            while (isRunning == true)
            {
                switch (userCommand)
                {
                    case "exit":
                        Console.WriteLine("goodbye!");
                        isRunning = false;
                        break;

                    case "triangle":
                        Console.WriteLine("how long would you like the base??");
                        shapeLength = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("how long would you like the left side?");
                        int leftSide = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("how long would you like the right side?");
                        int rightSide = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("What color?");
                        shapecolor = Console.ReadLine();
                        Triangle T = new Triangle(shapeLength, leftSide, rightSide, shapecolor);
                        quiltPatternList.Add(T);
                        Console.WriteLine($"you just added a Triangle size {T.getArea()} and color {T.Color}!");
                        Console.WriteLine($"would you like to enter another shape to the pattern?");
                        userCommand = Console.ReadLine();
                        break;

                    case "rectangle":
                        Console.WriteLine("How Long?");
                        shapeLength = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("How Wide?");
                        int shapeWidth = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("What color?");
                        shapecolor = Console.ReadLine();
                        Rectangle R = new Rectangle(shapeLength, shapeWidth, shapecolor);
                        quiltPatternList.Add(R);
                        Console.WriteLine($"you just added a Rectangle size {R.getArea()} and color {R.Color}!");
                        Console.WriteLine($"would you like to enter another shape to the pattern?");
                        userCommand = Console.ReadLine();
                        break;

                    case "square":
                        Console.WriteLine("What size?");
                        shapeLength = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("What color?");
                        shapecolor = Console.ReadLine();
                        Square S = new Square(shapeLength, shapecolor);
                        quiltPatternList.Add(S);
                        Console.WriteLine($"you just added a Square size {S.getArea()} and color {S.Color}!");
                        Console.WriteLine($"would you like to enter another shape to the pattern?");
                        userCommand = Console.ReadLine();
                        break;

                    case "see pattern":
                        if(quiltPatternList.Count < 1)
                        {
                            Console.WriteLine("First add a shape to the pattern!");
                            userCommand = Console.ReadLine();
                            break;
                        }
                        else
                        {
                            foreach (var shape in quiltPatternList)
                            {
                                shape.drawShape();
                            }
                            Console.WriteLine($"would you like to enter another shape to the pattern?");
                            userCommand = Console.ReadLine();
                            break;
                        }

                    default:
                        Console.WriteLine("unrecognized command! please try again.");
                        userCommand = Console.ReadLine();
                        break;
                }
            }
        }
    }
}
