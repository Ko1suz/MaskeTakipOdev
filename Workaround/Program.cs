using Buisness.Concrete;
using Entities.Concrete;
using System;

namespace Workaround // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.FirstName = "Ahmet";
            person1.LastName = "Bulgurcu";
            person1.DateOfBirthYear = 2000;
            person1.NationalIdentity = 52861286222;

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine(  );
        }
    }
}