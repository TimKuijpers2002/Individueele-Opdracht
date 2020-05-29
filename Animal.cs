using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    public class Animal
    {
        public enum Sizes
        {
            small = 1,
            medium = 3,
            big = 5,
            none = 0
        }

        public Sizes Size;
        public bool isCarnivore { get; set; }

        public Animal(Sizes size, bool iscarnivore)
        {
            Size = size;
            isCarnivore = iscarnivore;
        }

        public override string ToString()
        {
            string species;
            if (isCarnivore)
            {
                species = "Carnivore";
            }else
            {
                species = "Herbivore";
            }

            return $"{Size} {species}";
        }

    }
}
