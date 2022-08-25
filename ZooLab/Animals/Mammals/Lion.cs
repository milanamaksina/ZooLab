namespace ZooLab.Animals.Mammals
{
    public class Lion : Mammal
    {
        public int RequiredSpace = 1000;

        public override bool IsFriendlyWith(Animal animal)
        {
            if (animal.GetType() == typeof(Lion))
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
