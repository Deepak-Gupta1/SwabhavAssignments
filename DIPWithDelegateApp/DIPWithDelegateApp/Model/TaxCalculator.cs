using DIPWithDelegateApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPWithDelegateApp.HighLevelModule
{
    internal class TaxCalculator
    {
        public DLogger _dLogger;

        public TaxCalculator(DLogger dLogger)
        {
            this._dLogger = dLogger;
        }
        public int Calculator(int value1 , int value2)
        {
            int result = -1;
            try
            {
                result = value1 / value2;
            }catch(Exception ex)
            {
                this._dLogger(ex.Message);
            }
            return result;
        }

    }
}
