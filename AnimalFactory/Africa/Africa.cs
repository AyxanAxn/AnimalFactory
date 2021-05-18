using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFactory
{

    class Africa : CreateAnimals
    {
        public override GrassEatingAnimal grass()
        {
            return new AfricanHerbivore();
        }

        public override MeatEatingAnimal MeatEatingAnimal()
        {
            return new AfricanCarnivore();
        }
    }
}
