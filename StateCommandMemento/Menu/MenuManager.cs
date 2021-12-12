using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento.Menu
{
    public class MenuManager : IMenuManager
    {
        public void ShowMainMenu(bool isOn)
        {
            Console.Clear();
            DisplayMachineState(isOn);

            if (isOn)
            {
                Console.WriteLine("\npress P to turn Off the machine");
                Console.WriteLine("press D to run the commands if exists");
                Console.WriteLine("press R to reset the commands and turn off");
                Console.WriteLine("press E to exit \n");
            }
            else
            {
                Console.WriteLine("\npress P to turn On the machine");
                Console.WriteLine("press C to write commands");
                Console.WriteLine("press R to reset the commands and turn off");
                Console.WriteLine("press Q to exit \n");
            }
            
        }

        public void ShowCommandMenu(bool isON)
        {
            
            if (!isON)
            {
                Console.Clear();
                DisplayMachineState(isON);
                Console.WriteLine("\nWrite your messages/commands (seperate messages by space or \"/\")");
                Console.WriteLine("Otherwise write \"exit\" to exit from command\n");
            }
        }

        public void DisplayMachineState(bool isOn)
        {
            if (isOn)
                Console.WriteLine("The machine is     ---ON--- \n");
            else
                Console.WriteLine("The machine is     ---OFF--- \n");
        }
    }
}
