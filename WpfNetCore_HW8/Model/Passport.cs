using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace WpfNetCore_HW8.Model
{
    public class Passport
    {
        private string _firstName;
        private string _patronymic;
        private string _lastName;
        private DateTime? _birthdate;
        private long _passportId;
        private Sex _sex;

        public long PassportId
        {
            get => _passportId;
            set
            {
                if (value == _passportId) return;
                _passportId = value;
                OnPropertyChanged();
            }
        }

        public string FirstName
        {
            get => _firstName;
            set
            {
                if (value == _firstName) return;
                _firstName = value;
                OnPropertyChanged();
            }
        }
        public string Patronymic
        {
            get => _patronymic;
            set
            {
                if (value == _firstName) return;
                _firstName = value;
                OnPropertyChanged();
            }
        }

        public string LastName
        {
            get => _lastName;
            set
            {
                if (value == _lastName) return;
                _lastName = value;
                OnPropertyChanged();
            }
        }
        public Sex Sex
        {
            get => _sex;
            set
            {
                if (value == _sex) return;
                _sex = value;
                OnPropertyChanged();
            }
        }
        public DateTime? Birthdate
        {
            get => _birthdate;
            set
            {
                if (value.Equals(_birthdate)) return;
                _birthdate = value;
                OnPropertyChanged();
            }
        }

        public Passport(string firstName, string patronymic, string lastName, DateTime birthdate, Sex sex)
        {
            _firstName = firstName;
            _patronymic = patronymic;
            _lastName = lastName;
            _birthdate = birthdate;
            _sex = sex;
            _passportId = RandomIdGeneratorClass.GetPassportID();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
