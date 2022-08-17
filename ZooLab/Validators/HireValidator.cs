using ZooLab.Employees;

namespace ZooLab.Validators
{
    public abstract class HireValidator : IHireValidator
    {
        public void ValidateEmployee(IEmployee employee, Zoo zoo)
        {
            throw new NotImplementedException();
        }
    }
}
