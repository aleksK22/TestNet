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
        [TestCase(2,1,2)]
        [TestCase(1,2,2)]
        [TestCase(2,2,2)]
        public void Max_WhenCalled_ReturnGreaterArgument(int x,int y, int expectedResult)
        {
            //Arrange
            
            
            //Add
            var result = _math.Max(x, y);
            
            //Assert
            Assert.That(result,Is.EqualTo(expectedResult));
        }
        
    }
}