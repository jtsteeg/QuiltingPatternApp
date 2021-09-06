using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiltingPatternApp
{
    public abstract class Shape
    {
        public string Name  { get; set; }
        public int Length { get; set; }
        public string Color { get; set; }

        public virtual void drawShape() { }
    }  
}
