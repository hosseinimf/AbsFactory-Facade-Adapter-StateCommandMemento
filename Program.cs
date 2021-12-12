using Assignment2.AbstractFactory;
using Assignment2.Adapter;
using Assignment2.Facade;
using Assignment2.StateCommandMemento;
using Assignment2.StateCommandMemento.Memento;
using Assignment2.StateCommandMemento.Command;
using Assignment2.StateCommandMemento.State;
using System;
using System.Collections.Generic;

namespace Assignment2
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            //Console.WriteLine("Abstract Factory");
            //AbstractFactoryMain abstractFactory = new();
            //abstractFactory.Run();
            //Console.WriteLine();



            //Console.WriteLine("Facade");
            //FacadeMain facadeMain = new();
            //facadeMain.Run();
            //Console.WriteLine();




            //Console.WriteLine("Adapter");
            //AdapterMain adapterMain = new();
            //adapterMain.Run();
            //Console.WriteLine();




            Console.WriteLine("State Command Memento");
            SCMMain scmMain = new();
            scmMain.Run();
        }
    }
}