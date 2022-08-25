using ZooLab.Animals.Mammals;
using ZooLab.Animals.Reptiles;

namespace ZooLab.Animals.Birds
{
    public class Parrot : Bird
    {
        public int RequiredSpace = 5;
        public string FavoriteFood = "Vegetable";

        public override bool IsFriendlyWith(Animal animal)
        {
            if (animal.GetType() == typeof(Parrot) ||
                animal.GetType() == typeof(Bison) ||
                animal.GetType() == typeof(Turtle) ||
                animal.GetType() == typeof(Elephant))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
