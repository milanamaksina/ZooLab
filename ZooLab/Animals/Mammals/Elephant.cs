using ZooLab.Animals.Birds;
using ZooLab.Animals.Reptiles;

namespace ZooLab.Animals.Mammals
{
    public class Elephant : Mammal
    {
        public int RequiredSpace = 1000;
       
        public override bool IsFriendlyWith(Animal animal)
        {
            if (animal.GetType() == typeof(Parrot) ||
                animal.GetType() == typeof(Bison) ||
                animal.GetType() == typeof(Turtle)) 
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
