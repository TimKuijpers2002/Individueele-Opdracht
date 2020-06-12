using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    public class Wagon
    {
        public List<Animal> Animals = new List<Animal>();
        public int Space { get; private set; } = (int) Animal.Sizes.full;

        public Animal.Sizes BiggestCarnivore(List<Animal> animals) 
        {
            List<Animal> Carnivores = animals.Where(Animal => Animal.isCarnivore).ToList();

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
            if(animal.Size > BiggestCarnivore(Animals) && (int) animal.Size <= Space)
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
