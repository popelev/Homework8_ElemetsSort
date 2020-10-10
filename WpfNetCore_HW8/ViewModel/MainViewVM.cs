using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfNetCore_HW8.Annotations;
using WpfNetCore_HW8.Model;
using WpfNetCore_HW8.TOOLS;


namespace WpfNetCore_HW8.ViewModel
{
    public class MainViewVM : ViewModelBase
    {
        public MainViewVM()
        {

        }

        private  Company company = new Company();

        public BindingList<Employer> Employers
        {
            get { return company.EmployersFromAllDepartments; }
        }

        private RelayCommand addDepartment;

        public RelayCommand AddDepartment
        {
            get
            {
                return addDepartment ??
                       (addDepartment = new RelayCommand(obj =>
                       {
                           company.AddNewDepartments(1);
                       }));
            }
        }

        public BindingList<Department> SelectDepartment
        {
            get { return company.Departments; }
            set
            {
                company.Departments = value;
            }
        }
        private RelayCommand sortEmployerByFirstNameCommand;
        public RelayCommand SortEmployerByFirstNameCommand
        {
            get
            {
                return sortEmployerByFirstNameCommand ??
                       (sortEmployerByFirstNameCommand = new RelayCommand(obj =>
                       {
                           company.SortByFirstName();
                       }));
            }
        }
        private RelayCommand sortEmployerBySexCommand;
        public RelayCommand SortEmployerBySexCommand
        {
            get
            {
                return sortEmployerBySexCommand ??
                       (sortEmployerBySexCommand = new RelayCommand(obj =>
                       {
                           company.SortBySex();
                       }));
            }
        }

        private RelayCommand sortEmployerBySalaryCommand;
        public RelayCommand SortEmployerBySalaryCommand
        {
            get
            {
                return sortEmployerBySalaryCommand ??
                       (sortEmployerBySalaryCommand = new RelayCommand(obj =>
                       {
                           company.SortBySalary();
                       }));
            }
        }

        private RelayCommand sortEmployerBySexAndSalaryCommand;
        public RelayCommand SortEmployerBySexAndSalaryCommand
        {
            get
            {
                return sortEmployerBySexAndSalaryCommand ??
                       (sortEmployerBySexAndSalaryCommand = new RelayCommand(obj =>
                       {
                           company.SortBySexAndSalary();
                       }));
            }
        }

    }
}

