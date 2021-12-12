using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento.State
{
    class StateOff : IState
    {
        private Machine _machine;

        public StateOff(Machine machine)
        {
            _machine = machine;
        }

        public void PowerSwitch()
        {
            _machine.IsOn = false;
            Console.WriteLine("The machine is TURNING OFF ... \n");
            System.Threading.Thread.Sleep(400);
        }

    }
}
