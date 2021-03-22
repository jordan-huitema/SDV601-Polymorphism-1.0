using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class Zoo
    {
        private readonly List<Animal> _animals;

        public Zoo()
        {
            _animals = new List<Animal>();
        }

        public List<Animal> Animals { get => _animals; }

        public string About()
        {
            StringBuilder result = new StringBuilder();
            foreach (Animal animal in _animals)
            {
                result.AppendLine(animal.About());
            }
            return result.ToString();
        }
    }
}
