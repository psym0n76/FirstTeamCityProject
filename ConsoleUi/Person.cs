using System;

namespace ConsoleUi
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Dob { get; set; }

        public override string ToString()
        {
            return $"{this.FirstName}.{this.LastName}";
        }


        public int AgeOnNextBirthday()
        {
            return DateTime.Now.Year - this.Dob.Year;
        }
    }
}
