using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinjaUnitTest
{
   [TestFixture]
   public class DemeritPointCalculatorTest
   {

      private DemeritPointsCalculator  _demeritPointCalculator;
    
      [SetUp]
      public void SetUp()
      {
         _demeritPointCalculator = new DemeritPointsCalculator();
      }
      
      
      [Test]
      [TestCase(-1)]
      [TestCase(350)]
      public void CalculateDemeritPoints_WhenSpeedSmallerThanZeroOrGreaterThan300_WillThrowRangeException(int speed)
      {
         //Arrange
         
         //Act
         var demeritPointCalculator= new DemeritPointsCalculator();
         
         
         //Assert
         Assert.That(()=>demeritPointCalculator.CalculateDemeritPoints(speed),Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
      }
      
      [Test]
      [TestCase(0,0)]
      [TestCase(50,0)]
      [TestCase(65,0)]
      public void CalculateDemeritPoints_WhenSpeedIsEqualOrGreaterThanZeroAndSmallerOrEqualsToSpeedLimitOf65_WillReturnZero(int speed,int expectedResult)
      {
         //Arrange
         
         //Act
         var result = _demeritPointCalculator.CalculateDemeritPoints(speed);
         
         //Assert
         Assert.That(result,Is.EqualTo(expectedResult));
      }
        
      
      [Test]
      [TestCase(70,1)]
      [TestCase(85,4)]
      public void CalculateDemeritPoints_WhenSpeedIsOverTheSpeedLimitOf65_WillThrowReturnDemeritPointsAsNumber(int speed,int expectedResult)
      {
         //Arrange
         
         //Act
         var result = _demeritPointCalculator.CalculateDemeritPoints(150);
         
         
         //Assert
         Assert.That(result,Is.EqualTo(expectedResult));
      }
   }
}