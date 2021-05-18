using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFactory
{
    class AfricanCarnivore : MeatEatingAnimal
    {
        public string Type { get; set; }
     

        public AfricanCarnivore()
        {
            Type = "African Carnivore";
            
        }
    }
}
