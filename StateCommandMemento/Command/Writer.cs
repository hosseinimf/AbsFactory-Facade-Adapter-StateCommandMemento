using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento.Command
{
    public class Writer : IWriter
    {
        public void Write(string message)
        {
            Console.WriteLine($"The message is --{message}-- ");
        }
    }
}
