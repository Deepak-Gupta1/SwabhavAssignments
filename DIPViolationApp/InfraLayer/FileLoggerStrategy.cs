using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPViolationApp
{
    internal class FileLoggerStrategy: Common.ILoggerStrategy
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
