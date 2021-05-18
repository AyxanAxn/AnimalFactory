using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFactory
{
    class AmericanHernivore : GrassEatingAnimal
    {
        public string Type { get ; set ; }
        public AmericanHernivore()
        {
            Type = "Grass eating animal in New York :-|";
        }
    }
}
