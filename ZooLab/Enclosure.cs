using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooLab.Exceptions;

namespace ZooLab
{
    public class Enclosure
    {
        public string Name { get; set; }
        public List<Animal> Animals { get; set; }
        public Zoo BaseZoo { get; set; }
        public int SqureFeet { get; set; }

        public Enclosure(Zoo parentZoo, string name, int squreFeet)
        {
            ParentZoo = parentZoo;
            Name = name;
            SqureFeet = squreFeet;
        }

        public void AddAnimals(Animal animal)
        {
            if (SqureFeet >= animal.RequiredSpace)
            {
                foreach (var creature in Animals)
                {
                    if (!creature.IsFriendlyWith(animal))
                    {
                        throw new NotFriendlyAnimalException();
                    }
                }
                Animals.Add(animal);
                animal.Id = BaseZoo.StartingId;
                BaseZoo.StartingId++;
                SqureFeet -= animal.RequiredSpace;
            }
            else
            {
                throw new NoAvailableSpaceException();
            }
        }

        public bool IsFriendlyTo(Animal animal)
        {
            foreach (var creature in Animals)
            {
                if (!creature.IsFriendlyWith(animal))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
