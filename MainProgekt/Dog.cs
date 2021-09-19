using System;
using System.Collections.Generic;
using System.Text;

namespace MainProgekt
{
    public class Dog
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public void Show()
        {
            Console.WriteLine($"Возраст - {Age}, кличка  - {Name}");
        }
    }
}
