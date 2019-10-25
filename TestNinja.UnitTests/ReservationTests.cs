using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestClass]
    public class ReservationTests
    {
        [TestMethod]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            //Arrange
            var resservation = new Reservation();

            //Act
            var result = resservation.CanBeCancelledBy(new User { IsAdmin = true });

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCanncelledBy_UserIsMadeBy_ReturnsTrue()
        {
            //Arrange
            var user = new User();
            var resservation = new Reservation { MadeBy = user};

            //Act
            var result = resservation.CanBeCancelledBy(user);

            //Assert
            Assert.IsTrue(result);

        }

        [TestMethod]
        public void CanBeCancelledBy_UserIsNewuser_ReturnsFalse()
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
