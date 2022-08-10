using System;
namespace InterfaceMovableApp.Model
{
    public interface Imovable
    {
        void Move();
    }
    public abstract class  Vehicles :Imovable
    {
        private string _company;
        private int _year;
        private string _model;
        public string Company { get { return _company; } set { _company = value; } }
        public int Year { get { return _year; } set { _year = value; } }
        public string Model { get { return _model; } set { _model = value; } }
        public abstract void Move();
    }
    public class Car : Vehicles
    {
        public override void Move()
        { Console.WriteLine("Car is moving");}
    }
    public class Bike : Vehicles
    {
        public override void Move()
        { Console.WriteLine("Bike is moving");}
    }
    public class Truck : Vehicles
    {
        public override void Move()
        {Console.WriteLine("Truck is moving");}
    }
}
