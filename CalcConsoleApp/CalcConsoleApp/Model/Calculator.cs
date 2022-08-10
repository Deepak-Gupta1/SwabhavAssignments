using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcConsoleApp.Model
{
    public class Calculator
    {
        public long AddPositive(int first ,int second)
        {
            if (first < 0 || second < 0)
            {
                throw new ApplicationException();
            }
            return first + second;
        }
    }
}
