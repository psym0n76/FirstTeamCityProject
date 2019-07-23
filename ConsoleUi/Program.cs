using System;

namespace ConsoleUi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var person = new Person
            { FirstName = "Simon", LastName = "Burton" ,MiddleName = "William", Dob = new DateTime(1976, 11, 14) };


            Console.WriteLine(person.AgeOnNextBirthday());
        }
    }
}
