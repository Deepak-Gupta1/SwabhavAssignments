using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCVoilationApp.Model
{
   
    internal class FixedDeposite
    {
        private string _name;
        private double _principle;
        private int _duration;
        private FestivalType festival;

        public FixedDeposite(string name,double principle,int duration, FestivalType festival)
        {
            _name = name;
            _principle = principle;
            _duration = duration;
            this.festival = festival;
        }
        public double CalculateRate()
        {
            if (this.festival == FestivalType.Normal)
            {
                return 7.0;
            }
            if (this.festival == FestivalType.NewYear)
            {
                return 8.0;
            }else
                return 8.5;
        }
        public double CalculateSimpleInterest()
        {
            return this._principle * this._duration*this.CalculateRate();
        }
        public override string ToString()
        {
            return "Name "+_name+"\nPrinciple "+_name+"\nDuration "+_duration+"\nFestival "+festival+"\nSimple Interest "+CalculateSimpleInterest();
        }
    }
}
