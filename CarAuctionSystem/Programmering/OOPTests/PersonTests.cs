using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP;
using NUnit.Framework;

namespace OOP.Tests
{
    [TestFixture()]
    public class PersonTests
    {
        [TestCase(Sex.Male, Result = "John Doe")]
        [TestCase(Sex.Female, Result = "Jane Doe")]
        public string Name_IsValidOnCreation_IsDefault(Sex sex)
        {
            var person = new Person(sex);
            return person.Name;
        }

        [Test]
        public void Name_OnEmptyConstuction_IsUnknown()
        {
            var person = new Person();
            StringAssert.AreEqualIgnoringCase("Unknown", person.Name);
        }

        [TestCase("Claus Worm Wiingreen", "Claus Worm Wiingreen")]
        [TestCase("Alex Josefsen", "Alex Josefsen")]
        [TestCase("Lars Larsen", "Lars Larsen")]
        public string Name_IsValidOnChange_IsChangedValue(string name)
        {
            var person = new Person();
            person.Name = name;
            return person.Name;
        }

        [TestCase("N00bSlayer9001", true)]
        [TestCase("FailBookIs Legal", false)]
        [TestCase("Get over here!", true)]
        public bool Name_IsInvalidOnChange_ThrowExeption(string name)
        {
            bool thrownArgumentException = false;
            try
            {
                var person = new Person();
                person.Name = name;
            }
            catch (ArgumentException)
            {
                thrownArgumentException = true;
            }
            return thrownArgumentException;
        }
    }
}
