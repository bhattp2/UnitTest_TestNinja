using System;
using TestNinja.Fundamentals;
using NUnit.Framework;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ReservationTests
    {
        [Test]
        public void CanBeCancelledBy_AdminCancelling_ReturnsTrue()
        {
            //Arrange
            var resservation = new Reservation();

            //Act
            var result = resservation.CanBeCancelledBy(new User { IsAdmin = true });

            //Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void CanBeCanncelledBy_SameUserCancelling_ReturnsTrue()
        {
            //Arrange
            var user = new User();
            var resservation = new Reservation { MadeBy = user};

            //Act
            var result = resservation.CanBeCancelledBy(user);

            //Assert
            Assert.IsTrue(result);

        }

        [Test]
        public void CanBeCancelledBy_DifferentUserCancelling_ReturnsFalse()
        {
            var user = new User();
            var reservation = new Reservation { MadeBy = new User() };

            //Act
            var result = reservation.CanBeCancelledBy(user);

            //
            Assert.IsFalse(result);
        }
    }
}
