using System;
using System.Collections.Generic;
using System.Text;

namespace MainProgekt
{
    public class Triangle
    {
        public Point A { get; set; }
        public Point B { get; set; }
        public Point C { get; set; }
        public override string ToString()
        {
            return $"{A}:{B}:{C}";
        }
    }
}
