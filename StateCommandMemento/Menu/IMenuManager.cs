namespace Assignment2.StateCommandMemento.Menu
{
    public interface IMenuManager
    {
        public void ShowMainMenu(bool isOn);
        public void ShowCommandMenu(bool isON);
        public void DisplayMachineState(bool isOn);
    }
}