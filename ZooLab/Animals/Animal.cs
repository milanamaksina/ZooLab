using ZooLab.FoodForAnimals;
using ZooLab.Medicines;

namespace ZooLab
{
    public abstract class Animal
    {
        public int Id { get; set; }
        public int RequiredSpace { get; set; }
        public string[] FavoriteFood { get; set; }
        public List<FeedTime> FeedTimes { get; set; }
        public List<int> FeedSchedule { get; set; } = new List<int>();
        public string NeededMedicine { get; } = new string[3] { "Antibiotics", "AntiDepression", "AntiInflammatory" }[new Random().Next(0, 3)];
        public bool IsSick { get; set; } = (new Random().Next(0, 10) > 5);
        public bool IsHungry { get; set; } = (new Random().Next(0, 10) > 5);

        public abstract bool IsFriendlyWith(Animal animal);

        public void Feed(Food food, IConsole zooConsole = null)
        {
            foreach (var anyFood in FavoriteFood)
            {
                if (food.GetType().Name == anyFood)
                {
                    IsHungry = false;
                }
            }
        }

        public void AddFeedShedule(List<int> hours)
        {
            FeedSchedule = hours;
        }

        public void Heal(Medicine medicine)
        {
            if (medicine.GetType().Name == NeededMedicine)
            {
                IsSick = false;
            }
        }

    }
}
