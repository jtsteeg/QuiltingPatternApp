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
                        Console.WriteLine("how long would you like the base??");
                        shapeLength = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("how long would you like the left side?");
                        int leftSide = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("how long would you like the right side?");
                        int rightSide = Int32.Parse(Console.ReadLine());
                        if (shapeLength < 1 || leftSide < 1 || rightSide < 1)
                        {
                            Console.WriteLine("all sides of your shape must be bigger than 0!");
                            break;
                        }
                        Console.WriteLine("What color?");
                        shapecolor = Console.ReadLine();
                        Triangle T = new Triangle(shapeLength, leftSide, rightSide, shapecolor);
                        quiltPatternList.Add(T);
                        Console.WriteLine($"you just added a Triangle Area {T.getArea()} and color {T.Color}!");
                        break;

                    case "rectangle":
                        Console.WriteLine("How Long?");
                        shapeLength = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("How Wide?");
                        int shapeWidth = Int32.Parse(Console.ReadLine());
                        if (shapeLength < 1 || shapeWidth < 1)
                        {
                            Console.WriteLine("all sides of your shape must be bigger than 0!");
                            break;
                        }
                        Console.WriteLine("What color?");
                        shapecolor = Console.ReadLine();
                        Rectangle R = new Rectangle(shapeLength, shapeWidth, shapecolor);
                        quiltPatternList.Add(R);
                        Console.WriteLine($"you just added a Rectangle Area {R.getArea()} and color {R.Color}!");
                        break;

                    case "square":
                        Console.WriteLine("What size?");
                        shapeLength = Int32.Parse(Console.ReadLine());
                        if(shapeLength < 1)
                        {
                            Console.WriteLine("all sides of your shape must be bigger than 0!");
                            break;
                        }
                        Console.WriteLine("What color?");
                        shapecolor = Console.ReadLine();
                        Square S = new Square(shapeLength, shapecolor);
                        quiltPatternList.Add(S);
                        Console.WriteLine($"you just added a Square Area {S.getArea()} and color {S.Color}!");
                        break;

                    case "see pattern":
                        if(quiltPatternList.Count < 1)
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
