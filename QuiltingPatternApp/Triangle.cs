using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiltingPatternApp
{
    class Triangle : Shape
    {
        public int Side1 { get; set; }
        public int Side2 { get; set; }
        public Triangle(int lengthInput, int Side1Input, int Side2Input, string colorInput)
        {
            this.Name = "Triangle";
            this.Length = lengthInput;
            this.Side1 = Side1Input;
            this.Side2 = Side2Input;
            this.Color = colorInput;
        }
        //uses herons formula
        public override int getArea()
        {
            int semiPerimiter = (Length + Side1 + Side2) / 2;
            int x = semiPerimiter - Length;
            int y = semiPerimiter - Side1;
            int z = semiPerimiter - Side2;
            int area = Convert.ToInt32(Math.Sqrt(semiPerimiter * x * y * z));

            return area;
        }
        public override void drawShape()
        {
            Console.WriteLine(Name + ", Area: " + getArea() + ", " + Color);   
        }
    }
}
