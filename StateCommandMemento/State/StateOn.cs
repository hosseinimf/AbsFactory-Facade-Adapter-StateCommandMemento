using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento.State
{
    class StateOn : IState
    {
        private Machine _machine;


        public StateOn(Machine machine)
        {
            _machine = machine;
        }

      
        public void PowerSwitch()
        {
            _machine.IsOn = true;
            Console.WriteLine("The machine is TURNING ON ... \n");
            System.Threading.Thread.Sleep(400);
        }
    }
}
