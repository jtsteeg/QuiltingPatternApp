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
            this.numberOfSides = 3;
            this.Length = lengthInput;
            this.Color = colorInput;
        }
    }
}
