using Assignment2.StateCommandMemento.Command;
using Assignment2.StateCommandMemento.Memento;
using Assignment2.StateCommandMemento.Menu;
using Assignment2.StateCommandMemento.State;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment2.StateCommandMemento
{
    internal class SCMMain
    {
        /*
         * Skapa en maskin som kan vara av eller på. !Använd State Pattern!
         * Om man ger den ett kommando när den är av så ska den spara det kommandot och sen köra alla sparade kommandon när den sätts på. !Använd Command Pattern!
         * Kommandot ska vara att skriva ut en sträng text som användaren anger.
         * Det ska också finnas en reset funktion som tar bort alla sparade kommandon och stänger av maskinen. !Använd Memento Pattern!
         */

        IMenuManager menu = new MenuManager();

        public void Run()
        {         
            Machine machine = new Machine();
            Message message = new Message();
            IWriter writer = new Writer();
            ICommand writerCommand = new WriterCommand(writer);
            MessageCareTaker messageCareTaker = new MessageCareTaker(message, writerCommand);

            menu.ShowMainMenu(machine.IsOn);

            while (true)
            {
                var userChar = Console.ReadKey(true).KeyChar;
                switch (userChar)
                {
                    case 'p' or 'P':
                        machine.PowerSwitch();
                        menu.ShowMainMenu(machine.IsOn);
                        if (machine.IsOn)
                        {
                            writerCommand.Do();
                        }
                        break;

                    case 'c' or 'C':
                        var currentCommands = CreateCommands(machine.IsOn);
                        foreach (var item in currentCommands)
                        {
                            writerCommand.MessageList.Add(item);
                        }
                        break;

                    case 'r' or 'R':
                        messageCareTaker.Reset();
                        if (machine.IsOn)
                        {
                            machine.PowerSwitch();
                            System.Threading.Thread.Sleep(300);
                        }
                        
                        menu.ShowMainMenu(machine.IsOn);
                        break;

                    case 'q' or 'Q':
                        Environment.Exit(0);
                        break;
                }
            }
        }//----------------------------------------------------------------------------end Run-----------------------------------


        private List<string> CreateCommands(bool b)
        {
            List<string> commandList = new List<string>();

            if (!b)
            {
                bool commandBool = true;
                menu.ShowCommandMenu(b);
                while (commandBool)
                {

                    var userString = Console.ReadLine();
                    if (String.Concat(userString.Where(c => !char.IsWhiteSpace(c))) == "exit")
                    {
                        menu.ShowMainMenu(b);
                        commandBool = false;
                        break;
                    }
                    var userCommandsList = userString.Split('/', ' ').ToList();

                    foreach (var item in userCommandsList)
                    {
                        commandList.Add(item);
                    }
                    menu.ShowCommandMenu(b);
                }
            }
            return commandList;           
        }







    }
}