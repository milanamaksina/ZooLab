﻿namespace ZooLab.Employees
{
    public class ZooKeeper: IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AnimalExperiences { get; set; }

        public void AddAnimalExperience(Animal animal)
        {

        }

        public bool HasAnimalExperience()
        {
            return false;
        }

        public bool FeedAnimal()
        {
            return true;
        }
    }

}
