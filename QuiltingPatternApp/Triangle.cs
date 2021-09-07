using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiltingPatternApp
{
    class Triangle : Shape
    {
        public int leftSide { get; set; }
        public int rightSide { get; set; }
        public Triangle(int baseInput, int leftSideInput, int rightSideInput, string colorInput)
        {
            this.Name = "Triangle";
            this.Length = baseInput;
            this.leftSide = leftSideInput;
            this.rightSide = rightSideInput;
            this.Color = colorInput;
        }
        //uses herons formula
        public override int getArea()
        {
            int semiperimeter = (Length + leftSide + rightSide) / 2;
            int x = semiperimeter - Length;
            int y = semiperimeter - leftSide;
            int z = semiperimeter - rightSide;
            int area = Convert.ToInt32(Math.Sqrt(semiperimeter * x * y * z));

            return area;
        }
        public override void drawShape()
        {
            Console.WriteLine(Name + ", Area: " + getArea() + ", " + Color);   
        }

        public static Triangle promptTriangle()
        {
            Console.WriteLine("how long would you like the base of the triangle?");
            int triangleBase = Int32.Parse(Console.ReadLine());
            Console.WriteLine("how long would you like the left side of the triangle?");
            int leftSide = Int32.Parse(Console.ReadLine());
            Console.WriteLine("how long would you like the right side of the triangle?");
            int rightSide = Int32.Parse(Console.ReadLine());
            if (triangleBase < 1 || leftSide < 1 || rightSide < 1)
            {
                Console.WriteLine("all sides of your shape must be bigger than 0!");
                return null;
            }
            Console.WriteLine("What color would you like the triangle?");
            var triangleColor = Console.ReadLine();

            return new Triangle(triangleBase, leftSide, rightSide, triangleColor);
        }
    }
}
