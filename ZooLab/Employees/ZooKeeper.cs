using ZooLab.Exceptions;
using ZooLab.FoodForAnimals;

namespace ZooLab.Employees
{
    public class ZooKeeper: IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<string> Experience = new List<string>();
        public List<Food> AvailableFood { get; set; } = new List<Food>();

        public ZooKeeper(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void AddAnimalExperience(Animal animal)
        {
            if (!Experience.Contains(animal.GetType().ToString()))
            {
                Experience.Add(animal.GetType().Name);
            }
        }

        public bool HasAnimalExperience(Animal animal)
        {
            foreach (var creature in Experience)
            {
                if (creature == animal.GetType().Name)
                {
                    return true;
                }
            }
            throw new NoNeededExperienceException();
        }

        public bool FeedAnimal(Animal animal, IConsole zooConsole = null)
        {
            if (HasAnimalExperience(animal) && (animal.IsHungry ||
                                                animal.FeedSchedule.Count > 0 && animal.FeedSchedule[0] > Convert.ToInt32(DateTime.Now.Hour) ||
                                                animal.FeedSchedule[1] > Convert.ToInt32(DateTime.Now.Hour)))
            {
                foreach (var favoriteFood in animal.FavoriteFood)
                {
                    foreach (var availableFood in AvailableFood)
                    {
                        if (favoriteFood == availableFood.GetType().Name)
                        {
                            animal.Feed(availableFood);
                            FeedTime feedTime = new();
                            feedTime.FeedTimes = DateTime.Now;
                            zooConsole?.WriteLine($"{animal.GetType().Name} was fed by {this.FirstName} {this.LastName} at {feedTime.TimeToFeed}");
                            feedTime.FeedByZooKeeper = this;
                            animal.FeedTimes.Add(feedTime);
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }

}
