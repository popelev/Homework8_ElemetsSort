using System;
using System.Collections.Generic;
using System.Text;

namespace WpfNetCore_HW8.Model
{
    static class RandomEmployers
    {
        static public List<Person> GenerateRandomPersons(int count)
        {
            var Persons = new List<Person>();
            for (var i = 0; i < count; i++)
            {
                Persons.Add(new Person());
            }

            return Persons;
        }

        static public List<Employer> GenerateRandomEployers(int count)
        {
            var Persons = GenerateRandomPersons(count);
            var Employers = new List<Employer>();
            for (var i = 0; i < count; i++)
            {
                Employers.Add(new Employer(Persons[i]));
            }

            return Employers;
        }
    }
}
