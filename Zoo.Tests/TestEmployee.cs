
using ZooLab.Employees;

namespace Zoo.Tests
{
    public class TestEmployee : IEmployee
    {
        string IEmployee.FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IEmployee.LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
