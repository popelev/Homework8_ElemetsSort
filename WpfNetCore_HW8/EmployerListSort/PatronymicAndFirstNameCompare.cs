using System;
using System.Collections.Generic;
using System.Text;
using WpfNetCore_HW8.Model;

namespace WpfNetCore_HW8.EmployerListSort
{
    public class PatronymicAndFirstNameCompare : IComparer<Employer>
    {
        public int Compare(Employer x, Employer y)
        {
            if (x.Patronymic.CompareTo(y.Patronymic) == 0)
            {
                return x.FirstName.CompareTo(y.FirstName);
            }
            else
            {
                return x.Patronymic.CompareTo(y.Patronymic);
            }
        }
    }
}