using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinjaUnitTest
{
    [TestFixture]
    public class MathTests
    {
        private Math _math;
        
        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }
        
        [Test]
        public void Add_WhenCalled_ReturnSum()
        {
            //Arrange
           
            
            //Add
            var result = _math.Add(1, 2);
            
            //Assert
            Assert.That(result,Is.EqualTo(3));
        }
        
        
        [Test]
        public void Max_FirstArgumentGreater_ReturnFirstArgument()
        {
            //Arrange
            
            
            //Add
            var result = _math.Max(2, 1);
            
            //Assert
            Assert.That(result,Is.EqualTo(2));
        }
        
        [Test]
        public void Max_SecondArgumentGreater_ReturnSecondArgument()
        {
            //Arrange
            
            
            //Add
            var result = _math.Max(1, 2);
            
            //Assert
            Assert.That(result,Is.EqualTo(2));
        }
        
        [Test]
        public void Max_ArgumentsAreEqual_ReturnSameArgument()
        {
            //Arrange
            
            
            //Add
            var result = _math.Max(2, 2);
            
            //Assert
            Assert.That(result,Is.EqualTo(2));
        }
    }
}