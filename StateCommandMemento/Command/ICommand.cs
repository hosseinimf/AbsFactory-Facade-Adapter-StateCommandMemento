using Assignment2.StateCommandMemento.Memento;
using Assignment2.StateCommandMemento.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento.Command
{
    public interface ICommand
    {
        public IWriter Writer { get; set; }
        public string Message { get; set; }
        public List<string> MessageList { get; set; }
        public IState State { get; set; }
        public Machine machine { get; set; }
        public Message _originator { get; set; }
        public List<MessageMemento> mementoList { get; set; }
        void Do();
        void Undo();
    }
}
