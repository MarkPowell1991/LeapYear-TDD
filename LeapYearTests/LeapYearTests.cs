using Leap_Year___TDD;
using NUnit.Framework;
using System;

namespace LeapYearTests
{
    [TestFixture]
    public class LeapYearTests
    {

        //A test has been given to test that each of the requirements of a leap year have been met. 
        [Test]
        public void False_if_Not_Divisable_By_4()
        {
            Assert.IsFalse(IsLeapYear(1997));
        }

        [Test]
        public void True_If_Divisable_By_4()
        {
            Assert.IsTrue(IsLeapYear(1996));
        }

        [Test]
        public void True_if_Divisable_By_400()
        {
            Assert.IsTrue(IsLeapYear(1600));
        }

        [Test]
        public void False_If_Divisable_By_100_But_Not_400()
        {
            Assert.IsFalse(IsLeapYear(1800));
        }

      //a method created to minimise code that has been duplicated across each of the tests.
        private static bool IsLeapYear(int year)
        {
            return new Year(year).IsLeapYear();
        }

    }

    
}
