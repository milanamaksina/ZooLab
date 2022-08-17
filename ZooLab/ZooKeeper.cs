using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooLab
{
    public class ZooKeeper
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
