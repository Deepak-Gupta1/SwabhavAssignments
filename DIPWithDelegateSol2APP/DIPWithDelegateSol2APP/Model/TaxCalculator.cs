using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPWithDelegateApp.HighLevelModule
{
    internal class TaxCalculator
    {
        public Action<string> _logger;

        public TaxCalculator(Action<string> dLogger)
        {
            this._logger = dLogger;
        }
        public int Calculator(int value1 , int value2)
        {
            int result = -1;
            try
            {
                result = value1 / value2;
            }catch(Exception ex)
            {
                this._logger(ex.Message);
            }
            return result;
        }

    }
}
