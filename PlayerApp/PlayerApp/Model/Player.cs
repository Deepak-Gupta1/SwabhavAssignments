using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerApp.Model
{
    internal class Player
    {
        private readonly int _id;
        private readonly string _name;
        private float _age=18;
        private static int _instanceCount;
        private static int _headCount;

        static Player()
        {
            _headCount = 0;
            Console.WriteLine("Inside static Constructor");

        }
        public Player(int _id, string _name, float _age)
        {
            this._id = _id;
            this._name = _name;
            this._age = _age;
           _instanceCount+=1;
            Console.WriteLine("Inside Constructor");
        }
        public Player(int _id, string _name):this(_id,_name,18)
        {
            
        }
        public int Id { get { return _id; } }
        public string Name { get { return _name; } }

        public float Age { get { return _age; } }

        public int InstanceCount
        {
            get { return _instanceCount; }
        }
        
        public static int HeadCount
        {
            get { return _instanceCount; }
        }

        public Player WhoIsElder(Player second)
        {
            if(this.Age < second.Age)
            {
                return second;
            }

            return this;
        }
    }
}
