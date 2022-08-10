using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorhismApp.Model
{
    internal abstract class Employee
    {
        private int _id;
        private string _name;
        private double _basicSalary;
        private double _gross;
        private double _annaulCTC;
        private const int Months = 12;
        public Employee(int id ,string name,double basicSalary)
        {
            _id = id;
            _name = name;
            _basicSalary = basicSalary;
        }
        public int Id { get { return _id; } }
        public string Name { get { return _name; }  }
        public double BasicSalary { get { return _basicSalary; } set { _basicSalary = value; } }
        public double Gross { get { return _gross; } set { _gross = value; } }
        public abstract void CalGrossSalary();
        public double AnnaulCTC { 
            get {
                _annaulCTC = _gross * Months;
                return _annaulCTC; 
            }
        }
        
    }
}
