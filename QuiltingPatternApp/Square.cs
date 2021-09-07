using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiltingPatternApp
{
    class Square : Shape
    {
        public Square(int lengthInput, string colorInput)
        {
            this.Name = "Square";
            this.Length = lengthInput;
            this.Color = colorInput;
        }
        public override int getArea()
        {
            return Length*Length;  
        }
        public override void drawShape()
        {
            Console.WriteLine(Name + ", Area:  " + getArea() + ", " + Color);
        }

        public static Square promptSquare()
        {
            Console.WriteLine("What size would you like the square?");
            var squareSideLength = Int32.Parse(Console.ReadLine());
            if (squareSideLength < 1)
            {
                Console.WriteLine("all sides of your shape must be bigger than 0!");
                return null;
            }
            Console.WriteLine("What color would you like the square?");
            var squareColor = Console.ReadLine();

            return new Square(squareSideLength, squareColor); ;
        }
    }
}
