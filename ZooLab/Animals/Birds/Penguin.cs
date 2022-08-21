namespace ZooLab.Animals.Birds
{
    public class Penguin : Bird
    {
        public int RequiredSpace = 10;

        public override bool IsFriendlyWith(Animal animal)
        {
            if (animal.GetType() == typeof(Penguin))
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
