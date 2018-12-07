using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinjaUnitTest
{
    [TestFixture]
    public class FizzBuzzTests
    {

        
        [Test]
        public void GetOutput_WhenDivisibleByThreeAndFive_ReturnsFizzBuzz()
        {
            //Arrange
            
            //Act
            var result = FizzBuzz.GetOutput(15);
            
            //Assert
            Assert.That(result.Equals("FizzBuzz"));
            
        }
        
        [Test]
        public void GetOutput_WhenDivisibleByThree_ReturnsFizz()
        {
            //Arrange
            
            //Act
            var result = FizzBuzz.GetOutput(3);
            
            //Assert
            Assert.That(result,Is.EqualTo("Fizz"));
            
        }
        
        [Test]
        public void GetOutput_WhenDivisibleByFive_ReturnsBuzz()
        {
            //Arrange
            
            //Act
            var result = FizzBuzz.GetOutput(5);
            
            //Assert
            Assert.That(result,Is.EqualTo("Buzz"));
            
        }
        
        [Test]
        public void GetOutput_WhenNotDivisibleByThreeAndFive_ReturnsTheSameNumber()
        {
            //Arrange
            
            //Act
            var result = FizzBuzz.GetOutput(4);
            
            //Assert
            Assert.That(result,Is.EqualTo("4"));
            
        }
    }
}