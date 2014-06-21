using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace OOP
{
    public class Person
    {
        private float _weight;
        private string _name;

        public Person(Sex sex = Sex.Unknown)
        {
            Sex = sex;
            switch (sex)
            {
                case Sex.Male:
                    Name = "John Doe";
                    break;
                case Sex.Female:
                    Name = "Jane Doe";
                    break;
                default:
                    Name = "Unknown";
                    break;
            }
        }

        public int Age { get; private set; }

        public float Weight
        {
            get { return _weight; }
            set
            {
                if (Age < 15)
                {
                    value = Math.Max(value, 0);
                    value = Math.Min(value, 100);
                }
                else if (Sex == Sex.Female)
                {
                    value = Math.Max(value, 45);
                    value = Math.Min(value, 120);
                }
                else
                {
                    value = Math.Max(value, 65);
                    value = Math.Min(value, 150);
                }
                _weight = value;
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (value.All(c => Char.IsLetter(c) || Char.IsWhiteSpace(c)))
                {
                    _name = value;
                }
                else
                {
                    throw new ArgumentException("Numbers and symbol are not allowed in names");
                }
            }
        }

        public Sex Sex { get; set; }

        public int ItsYourBirthsday()
        {
            if (Sex == Sex.Male || Age < 29)
            {
                Age++;
            }
            return Age;
        }
    }

    public enum Sex
    {
        Unknown,
        Male,
        Female
    }
}
