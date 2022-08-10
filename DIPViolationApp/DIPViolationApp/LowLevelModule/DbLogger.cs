using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPViolationApp.LowLevelModule
{
    internal class DbLogger
    {
        public void Log(string errorDetail)
        {
            Console.WriteLine(errorDetail);
        }
    }
}
