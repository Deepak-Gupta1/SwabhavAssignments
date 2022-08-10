using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorhismApp.Model
{
    internal class Manger:Employee
    {
        public Manger(int id, string name, double basicSalary):base(id,name,basicSalary)
        {
            CalGrossSalary();
        }
        public override void CalGrossSalary()
        {
            double TA = 0.50 * base.BasicSalary;
            double DA= 0.40 * base.BasicSalary;
            base.Gross = base.BasicSalary + TA + DA;
        }
        public override string ToString()
        {
            return "Manger";
        }
    }

}
