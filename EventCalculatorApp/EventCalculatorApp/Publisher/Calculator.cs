using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCalculatorApp.Publisher
{
    public delegate void DCalculate(int result);
    internal class Calculator
    {
        private int _firstNo;
        private int _secondNo;
        public event DCalculate OnClickResult = null;

        public Calculator(int firstNO ,int secondNo)
        {
            _firstNo = firstNO;
            _secondNo = secondNo;
        }

        public void Add()
        {
            if(OnClickResult != null)
            {
                OnClickResult( _firstNo+_secondNo);
            }

        }
        public void Subtract()
        {
            if (OnClickResult != null)
            {
                OnClickResult(_firstNo - _secondNo);
            }

        }


    }
}
