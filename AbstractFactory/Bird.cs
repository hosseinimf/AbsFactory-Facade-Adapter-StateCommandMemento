using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.AbstractFactory
{
    public class Bird
    {
        public Bird(string name)
        {
            Name = name;
            Console.WriteLine($"This is a bird, its name is {name}");
        }

        public string Name { get; set; }
        public string Type { get; } = "Bird";
    }
}
