using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiltingPatternApp
{
    public abstract class Shape
    {
        public int numberOfSides  { get; set; }
        public int Length { get; set; }
        public string Color { get; set; }
    }
}
