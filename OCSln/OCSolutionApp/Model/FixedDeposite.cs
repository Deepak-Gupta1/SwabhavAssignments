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
        private IFestivalRate festivalRate;

        public FixedDeposite(string name, double principle, int duration, IFestivalRate festivalRate)
        {
            _name = name;
            _principle = principle;
            _duration = duration;
            this.festivalRate = festivalRate;
        }
        public double CalculateSimpleInterest()
        {
            return this._principle * this._duration * festivalRate.CalculateRate();
        }
        public override string ToString()
        {
            return "Name " + _name + "\nPrinciple " + _principle + "\nDuration " + _duration  + "\nSimple Interest " + CalculateSimpleInterest();
        }
    }
}
