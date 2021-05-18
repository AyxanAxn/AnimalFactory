using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFactory
{
    class America : CreateAnimals
    {
        public override GrassEatingAnimal grass()
        {
            return new AmericanHernivore();
        }

        public override MeatEatingAnimal MeatEatingAnimal()
        {
            return new AmericanCornivore();
        }
    }
}
