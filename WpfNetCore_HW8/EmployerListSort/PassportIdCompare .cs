using System;
using System.Collections.Generic;
using System.Text;
using WpfNetCore_HW8.Model;

namespace WpfNetCore_HW8.EmployerListSort
{
    public class PassportIdCompare : IComparer<Employer>
    {

        public int Compare(Employer x, Employer y)
        {
            return x.PassportId.CompareTo(y.PassportId);
        }
    }
}