using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Documents;

namespace WpfNetCore_HW8.Model
{
    [Serializable]
    public class Person : INotifyPropertyChangedCustom, ICloneable
    {
        public Passport Passport;

        public Person()
        {
            Sex sex = GetRandomSex();
            string firstName = GetRandomName<ManFirstName, WomanFirstName>(sex, 440); 
            string patronymic = GetRandomName<ManPatronymic, WomanPatronymic>(sex, 57);
            string lastName = GetRandomName<ManLastName, WomanLastName>(sex, 250);
            DateTime dateTime = getDateTime();
            Passport = new Passport(firstName, patronymic, lastName, dateTime, sex);
        }

        private Sex GetRandomSex()
        {
            Random sRandom = new Random();
            var sr = sRandom.Next(0, 2);
            if (sr == 0)
            {
                return Sex.Man;
            }
            else
            {
                return Sex.Woman;
            }
        }

        private string GetRandomName<TEnumManName, TWomanName>(Sex sex, int max)
        {
            Random sRandom = new Random();
            var sr = sRandom.Next(0, max);

            if (sex == Sex.Man)
            {
                
                return ((TEnumManName)Enum.GetValues(typeof(TEnumManName)).GetValue(sr)).ToString();
            }
            else
            {

                return ((TWomanName)Enum.GetValues(typeof(TWomanName)).GetValue(sr)).ToString();
            }
        }

        private DateTime getDateTime()
        {
            var randomTest = new Random();
            
            DateTime startDate = new DateTime(1960, 1, 1, 17, 0, 0);
            DateTime endDate = new DateTime(2002, 1, 1, 10, 0, 0);
            
            TimeSpan timeSpan = endDate - startDate;
            TimeSpan newSpan = new TimeSpan(0, randomTest.Next(0, (int)timeSpan.TotalMinutes), 0);
            DateTime newDate = startDate + newSpan;

            return newDate;
        }
        

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}