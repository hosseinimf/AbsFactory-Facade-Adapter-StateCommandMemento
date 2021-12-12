using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Adapter
{
    public class Adapter : IAdapter
    {
        public int IntConverter(string str)
        {
            int number;
            Int32.TryParse(str, out number);
            return number;
           
        }
    }
}
