using ZooLab.Animals.Birds;
using ZooLab.Animals.Mammals;
using ZooLab.Animals.Reptiles;

namespace Zoo.Tests
{
    public class EntitiesTests
    {
        [Fact]
        public void ShoulBeAbleToCreateBison()
        {
            Bison bison = new();
        }

        [Fact]
        public void ShoulRequire1000SqFeet()
        {
            Bison bison = new();
            int requiredArea = bison.RequiredSpace;
            Assert.Equal(1000, requiredArea);
        }


        [Fact]
        public void ShouldBeAbleToAddFeedShedule()
        {
            Bison bison = new();
            List<int> feedHours = new List<int>();
            feedHours.Add(9);
            feedHours.Add(18);
            bison.AddFeedShedule(feedHours);

            Assert.Equal(bison.FeedSchedule, feedHours);
        }

        [Fact]
        public void ShouldBeFriendlyWithElephants()
        {
            Bison bison = new();
            Elephant elephant = new();

            bool isFrindlyWithElephants = bison.IsFriendlyWith(elephant);
            Assert.True(isFrindlyWithElephants);
        }

        [Fact]
        public void ShouldNotBeFriendlyWithOtherAnimals()
        {
            Bison bison = new();
            Lion lion = new();
            Penguin penguin = new();
            Parrot parrot = new();
            Turtle turtle = new();
            Snake snake = new();

            Assert.False(bison.IsFriendlyWith(bison));
            Assert.False(bison.IsFriendlyWith(lion));
            Assert.False(bison.IsFriendlyWith(penguin));
            Assert.False(bison.IsFriendlyWith(parrot));
            Assert.False(bison.IsFriendlyWith(turtle));
            Assert.False(bison.IsFriendlyWith(snake));
        }

        [Fact]
        public void ShouldBeAbleToCreateElephant()
        {
            Elephant elephant = new();
        }

        [Fact]
        public void ShouldRequire1000dSqFeet()
        {
            Elephant elephant = new();
            Assert.Equal(1000, elephant.RequiredSpace);
        }

        [Fact]
        public void ShouldBeFriendlyWithBisons()
        {
            Elephant elephant = new();
            Bison bison = new();
            bool isFrindlyWithBisons = elephant.IsFriendlyWith(bison);
            Assert.True(isFrindlyWithBisons);
        }

        [Fact]
        public void ShouldBeFriendlyWithParrots()
        {
            Elephant elephant = new();
            Parrot parrot = new();
            bool isFriendlyWithParrots = elephant.IsFriendlyWith(parrot);
            Assert.True(isFriendlyWithParrots);
        }

        [Fact]
        public void ShouldBeFriendlyWithTurtles()
        {
            Elephant elephant = new();
            Turtle turtle = new();
            bool isFriendlyWithTurtles = elephant.IsFriendlyWith(turtle);
            Assert.True(isFriendlyWithTurtles);
        }

        [Fact]
        public void ElephantShouldNotBeFriendlyWithOtherAnimals()
        {
            Elephant elephant = new();
            Lion lion = new();
            Penguin penguin = new();
            Snake snake = new();

            Assert.False(elephant.IsFriendlyWith(elephant));
            Assert.False(elephant.IsFriendlyWith(lion));
            Assert.False(elephant.IsFriendlyWith(penguin));
            Assert.False(elephant.IsFriendlyWith(snake));
        }

        [Fact]
        public void ShouldBeAbleToCreateLion()
        {
            Lion lion = new();
        }

        [Fact]
        public void ShouldRequire1000SqFeet()
        {
            Lion lion = new();
            int requiredArea = lion.RequiredSpace;
            Assert.Equal(1000, requiredArea);
        }

        [Fact]
        public void ShouldBeFriendlyWithLions()
        {
            Lion firstLion = new();
            Lion secondLion = new();
            bool isFriendlyWithLions = firstLion.IsFriendlyWith(secondLion);
        }

        [Fact]
        public void LionShouldNotBeFriendlyWithOtherAnimals()
        {
            Lion lion = new();
            Elephant elephant = new();
            Bison bison = new();
            Penguin penguin = new();
            Parrot parrot = new();
            Turtle turtle = new();
            Snake snake = new();

            Assert.False(lion.IsFriendlyWith(elephant));
            Assert.False(lion.IsFriendlyWith(bison));
            Assert.False(lion.IsFriendlyWith(penguin));
            Assert.False(lion.IsFriendlyWith(parrot));
            Assert.False(lion.IsFriendlyWith(turtle));
            Assert.False(lion.IsFriendlyWith(snake));
        }

        [Fact]
        public void ShoulBeAbleToCreateParrot()
        {
            Parrot parrot = new();
        }

        [Fact]
        public void ShouldRequireFiveSqFeet()
        {
            Parrot parrot = new();
            int requiredArea = parrot.RequiredSpace;
            Assert.Equal(5, requiredArea);
        }

        [Fact]
        public void ShoulBeFriendlyWithParrots()
        {
            Parrot firstParrot = new();
            Parrot secondParrot = new();
            bool isFriendlyWithParrots = firstParrot.IsFriendlyWith(secondParrot);

            Assert.True(isFriendlyWithParrots);
        }

        [Fact]
        public void ShoulBeFriendlyWithBisons()
        {
            Parrot parrot = new();
            Bison bison = new();
            bool isFriendlyWithBisons = parrot.IsFriendlyWith(bison);

            Assert.True(isFriendlyWithBisons);
        }

        [Fact]
        public void ShoulBeFriendlyWithElephants()
        {
            Parrot parrot = new();
            Elephant elephant = new();
            bool isFriendlyWithElephants = parrot.IsFriendlyWith(elephant);

            Assert.True(isFriendlyWithElephants);
        }

        [Fact]
        public void ShoulBeFriendlyWithTurtles()
        {
            Parrot parrot = new();
            Turtle turtle = new();
            bool isFriendlyWithTurtles = parrot.IsFriendlyWith(turtle);

            Assert.True(isFriendlyWithTurtles);
        }

        [Fact]
        public void ShoulNotBeFriendlyWithLions()
        {
            Parrot parrot = new();
            Lion lion = new();

            Assert.False(parrot.IsFriendlyWith(lion));
        }

        [Fact]
        public void ShoulNotBeFriendlyWithSnakes()
        {
            Parrot parrot = new();
            Snake snake = new();

            Assert.False(parrot.IsFriendlyWith(snake));
        }

        [Fact]
        public void ShoulBeAbleToCreatePenguin()
        {
            Penguin penguin = new();
        }

        [Fact]
        public void ShouldRequireTenSqFeet()
        {
            Penguin penguin = new();
            int requiredArea = penguin.RequiredSpace;
            Assert.Equal(10, requiredArea);
        }


        [Fact]
        public void ShouldBeFriendlyWithPinguins()
        {
            Penguin firstPenguin = new();
            Penguin secondPenguin = new();

            bool isFriendlyWithPenguins = firstPenguin.IsFriendlyWith(secondPenguin);
            Assert.True(isFriendlyWithPenguins);
        }

        [Fact]
        public void PenguinShouldNotBeFriendlyWithOtherAnimals()
        {
            Penguin penguin = new();
            Parrot parrot = new();
            Bison bison = new();
            Elephant elephant = new();
            Lion lion = new();
            Snake snake = new();
            Turtle turtle = new();

            Assert.False(penguin.IsFriendlyWith(lion));
            Assert.False(penguin.IsFriendlyWith(bison));
            Assert.False(penguin.IsFriendlyWith(parrot));
            Assert.False(penguin.IsFriendlyWith(elephant));
            Assert.False(penguin.IsFriendlyWith(snake));
            Assert.False(penguin.IsFriendlyWith(turtle));
        }

        [Fact]
        public void ShoulBeAbleToCreateSnake()
        {
            Snake snake = new();
        }

        [Fact]
        public void ShouldRequire2sqFeet()
        {
            Snake snake = new();
            int requiredArea = snake.RequiredSpace;
            Assert.Equal(2, requiredArea);
        }


        [Fact]
        public void ShouldBeFriendlyWithSnakes()
        {
            Snake firstSnake = new();
            Snake secondSnake = new();

            bool isFriendlyWithSnakes = firstSnake.IsFriendlyWith(secondSnake);

            Assert.True(isFriendlyWithSnakes);
        }

        [Fact]
        public void SnakeShouldNotBeFriendlyWithOtherAnimals()
        {
            Snake snake = new();
            Lion lion = new();
            Elephant elephant = new();
            Bison bison = new();
            Penguin penguin = new();
            Parrot parrot = new();
            Turtle turtle = new();

            Assert.False(snake.IsFriendlyWith(lion));
            Assert.False(snake.IsFriendlyWith(elephant));
            Assert.False(snake.IsFriendlyWith(bison));
            Assert.False(snake.IsFriendlyWith(penguin));
            Assert.False(snake.IsFriendlyWith(parrot));
            Assert.False(snake.IsFriendlyWith(turtle));
        }

        [Fact]
        public void ShoulBeAbleToCreateTurtle()
        {
            Turtle turtle = new();
        }

        [Fact]
        public void ShoulRequire5SqFeet()
        {
            Turtle turtle = new();
            int requiredArea = turtle.RequiredSpace;
            Assert.Equal(5, requiredArea);
        }


        [Fact]
        public void TurtleShoulBeFriendlyWithTurtles()
        {
            Turtle firstTurtle = new();
            Turtle secondTurtle = new();

            bool isFriendlyWithTurtles = firstTurtle.IsFriendlyWith(secondTurtle);
            Assert.True(isFriendlyWithTurtles);
        }

        [Fact]
        public void TurtleShoulBeFriendlyWithParrots()
        {
            Turtle turtle = new();
            Parrot parrot = new();

            bool isFriendlyWithParrots = turtle.IsFriendlyWith(parrot);
            Assert.True(isFriendlyWithParrots);
        }

        [Fact]
        public void TurtleShoulBeFriendlyWithBisons()
        {
            Turtle turtle = new();
            Bison bison = new();

            bool isFriendlyWithBisons = turtle.IsFriendlyWith(bison);
            Assert.True(isFriendlyWithBisons);
        }

        [Fact]
        public void TurtleShoulBeFriendlyWithElephants()
        {
            Turtle turtle = new();
            Elephant elephant = new();

            bool isFriendlyWithElephants = turtle.IsFriendlyWith(elephant);
            Assert.True(isFriendlyWithElephants);
        }

        [Fact]
        public void ShoulNotBeFriendlyWithOtherAnimals()
        {
            Turtle turtle = new();
            Lion lion = new();
            Penguin penguin = new();
            Snake snake = new();

            Assert.False(turtle.IsFriendlyWith(lion));
            Assert.False(turtle.IsFriendlyWith(penguin));
            Assert.False(turtle.IsFriendlyWith(snake));
        }
    }
}
