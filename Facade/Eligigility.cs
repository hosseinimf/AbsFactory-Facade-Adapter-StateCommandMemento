using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Facade
{
    public class Eligigility : IEligigility
    {
        public bool IsEligible(string word)
        {
            if (word.Length != 5)
                return false;
            else
                return true;
        }
    }
}
