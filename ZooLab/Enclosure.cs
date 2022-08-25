﻿using System;
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
        public Zoo Zoo { get; set; }
        public int SqureFeet { get; set; }

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
                animal.Id = ParentZoo.StartingId;
                ParentZoo.StartingId++;
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
