using System;
using System.Collections.Generic;
using System.Text;
using WpfNetCore_HW8.Model;

namespace WpfNetCore_HW8.EmployerListSort
{
    public class SexAndSalaryCompare : IComparer<Employer>
    {
        public int Compare(Employer x, Employer y)
        {
            if (x.Sex.CompareTo(y.Sex) == 0)
            {
                return x.Salary.CompareTo(y.Salary);
            }
            else
            {
                return x.Sex.CompareTo(y.Sex);
            }
        }
    }
}