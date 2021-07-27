using NUnit.Framework;
using CodeToTest;

namespace Classification_tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [TestCase(8)]
        [TestCase(11)]
        public void GivenAnAgeUnder12_AvailableClassifications_Returns_U_PG(int age)
        {

            Assert.That(Program.AvailableClassifications(age), Is.EqualTo("U, PG films are available."));
        }

        [TestCase(12)]
        [TestCase(13)]
        [TestCase(14)]
        public void GivenAnAgeBetween12IncAnd15Exc_AvailableClassifications_Returns_U_PG__12_Rating(int age)
        {
              
            Assert.That(Program.AvailableClassifications(age),Is.EqualTo("U, PG & 12 films are available."));
        }

        [TestCase(15)]
        [TestCase(16)]
        [TestCase(17)]
        public void GivenAnBetween15IncAnd18Exc_AvailableClassifications_Returns_U_PG_12_15_Rating(int age)
        {

            Assert.That(Program.AvailableClassifications(age), Is.EqualTo("U, PG, 12 & 15 films are available."));
        }

        [TestCase(18)]
        [TestCase(21)]
        public void GivenAnAgeMoreThan18Inc_AvailableClassifications_Returns_AllAvailable(int age)
        {

            Assert.That(Program.AvailableClassifications(age), Is.EqualTo("All films are available."));
        }

    }
}