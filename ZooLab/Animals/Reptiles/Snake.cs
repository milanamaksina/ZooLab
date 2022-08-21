namespace ZooLab.Animals.Reptiles
{
    public class Snake : Reptile
    {
        public int RequiredSpace = 2;

        public override bool IsFriendlyWith(Animal animal)
        {
            if (animal.GetType() == typeof(Snake))
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
