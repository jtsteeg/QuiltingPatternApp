using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiltingPatternApp
{
    class Triangle : Shape
    {
        public Triangle(int lengthInput, string colorInput)
        {
            this.Name = "Triangle";
            this.Length = lengthInput;
            this.Color = colorInput;
        }

        public override void drawShape()
        {
            Console.WriteLine(Name + ", " + Length + ", " + Color);   
        }
    }
}
