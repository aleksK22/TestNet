using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinjaUnitTest
{
    [TestFixture]
    public class ReservationTests
    {
        [Test]
        public void CanBeCancelledBy_AdminCanceling_ReturnsTrue()
        {
            //Arrange
            var reservation = new Reservation();

            //Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            //Assert
            Assert.IsTrue(result);

        }

        [Test]
        public void CanBeCancelledBy_SameUserCanceling_ReturnsTrue()
        {
            //Arrange
            var reservation = new Reservation();

            //Act
            var user = new User();
            reservation.MadeBy = user;
            var result = reservation.CanBeCancelledBy(user);

            //Assert
            Assert.IsTrue(result);

        }

        [Test]
        public void CanBeCancelledBy_NotAdminAndDifferentUserCanceling_ReturnsFalse()
        {
            //Arrange
            var reservation = new Reservation();

            //Act
            reservation.MadeBy = new User { IsAdmin = true };

            var user = new User{ IsAdmin = false };
            var result = reservation.CanBeCancelledBy(user);

            //Assert
            Assert.IsFalse(result);

        }

        [Test]
        public void CanBeCancelledBy_DifferentUserCanceling_ReturnsFalse()
        {
            //Arrange
            var reservation = new Reservation { MadeBy = new User() };

            //Act
            var user = new User();
            var result = reservation.CanBeCancelledBy(user);

            //Assert
            Assert.IsFalse(result);

        }
    }
}
