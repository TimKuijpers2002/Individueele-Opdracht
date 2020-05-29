using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    class Train
    {
        public List<Wagon> Wagons = new List<Wagon>();

        public Wagon AddAnimalToNewWagon(Animal animal)
        {
            Wagon NewWagon = new Wagon();
            NewWagon.TryAddAnimal(animal);
            Wagons.Add(NewWagon);
            return NewWagon;
        }

        public List<Animal> SortAnimals(List<Animal> unorderAnimals)
        {
            return unorderAnimals.OrderByDescending(Animal => Animal.isCarnivore)
                                    .ThenByDescending(Animal => (int)Animal.Size)
                                    .ToList();
        }

        public void FillWagon(List<Animal> Animals)
        {
            Animals = SortAnimals(Animals);
            foreach(Animal SelectedAnimal in Animals)
            {
                if (SelectedAnimal.isCarnivore)
                {
                    AddAnimalToNewWagon(SelectedAnimal);
                }
                else
                {
                    bool AnimalHasPlace = false;

                    foreach (Wagon SelectedWagon in Wagons)
                    {
                        AnimalHasPlace = SelectedWagon.TryAddAnimal(SelectedAnimal);
                        if (AnimalHasPlace) break;
                    }

                    if (!AnimalHasPlace)
                    {
                        AddAnimalToNewWagon(SelectedAnimal);
                    }
                }
            }
        }
    }
}
