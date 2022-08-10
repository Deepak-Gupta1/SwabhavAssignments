using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorhismApp.Model
{
    internal class Tester : Employee
    {
     
        public Tester(int id, string name, double basicSalary) : base(id, name, basicSalary)
        {
            CalGrossSalary();
        }
        public override void CalGrossSalary()
        {
            double perks = 0.30 * base.BasicSalary;
            base.Gross = base.BasicSalary + perks;
        }
        public override string ToString()
        {
            return "Tester";
        }
    }
}
