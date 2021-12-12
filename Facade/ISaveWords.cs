using System.Collections.Generic;

namespace Assignment2.Facade
{
    public interface ISaveWords
    {
        List<List<char>> Save(string input);
    }
}