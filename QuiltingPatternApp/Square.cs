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

        public override void drawShape()
        {
            Console.WriteLine(Name + ", Area:  " + Length * Length + ", " + Color);
        }
    }
}
