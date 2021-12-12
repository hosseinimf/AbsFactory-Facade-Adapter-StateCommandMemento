using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento.Command
{
    public class WriterManager
    {

        private Writer _writer { get; set; }
        private List<ICommand> _commandList { get; set; }

        public WriterManager()
        {
            _writer = new();
            _commandList = new();
        }

        public void Redo()
        {
            Console.WriteLine("Redo...");
            var command = _commandList.LastOrDefault();
            if (command is not null)
            {
                _commandList.LastOrDefault().Do();
                _commandList.Add(command);
            }
            else
            {
                Console.WriteLine("No command found.");
            }
        }


        public void Undo()
        {
            Console.WriteLine("Undo...");
            var command = _commandList.LastOrDefault();

            if (command is not null)
            {
                command.Undo();
                _commandList.RemoveAt(_commandList.Count - 1);
            }
            else
            {
                Console.WriteLine("No command found.");
            }
        }


        public void Execute(string message)
        {
            
        }




    }
}
