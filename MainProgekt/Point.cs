using System;
using System.Collections.Generic;
using System.Text;

namespace MainProgekt
{
    public class Point
    {
        public double X {get; set;}
        public double Y { get; set; }
        public override string ToString()
        {
            return $"{X},{Y}";
        }
    }
}
