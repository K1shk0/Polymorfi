using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfi
{
    internal class Animalstyper
    {
        public static Animal CreateAnimal(animalsenum animalType, string name)
        {
            return animalType switch
            {
                animalsenum.Dog => new Dog(name),
                animalsenum.Cat => new Cat(name),
                animalsenum.Sheep => new Sheep(name),
                _ => null
            };
        }
        public static Animal CreateAnimal(animalsenum animalType)
        {
            return animalType switch
            {
                animalsenum.Dog => new Dog("Spyres"),
                animalsenum.Cat => new Cat("Udolfo"),
                animalsenum.Sheep => new Sheep("VUFFEN"),
                _ => null
            };
        }
    }
}
