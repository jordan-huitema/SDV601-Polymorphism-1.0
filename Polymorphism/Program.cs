using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var zoo = new Zoo();

            var lion = new Lion()
            {
                Name = "Cleopatra"
            }; 
            zoo.Animals.Add(lion);

            var tiger = new Tiger
            {
                Name = "Paprika"
            };
            zoo.Animals.Add(tiger);

            var mouse = new Mouse
            {
                Name = "Hercules"
            };

            zoo.Animals.Add(mouse);

            Console.WriteLine(zoo.About());

            Console.ReadKey();
        }
    }
}
