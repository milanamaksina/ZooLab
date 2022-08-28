using ZooLab.Employees;
using ZooLab.Validators;

namespace Zoo.Tests
{
    public class ValidatorTests
    {
        [Fact]
        public void ShouldBeAbleToCreateHireValidatorProvider()
        {
            HireValidatorProvider hireValidatorProvider = new();
        }

        [Fact]
        public void ShouldBeAbleToGetHireValidatorThenForEmployee()
        {
            HireValidatorProvider hireValidatorProvider = new();
            IEmployee zooKeeper = new ZooKeeper("First Name", "LastName");
            IHireValidator hireValidator = hireValidatorProvider.GetHireValidator(zooKeeper);

            IEmployee veterinarian = new Veterinarian("First Name", "Last Name");
            IHireValidator anotherHireValidator = hireValidatorProvider.GetHireValidator(veterinarian);
        }

        [Fact]
        public void ShouldThrowExeptionIfWrongEmployee()
        {
            HireValidatorProvider hireValidatorProvider = new();
            IEmployee testEmployee = new TestEmployee();
            Assert.Throws<Exception>(() => hireValidatorProvider.GetHireValidator(testEmployee));
        }

        [Fact]
        public void ShouldBeAbleToCreateValidationErrorWithErrorText()
        {
            ValidationError validationError = new("Error happend!");
        }

        [Fact]
        public void ShouldBeAbleToGetValidationError()
        {
            ValidationError validationError = new("Error happend!");
            string errorMessage = validationError.ErrorMessage;
            Assert.Equal(validationError.ErrorMessage, errorMessage);
        }

        [Fact]
        public void ShouldBeAbleToCreateVeterinarianHireValidator()
        {
            VeterinarianHireValidator veterinarianHireValidator = new();
        }

        [Fact]
        public void ShouldBeAbleToCreateZooKeeperHireValidator()
        {
            ZooKeeperHireValidator zooKeeperHireValidator = new();

        }

        [Fact]
        public void ShouldBeAbleToValidateEmployeeAsZooKeeper()
        {
            ZooLab.Zoo zoo = new ZooLab.Zoo();
            ZooKeeperHireValidator zooKeeperHireValidator = new();
            IEmployee employee = new ZooKeeper("First Name", "Last Name");
            List<ValidationError> errors = zooKeeperHireValidator.ValidateEmployee(employee, zoo);
        }
    }
}
