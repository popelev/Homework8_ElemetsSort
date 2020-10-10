using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Linq;
using WpfNetCore_HW8.EmployerListSort;

namespace WpfNetCore_HW8.Model
{
    
    public class Department : INotifyPropertyChangedCustom
    {
        private int _departmentId;
        private BindingList<Employer> _employers;

        public Department()
        {
            _employers = new BindingList<Employer>();
        }

        public BindingList<Employer> EmployersList
        {
            get { return _employers; }
            set { _employers = value; }
        }

        public int DepartmentId
        {
            get => _departmentId;
            set
            {
                if (value == _departmentId) return;
                _departmentId = value;
                OnPropertyChanged();
            }
        }


        public void AddEmployers(IList<Employer> employers)
        {
            var RandomSalary = new Random();
            foreach (var emp in employers)
            {
                emp.Department = DepartmentId;
                emp.EmployerId = RandomIdGeneratorClass.GetEmployerID();
                emp.Salary = RandomSalary.Next(40000,120000);

                EmployersList.Add(emp);
            }
        }




    }
}