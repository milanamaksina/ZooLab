namespace ZooLab.Animals.Mammals
{
    public class Bison : Mammal
    {
        public int RequiredSpace = 1000;

        public override bool IsFriendlyWith(Animal animal)
        {
            if (animal.GetType() == typeof(Elephant))
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
