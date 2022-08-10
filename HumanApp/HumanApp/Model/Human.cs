using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanApp.Model
{
    internal class Human { 
        private readonly string _name;
        private float _weight;
        private float _height;
        private readonly GenderCategory _gender;
        public enum GenderCategory
        {
            Male,
            Female,
            Other
        }

        public Human(string name,float weight,float height , GenderCategory gender) :
            this(name, weight,height)
        {
            _gender = gender;
        }
        public Human(string name, float weight, float height)
        {
            _name = name;
            _weight = weight;
            _height = height;
            _gender = GenderCategory.Male;

        }
        public string Name
        {
            get { return _name; }
        }
        public float Weight { 
            get { return _weight; }
        }
        public float Height { 
            get { return _height; }
        }
        public GenderCategory Gender { 
            get { return _gender; }
        }
        public void Eat()
        {
            double lossWeight = 0.02;
            _weight=_weight+(_weight *(float) lossWeight);
        }
        public void WorkOut()
        {
            double lossWeight = 0.01;
            double increaseHeight = 0.01;
            _weight = _weight - (_weight * (float)lossWeight);
            _height = _height+(_height * (float)increaseHeight);
        }
    }
}
