using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFactory
{
    abstract class CreateAnimals
    {
        public abstract MeatEatingAnimal MeatEatingAnimal();
        public abstract GrassEatingAnimal grass();
    }
}
