using System;
namespace PersonApp.Model
{
    internal class Person
    {
        private int _id;
        private string _name;
        private int _age;
        private double _height = 5;
        private double _wegith = 50;
        private double _bmi;
        public Person(int id, string name, int age, double ht, double wegith)
        {
            _id = id;
            _name = name;
            _age = age;
            _height = ht;
            _wegith = wegith;
        }
        public Person(int id, string name, int age) {
            _id = id;
            _name = name;
            _age = age;
        }

        public int Id { 
            get { return _id; }
        }
        public string Name { 
            get { return _name; }
        }
        public int Age{ 
               get { return _age; }
        }
        public double Height { 
            get { return _height; }
        }
        public double Wegith { 
            get { return _wegith; }
        }

        public double CalcuateBmi() {
            _bmi = _wegith /(_height* _height);
            return _bmi;
        }
        public void BmiBaseBodyType(double bmi)
        { 
            if(bmi < 18.5)
            {
                Console.WriteLine("Underweight");
            }
            if(bmi > 18.5 && bmi < 25)
            {
                Console.WriteLine("healthy Body");
            }
            if (bmi > 25)
            {
                Console.WriteLine("OverWeight");
            }
        }

    }
}
