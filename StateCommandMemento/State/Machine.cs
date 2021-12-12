using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento.State
{
    public class Machine : IState
    {
        public IState MachineState { get; set; }
        public bool IsOn { get; set; }

        public Machine()
        {
            MachineState = new StateOff(this);
        }

        public void PowerSwitch()
        {
            

            if (MachineState is StateOff)
            {
                MachineState = new StateOn(this);
                MachineState.PowerSwitch();
            }
            else
            {
                MachineState = new StateOff(this);
                MachineState.PowerSwitch();
            }
        }

        
    }
}
