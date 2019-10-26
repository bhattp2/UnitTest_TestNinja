using System;
using TestNinja.Fundamentals;
using NUnit.Framework;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {

        Fundamentals.Math math = new Fundamentals.Math();

        [Test]
        public void Add_WhenCalled_ReturnValue()
        {
            var result = math.Add(1, 2);

            Assert.That(result, Is.EqualTo(3));

        }


        [Test]
        [TestCase(2,1,2)]
        [TestCase(3,2,3)]
        [TestCase(3,3,3)]
        public void Max_WhenCalled_ReturnGreaterArgument(int a, int b , int expectedResult)
        {
            var result = math.Max(a, b);

            Assert.That(result, Is.EqualTo(expectedResult));

        }
    }
}
