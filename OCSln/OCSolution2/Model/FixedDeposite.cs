using OCSolution2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCSolutionApp.Model
{
    internal class FixedDeposite
    {
        private string _name;
        private double _principle;
        private int _duration;
        private DFestival festival;

        public FixedDeposite(string name, double principle, int duration, DFestival festival)
        {
            _name = name;
            _principle = principle;
            _duration = duration;
            this.festival = festival;
        }
        public double CalculateSimpleInterest()
        {
            return this._principle * this._duration * this.festival();
        }
        public override string ToString()
        {
            return "Name " + _name + "\nPrinciple " + _principle + "\nDuration " + _duration  + "\nSimple Interest " + CalculateSimpleInterest();
        }
    }
}
