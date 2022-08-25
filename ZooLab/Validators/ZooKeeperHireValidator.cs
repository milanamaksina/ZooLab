using ZooLab.Employees;

namespace ZooLab.Validators
{
    public class ZooKeeperHireValidator: IHireValidator
    {
        public List<ValidationError> ValidateEmployee(IEmployee employee, Zoo zoo)
        {
            var possibleWorker = employee as ZooKeeper;
            List<ValidationError> errors = new();

            foreach (var enclosure in zoo.Enclosures)
            {
                foreach (var creature in enclosure.Animals)
                {
                    if (!possibleWorker.Experience.Contains(creature.GetType().Name))
                    {
                        errors.Add(new ValidationError($"{possibleWorker.FirstName} {possibleWorker.LastName} has no expirience with {creature.GetType().Name}"));
                    }
                }
            }
            return errors;
        }
    }
}
