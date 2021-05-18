using System;

namespace AnimalFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-'Africa'\n2-'America'");
            string choice;
            choice = Console.ReadLine();
            CreateAnimals createAnimals = null;
            if (choice=="1")
            {
                createAnimals = new Africa();
            }
            else if (choice=="2")
            {
                createAnimals = new America();
            }

            else
            {
                Console.WriteLine("What is it");
            }
            Console.WriteLine(createAnimals.MeatEatingAnimal().Type);
            Console.WriteLine(createAnimals.grass().Type);

        }
    }
}
