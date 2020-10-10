using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using WpfNetCore_HW8.EmployerListSort;
using WpfNetCore_HW8.Model;

namespace WpfNetCore_HW8.Model
{
    public class Company : INotifyPropertyChangedCustom
    {
        private int _departmentsId;
        private BindingList<Department>  _departments;

        public Company()
        {
            _departments = new BindingList<Department>();
            
            AddNewDepartments(3);

            foreach (var department in _departments)
            {
                department.AddEmployers(RandomEmployers.GenerateRandomEployers(10000));
            }
        }

        public void AddNewDepartments(int count)
        {
            for (var i = 0; i < count; i++)
            {
                var _department = new Department();
                _department.DepartmentId = _departmentsId++;
                _departments.Add(_department);
            }
            OnPropertyChanged();

        }

        public BindingList<Department> Departments
        {
            get
            {
                return _departments;
            }
            set
            {
                _departments = value;
                OnPropertyChanged();
            }
        }

        private BindingList<Employer> employersFromAllDepartments;

        public BindingList<Employer> EmployersFromAllDepartments
        {
            get
            {

                List<Employer> Employers = new List<Employer>();

                foreach (var department in Departments)
                {
                    Employers.AddRange(department.EmployersList);
                }

                if (Employers == null)
                {
                    return new BindingList<Employer>();
                }

                employersFromAllDepartments = new BindingList<Employer>(Employers);
                
                return employersFromAllDepartments;
            }
        }

        public int EmployersCount
        {
            get => employersFromAllDepartments.Count;
        }
        public void SortBySex()
        {
            var backing = new BindingList<Employer>(employersFromAllDepartments.OrderBy(x => x, new SexCompare()).ToList());

            UpdateListAfterSort(backing);
        }
        public void SortByPassportId()
        {
            var backing = new BindingList<Employer>(employersFromAllDepartments.OrderBy(x => x, new PassportIdCompare()).ToList());

            UpdateListAfterSort(backing);
        }

        public void SortByPatronymicAndFirstName()
        {
            var backing = new BindingList<Employer>(employersFromAllDepartments.OrderBy(x => x, new PatronymicAndFirstNameCompare()).ToList());

            UpdateListAfterSort(backing);
        }

        public void SortBySexAndSalary()
        {
            var backing = new BindingList<Employer>(employersFromAllDepartments.OrderBy(x => x, new SexAndSalaryCompare()).ToList());

            UpdateListAfterSort(backing);
        }

        public void SortBySalary()
        {
            var backing = new BindingList<Employer>(employersFromAllDepartments.OrderBy(x => x, new SalaryCompare()).ToList());

            UpdateListAfterSort(backing);
        }
        public void SortByFirstName()
        {
            var backing = new BindingList<Employer>(employersFromAllDepartments.OrderBy(x => x, new FirstNameCompare()).ToList());

            UpdateListAfterSort(backing);
        }

        private void UpdateListAfterSort(BindingList<Employer> backing)
        {
            this.employersFromAllDepartments.Clear();
            foreach (var employer in backing)
            {
                employersFromAllDepartments.Add(employer);
            }
        }

    }
}
