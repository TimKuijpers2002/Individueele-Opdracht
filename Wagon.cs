using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    class Wagon
    {
        public List<Animal> Animals = new List<Animal>();
        public int Space { get; private set; } = 10;

        private Animal.Sizes BiggestCarnivore()
        {
            List<Animal> Carnivores = Animals.Where(Animal => Animal.isCarnivore).ToList();

            if(Carnivores.Count == 0)
            {
                return Animal.Sizes.none;
            } else
            {
                return Carnivores.First().Size;
            }
        }

        public bool TryAddAnimal(Animal animal)
        {
            if(animal.Size > BiggestCarnivore() && (int) animal.Size <= Space)
            {
                Animals.Add(animal);
                Space -= (int)animal.Size;
                return true;
            }else
            {
                return false;
            }
        }
    }
}
