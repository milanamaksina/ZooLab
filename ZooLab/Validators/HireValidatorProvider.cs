using ZooLab.Employees;

namespace ZooLab.Validators
{
    public class HireValidatorProvider
    {
        public IHireValidator GetIHireValidator(IEmployee employee, Zoo zoo)
        {
            if (employee.GetType().Name == typeof(ZooKeeper).Name)
            {
                return new ZooKeeperHireValidator();
            }
            if (employee.GetType().Name == typeof(Veterinarian).Name)
            {
                return new VeterinarianHireValidator();
            }
            throw new Exception();
        }
    }

}
