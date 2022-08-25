using ZooLab.Employees;

namespace ZooLab.Validators
{
    public interface IHireValidator
    {
        List<ValidationError> ValidateEmployee(IEmployee employee, Zoo zoo);
    }
}
