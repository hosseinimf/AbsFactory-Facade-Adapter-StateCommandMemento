using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.AbstractFactory
{
    public class AnimalFactory : AbstractFactory
    {
        /// <summary>
        /// type is for the type of the animal
        /// name is for the name of the animal
        /// </summary>
        /// <param name="type"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public override FactoryDataItem CreateAnimal(string type, string name)
        {
            FactoryDataItem factoryDataItem = null;
            string typeLower = type.ToLower();
            switch (typeLower)
            {
                case "cat":
                    factoryDataItem = new FactoryDataItem(new Cat(name));
                    break;

                case "dog":
                    factoryDataItem = new FactoryDataItem(new Dog(name));
                    break;

                case "bird":
                    factoryDataItem = new FactoryDataItem(new Bird(name));
                    break;

                default:
                    Console.WriteLine("No valid type");
                    break;
            }


            return factoryDataItem;
        }
    }
}
