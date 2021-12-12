using Assignment2.StateCommandMemento;
using Assignment2.StateCommandMemento.Memento;
using Assignment2.StateCommandMemento.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento.Command
{
    internal class WriterCommand : ICommand
    {
        
        public IWriter Writer { get; set; }
        public string Message { get; set; }
        public List<string> MessageList { get; set; }
        public IState State { get; set; }
        public Machine machine { get; set; }
        public Message _originator { get; set; }
        public List<MessageMemento> mementoList { get; set; }
        public MessageCareTaker messageCareTaker { get; set; }


        public WriterCommand(IWriter writer)
        {
            Writer = writer;
            machine = new Machine();
            _originator = new Message();
            MessageList = new();
            mementoList = new();
            messageCareTaker = new MessageCareTaker(_originator, this);
        }



        public void Do()
        {
            if (MessageList.Count > 0)
            {
                bool w = true;
                while (w)
                {
                    Console.WriteLine("\npress D ----> to run the commands");
                    Console.WriteLine("press U ----> to undo the commands one by one");
                    Console.WriteLine("press E ----> to go to main menu");
                    var userChar = Console.ReadKey(true).KeyChar;

                    switch (userChar)
                    {
                        case 'd' or 'D':
                            foreach (var item in MessageList)
                            {
                                Console.Write($"\nwriting the command...    ");
                                System.Threading.Thread.Sleep(100);
                                Writer.Write(item);
                                System.Threading.Thread.Sleep(100);
                                messageCareTaker.Backup();
                                _originator.TextMessage = item;
                            }
                            break;

                        case 'u' or 'U':
                            messageCareTaker.Undo();
                            Console.Write($"\nUndoing the command...    ");
                            Writer.Write(_originator.TextMessage);
                            if (messageCareTaker.mementosList.Count < 1)
                                w = false;
                            break;

                        case 'e' or 'E':
                            w = false;

                            break;


                    }
                }//while end
                
                Console.WriteLine("\n*****Press p to turn off the machine******");
            }
            else
            {
                Console.WriteLine("There is no command in the list.");
            }
        }

        public void Undo()
        {
            Console.WriteLine("Undoing from writer command");
        }
    }
}
