using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooLab
{
    public abstract class Animal
    {
        public int Id { get; set; }
        public int RequiredSpaceSqFt { get; set; }
        public string FavoriteFood { get; set; }
        public List<FeedTime> FeedTimes { get; set; }
        public List<int> FeedSchedule { get; set; }

        public abstract bool IsFriendlyWith(Animal animal)
        {

        }

        public void Feed()
        {

        }

        public void AddFeedSchedule(List<int> hours)
        {

        }

        public void Heal(Medicine medicine)
        {

        }

    }
}
