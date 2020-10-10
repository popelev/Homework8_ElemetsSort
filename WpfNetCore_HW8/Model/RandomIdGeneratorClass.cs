using System;
using System.Collections.Generic;
using System.Text;
using IdGen;

namespace WpfNetCore_HW8.Model
{
    static class RandomIdGeneratorClass
    {
        static IdGenerator PassportIDGenerator = new IdGenerator(0);
        
        static IdGenerator EmployerIDGenerator = new IdGenerator(0);

        static public long GetPassportID()
        {
            return PassportIDGenerator.CreateId();
        }
        static public long GetEmployerID()
        {
            return EmployerIDGenerator.CreateId();
        }
    }
}
