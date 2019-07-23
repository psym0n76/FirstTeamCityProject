using NUnit.Framework;
using System;


namespace ConsoleUi.Tests
{
    [TestFixture]
    public class PersonTests
    {

        [Test]
        public void ShouldReturnFirstNameLastNameAsString()
        {
            Assert.AreEqual("Simon.Burton", TestPerson().ToString());
        }

        [Test]
        public void ShouldReturnFalseFirstNameLastNameAsString()
        {
            Assert.AreNotEqual("SimonBurton", TestPerson().ToString());
        }

        [Test]
        public void ShouldReturnAgeFromAgeInYears()
        {
            var person = TestPerson();
            var result = person.AgeOnNextBirthday();

            Assert.AreEqual(43, result);
        }



        public static Person TestPerson()
        {
            return new Person
            { FirstName = "Simon", LastName = "Burton",MiddleName = "William", Dob = new DateTime(1976, 11, 14) };
        }
    }
}