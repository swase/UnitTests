using NUnit.Framework;
using CodeToTest;

namespace TestCode
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(5)]
        [TestCase(6)]
        [TestCase(11)]
        [TestCase(12)]
        public void GivenATimeOfBetween5InclusiveAnd12Inclusive_Greeting_returnsGoodMorning(int time)
        {
            //Arrange
            var expectedOutput = "Good Morning!";
            //Act
            var result = Program.Greeting(time);
            //Assert
            Assert.That(result, Is.EqualTo(expectedOutput));
        }


        [TestCase(13)]
        [TestCase(17)]
        [TestCase(18)]
        public void GivenATimeOfBetween12And18Inclusive_Greeting_returnsGoodAfternoon(int time)
        {
            var expectedOutput = "Good Afternoon!";
            var result = Program.Greeting(time);
            Assert.That(result, Is.EqualTo(expectedOutput));
        }

        [TestCase(3)] 
        [TestCase(4)]
        [TestCase(19)]
        public void GivenATimeOfGreaterThan18AndLessThan5_Greeting_returnsGoodEvening(int time)
        {
            var expectedOutput = "Good Evening!";
            var result = Program.Greeting(time);
            Assert.That(result, Is.EqualTo(expectedOutput));
        }



    }
}