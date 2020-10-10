using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using IdGen;

namespace WpfNetCore_HW8.Model
{
    static class RandomIdGeneratorClass
    {
        static int i = 0;
        static IdGenerator PassportIDGenerator = new IdGenerator(0);
        
        static IdGenerator EmployerIDGenerator = new IdGenerator(0);

        public static long GetPassportID()
        {
            i++;
            if (i > 1000)
            {
                i = 0;
                Thread.Sleep(1);
            }
            return PassportIDGenerator.CreateId();
        }
        public static long GetEmployerID()
        {
            i++;
            if (i > 1000)
            {
                i = 0;
                Thread.Sleep(1);
            }
            return EmployerIDGenerator.CreateId();
        }
    }
}
