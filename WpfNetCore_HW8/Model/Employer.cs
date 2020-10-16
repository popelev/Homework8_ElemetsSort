using System;
using System.Collections.Generic;

namespace WpfNetCore_HW8.Model
{
    [Serializable]
    public class Employer : INotifyPropertyChangedCustom, IComparable, ICloneable
    {
        private Person Person;
        private int _departmentId;
        private int _salary;
        private long  _employerId;

        public Employer()
        {
        }

        public Employer(Person person)
        {
            Person = person;
        }

        public long EmployerId
        {
            get => _employerId;
            set
            {
                if (value == _employerId) return;
                _employerId = value;
                OnPropertyChanged();
            }
        }
        public long PassportId
        {
            get => Person.Passport.PassportId;
            set
            {
                Person.Passport.PassportId = value;
            }
        }

        public string FirstName
        {
            get => Person.Passport.FirstName;
            set
            {
                Person.Passport.FirstName = value;
            }
        }
        public string LastName
        {
            get => Person.Passport.LastName;
            set
            {
                Person.Passport.LastName = value;
            }
        }
        public string Patronymic
        {
            get => Person.Passport.Patronymic;
            set
            {
                Person.Passport.Patronymic = value;
            }
        }

        public int Salary
        {
            get => _salary;
            set
            {
                if (value == _salary) return;
                _salary = value;
                OnPropertyChanged();
            }
        }

        public virtual int Department
        {
            get => _departmentId;
            set
            {
                if (Equals(value, _departmentId)) return;
                _departmentId = value;
                OnPropertyChanged();
            }
        }

        public Sex Sex
        {
            get => Person.Passport.Sex;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(object obj)
        {
            Employer n = obj as Employer;

            return this.CompareTo(n.EmployerId);
        }

        public override bool Equals(Object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Employer n = (Employer)obj;
                return (EmployerId == n.EmployerId);
            }
        }
    }
}