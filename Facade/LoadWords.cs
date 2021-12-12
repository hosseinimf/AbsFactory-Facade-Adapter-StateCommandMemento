using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Facade
{
    public class LoadWords : ILoadWords
    {

        public void Load(List<List<char>> list)
        {
            if (list.Count > 0)
            {
                if (list[0].Count > 0)
                {
                    char[] word = { list[0].Last(), list[1].Last(),
                                list[2].Last(), list[3].Last(),
                                list[4].Last() };

                    Console.WriteLine(word);
                }
            }            
            else
            {
                Console.WriteLine("There is no character.");
            }

        }
    }
}
