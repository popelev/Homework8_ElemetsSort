using System;
using System.Collections.Generic;
using System.Text;
using WpfNetCore_HW8.Model;

namespace WpfNetCore_HW8.EmployerListSort
{
    public class SalaryCompare : IComparer<Employer>
    {
        public int Compare(Employer x, Employer y)
        {
            return x.Salary.CompareTo(y.Salary);
        }
    }
}