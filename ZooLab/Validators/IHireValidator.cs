using ZooLab.Employees;

namespace ZooLab.Validators
{
    public interface IHireValidator
    {
        void ValidateEmployee(IEmployee employee, Zoo zoo);
    }
}
