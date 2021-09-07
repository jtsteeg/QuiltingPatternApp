using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiltingPatternApp
{
    class Rectangle : Shape
    {
        public int Width { get; set; }
        public Rectangle(int lengthInput, int widthInput, string colorInput)
        {
            this.Name = "Rectangle";
            this.Length = lengthInput;
            this.Width = widthInput;
            this.Color = colorInput;
        }
        
        public override int getArea()
        {
            return Length*Width;  
        }

        public override void drawShape()
        {
            Console.WriteLine(Name + ", Area: " + getArea() + ", " + Color);
        }

        public static Rectangle promptRectangle()
        {
            Console.WriteLine("How Long would you like your rectangle?");
            var rectangleLength = Int32.Parse(Console.ReadLine());
            Console.WriteLine("How Wide?");
            int rectangleWidth = Int32.Parse(Console.ReadLine());
            if (rectangleLength < 1 || rectangleWidth < 1)
            {
                Console.WriteLine("all sides of your shape must be bigger than 0!");
                return null;
            }
            Console.WriteLine("What color?");
            var rectangleColor = Console.ReadLine();

            return new Rectangle(rectangleLength, rectangleWidth, rectangleColor);
        }

    }
}
