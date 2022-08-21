using ZooLab.Animals.Birds;
using ZooLab.Animals.Mammals;

namespace ZooLab.Animals.Reptiles
{
    public class Turtle : Animal
    {
        public int RequiredSpace = 5;

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
