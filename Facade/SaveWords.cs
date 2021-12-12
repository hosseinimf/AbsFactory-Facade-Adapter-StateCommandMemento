using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Facade
{
    public class SaveWords : ISaveWords
    {
        public List<List<char>> Save(string input)
        {
            List<List<char>> list = new List<List<char>>();

            List<char> one = new();
            List<char> two = new();
            List<char> three = new();
            List<char> four = new();
            List<char> five = new();

            one.Add(input[0]);
            two.Add(input[1]);
            three.Add(input[2]);
            four.Add(input[3]);
            five.Add(input[4]);

            list.Add(one);
            list.Add(two);
            list.Add(three);
            list.Add(four);
            list.Add(five);

            return list;

        }
    }
}
