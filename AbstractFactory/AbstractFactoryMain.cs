using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.AbstractFactory
{
    class AbstractFactoryMain
    {
        // Skapa två fabriker som kan köra CreateAnimal() den ena fabriken ska skapa en hund och den andra en katt skapa sedan en abstract factory där man
        // får tillbaka en av de 2 fabrikerna beroende på en sträng parameter
        
        public void Run()
        {
            AnimalFactory AnimalFactory = new AnimalFactory();
            bool exit = true;
            while (exit)
            {
                Console.WriteLine("\nTo create Cat write: cat");
                Console.WriteLine("To create Dog write: dog");
                Console.WriteLine("To create Cat write: bird\n");
                var inputType = Console.ReadLine();

                Console.WriteLine($"Write the name of your {inputType.ToLower()}");
                var inputName = Console.ReadLine();

                var animal = AnimalFactory.CreateAnimal(inputType, inputName);

                Console.WriteLine("\nTo exit press e or E");

                var exitChar = Console.ReadKey(true).KeyChar;

                if (exitChar == 'e' || exitChar == 'E')
                {
                    exit = false;
                }
            }//while          
        }//run
    }
}
