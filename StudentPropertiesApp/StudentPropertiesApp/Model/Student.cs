using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPropertiesApp.Model
{
    internal class Student
    {
        private int _roll;
        private string _name;
        public int RollNo
        {
            get { return _roll; }

            set {
                if (value > 0) { _roll = value; } else { _roll = 1; }
                }
        }
        public string Name
        {
            get { return _name; }

            set {
                if (value.Length < 5) { _name ="Anonymous"; } else { _name = value; }
                }
        }

    }
}
