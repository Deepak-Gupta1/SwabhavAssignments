using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInheritanceApp.Model
{
    internal class Tweeter:Person
    {
        private string _tweeterHandle;
        public Tweeter(string firstName, string lastName,string tweeterHandle): base(firstName, lastName)
        {
            _tweeterHandle = tweeterHandle;
        }
        public string TweeterHandle { get { return _tweeterHandle; } }
       
    }
}
 