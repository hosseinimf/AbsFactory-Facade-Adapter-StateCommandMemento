using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento.Memento
{
    public class Message
    {
        public string TextMessage { get; set; }


        public MessageMemento Backup()
        {
            MessageMemento memento = new MessageMemento
            {
                TextMessage = TextMessage
            };
            return memento;
        }

        public void Undo(MessageMemento snapshot)
        {
            TextMessage = snapshot.TextMessage;
        }




    }
}
