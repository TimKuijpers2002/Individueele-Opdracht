using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CircusTrein.UnitTests
{
    [TestClass]
    public class WagonTests
    {
        [TestMethod]
        public void BiggestCarnivore_ContainsNoCarnivore_ReturnsNone()
        {
            //Arrange
            Animal animal1 = new Animal(Animal.Sizes.big, false);
            var wagon = new Wagon();
            List<Animal> animals = new List<Animal> { animal1, animal1, animal1 };

            //Act
            var result = wagon.BiggestCarnivore(animals);

            //Assert
            Assert.AreEqual(Animal.Sizes.none, result);
        }

        [TestMethod]
        public void TryAddAnimal_AnimalFits_ReturnsTrue()
        {
            //Arrange
            var wagon = new Wagon();
            List<Animal> animals = wagon.Animals;
            animals.Add(new Animal(Animal.Sizes.small, true));

            //Act
            var result = wagon.TryAddAnimal(new Animal(Animal.Sizes.medium, false));

            //Assert
            Assert.IsTrue(result);
        }
    }
}
