using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorhismApp.Model
{
    internal class Developer:Employee
    {
        public Developer(int id, string name, double basicSalary) : base(id, name, basicSalary)
        {
            CalGrossSalary();
        }
        public override void CalGrossSalary()
        {
            double PA = 0.40 * base.BasicSalary;
            base.Gross = base.BasicSalary + PA;
        }
        public override string ToString()
        {
            return "Developer";
        }
    }
}
