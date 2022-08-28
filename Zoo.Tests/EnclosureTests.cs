using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooLab;
using ZooLab.Animals.Mammals;
using ZooLab.Animals.Reptiles;
using ZooLab.Exceptions;

namespace Zoo.Tests
{
    public class EnclosureTests
    {
        [Fact]
        public void ShouldBeAbleToCreateEnclosureWithNameAreaAndParentZoo()
        {
            Enclosure enclosure = new Enclosure(new ZooLab.Zoo(), "anyName", 5);
        }

        [Fact]
        public void ShouldBeAbleToGetName()
        {
            Enclosure enclosure = new Enclosure(new ZooLab.Zoo(), "Some name", 1000);
            string anyName = enclosure.Name;
        }

        [Fact]
        public void ShouldBeAbleToGetAnimals()
        {
            Enclosure enclosure = new Enclosure(new ZooLab.Zoo(), "Some name", 1000);
            List<Animal> animals = enclosure.Animals;
        }

        [Fact]
        public void ShouldBeAbleToGetParentZoo()
        {
            Enclosure enclosure = new Enclosure(new ZooLab.Zoo(), "Some name", 1000);
            ZooLab.Zoo anyZoo = enclosure.BaseZoo;
        }

        [Fact]
        public void ShouldBeAbleToGetSquareFeet()
        {
            Enclosure enclosure = new Enclosure(new ZooLab.Zoo(), "Some name", 1000);
            int anyArea = enclosure.SqureFeet;
        }

        
    }
}
