using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFactory
{
    class AmericanCornivore : MeatEatingAnimal
    {
        public string Type { get; set; }
        public AmericanCornivore()
        {
            Type = "American cornivore";
        }
    }
}
