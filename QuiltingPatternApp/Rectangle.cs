﻿using System;
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

        public override void drawShape()
        {
            Console.WriteLine(Name + ", Length: " + Length + ", Width: " + Width + ", " + Color);
        }
    }
}
