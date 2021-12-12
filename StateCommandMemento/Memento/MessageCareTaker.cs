using Assignment2.StateCommandMemento.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento.Memento
{
    public class MessageCareTaker
    {

        private Message _originator;
        public List<MessageMemento> mementosList;
        private ICommand _writerCommand;

        public MessageCareTaker(Message originator, ICommand writerCommand)
        {
            _originator = originator;
            mementosList = new List<MessageMemento>();
            _writerCommand = writerCommand;
        }

        public void Backup()
        {
            var memento = _originator.Backup();
            mementosList.Add(memento);
        }

        public void Undo()
        {
            if (mementosList.Count == 0)
            {
                return;
            }
            var memento = mementosList.Last();
            _originator.Undo(memento);
            mementosList.Remove(memento);
        }

        public void Reset()
        {
            if (mementosList.Count > 0)
            {
                mementosList.Clear();
                Console.WriteLine("Memento list is cleared.");
                System.Threading.Thread.Sleep(600);
            }
            if (_writerCommand.MessageList.Count > 0)
            {
                _writerCommand.MessageList.Clear();
                Console.WriteLine("Command list is cleared.");
                System.Threading.Thread.Sleep(600);
            }
        }


    }
}
