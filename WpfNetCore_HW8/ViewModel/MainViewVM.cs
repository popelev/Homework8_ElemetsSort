using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Win32;
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
        
        private RelayCommand sortEmployerByPassportIdCommand;
        public RelayCommand SortEmployerByPassportIdCommand
        {
            get
            {
                return sortEmployerByPassportIdCommand ??
                       (sortEmployerByPassportIdCommand = new RelayCommand(obj =>
                       {
                           company.SortByPassportId();
                       }));
            }
        }

        private RelayCommand sortEmployerByPatronymicAndFirstNameCommand;
        public RelayCommand SortEmployerByPatronymicAndFirstNameCommand
        {
            get
            {
                return sortEmployerByPatronymicAndFirstNameCommand ??
                       (sortEmployerByPatronymicAndFirstNameCommand = new RelayCommand(obj =>
                       {
                           company.SortByPatronymicAndFirstName();
                       }));
            }
        }
        private RelayCommand saveAsFileCommand;

        public RelayCommand SaveAsFileCommand
        {
            get
            {
                return saveAsFileCommand ??
                       (saveAsFileCommand = new RelayCommand(obj =>
                       {
                           SaveFileDialog save = new SaveFileDialog();
                           save.Filter = "JSON file format (*.json)|*.json|XML file format (*.xml)|*.xml";
                           save.FilterIndex = 1;
                           save.ShowDialog();
                           if (save.FileName != "")
                           {
                               string path = save.FileName;
                               File.Delete(path);

                               if (save.FilterIndex == 0)
                               {

                               }
                               else if (save.FilterIndex == 1)
                               {
                                   JsonSerialization serializer = new JsonSerialization(save.FileName);
                                   serializer.Serialize(company.EmployersFromAllDepartments);
                               }
                               else if (save.FilterIndex == 2)
                               {
                                   XmlSerialization serializer = new XmlSerialization(save.FileName);
                                   serializer.Serialize(company.EmployersFromAllDepartments);
                               }
                           }
                       }));
            }
        }
    }
}

