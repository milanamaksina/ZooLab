using ZooLab.Exceptions;
using ZooLab.Medicines;

namespace ZooLab.Employees
{
    public class Veterinarian: IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<string> Experience = new List<string>();
        public List<Medicine> AvailableMedicine { get; set; } = new List<Medicine>();

        public Veterinarian(string firstName, string lastName)
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

        public bool HealAnimal(Animal animal)
        {
            if (HasAnimalExperience(animal) && animal.IsSick)
            {
                foreach (var medicine in AvailableMedicine)
                {
                    if (medicine.GetType().Name == animal.NeededMedicine)
                    {
                        animal.Heal(medicine);
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
