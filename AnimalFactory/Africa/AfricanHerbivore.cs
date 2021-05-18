using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFactory
{
    class AfricanHerbivore : GrassEatingAnimal
    {
        public string Type { get; set; }
       
      
        public AfricanHerbivore()
        {
            Type = "African Herbivore";
       
        }
    }
}
