using DIPViolationApp.LowLevelModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPViolationApp.HighLevelModule
{
    internal class TaxCalculator
    {
        LoggerType _logType;

        public TaxCalculator(LoggerType logType)
        {
            _logType = logType;
        }
        public int Calculator(int value1 , int value2)
        {
            int result = -1;
            try
            {
                result = value1 / value2;
            }catch(Exception ex)
            {
                if (_logType == LoggerType.FILE)
                {
                    FileLogger flog = new FileLogger();
                    flog.Log(ex.Message);
                }
                else if (_logType == LoggerType.DB)
                {
                    DbLogger dlog = new DbLogger();
                    dlog.Log(ex.Message);
                }
            }
            return result;
        }

    }
}
