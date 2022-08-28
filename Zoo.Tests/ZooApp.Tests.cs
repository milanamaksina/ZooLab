using ZooLab;
using ZooLab.Animals.Mammals;
using ZooLab.Employees;
using ZooLab.Exceptions;
using ZooLab.FoodForAnimals;
using ZooLab.Medicines;

namespace Zoo.Tests
{
    public class ZooAppTests
    {
        [Fact]
        public void ShouldCreateZooApp()
        {
            ZooApp zooApp = new ZooApp();
        }

        [Fact]
        public void ShoulBeAbleToCreateZoo()
        {
            ZooLab.Zoo zoo = new ZooLab.Zoo();
        }

        [Fact]
        public void ShoulBeAbleToGetIdForAnimals()
        {
            ZooLab.Zoo zoo = new ZooLab.Zoo();
            Assert.Equal(1, zoo.StartingId);

        }

        [Fact]
        public void ShoulBeAbleToCreateZooWithLocation()
        {
            ZooLab.Zoo zoo = new ZooLab.Zoo("Zoo-1");
        }

        [Fact]
        public void ShoulBeAbleToGetEnclosures()
        {
            ZooLab.Zoo zoo = new ZooLab.Zoo();
            List<Enclosure> enclosures = zoo.Enclosures;
            Assert.Equal(enclosures, zoo.Enclosures);
        }

        [Fact]
        public void ShoulBeAbleToGetEmployees()
        {
            ZooLab.Zoo zoo = new ZooLab.Zoo();
            List<IEmployee> employees = zoo.Employees;
            Assert.Equal(employees, zoo.Employees);
        }

        [Fact]
        public void ShoulBeAbleToGetLocation()
        {
            ZooLab.Zoo zoo = new ZooLab.Zoo();
            string zooLoczation = zoo.Location;
        }

        [Fact]
        public void ShoulBeAbleToAddLocation()
        {
            ZooLab.Zoo zoo = new ZooLab.Zoo();
            string location = "Zoo-2";
            zoo.AddLocation(location);
            Assert.Equal(location, zoo.Location);
        }

        [Fact]
        public void ShoulBeAbleToAddEnclosure()
        {
            ZooLab.Zoo zoo = new ZooLab.Zoo();
            zoo.AddEnclosure("Lions Enclosure", 5000);

            Enclosure enclosure = zoo.Enclosures[0];
            string enclosureName = enclosure.Name;
            int enclosureArea = enclosure.SqureFeet;

            Assert.Equal("Lions Enclosure", enclosureName);
            Assert.Equal(5000, enclosureArea);
        }


        [Fact]
        public void ShouldThrowExeptionIfEnclosureNotFound()
        {
            ZooLab.Zoo zoo = new ZooLab.Zoo();
            Lion lion = new();

            Assert.Throws<NoAvailableEclosureException>(() => {
                zoo.FindAvailableEnclosure(lion);
            });
        }




    }
}