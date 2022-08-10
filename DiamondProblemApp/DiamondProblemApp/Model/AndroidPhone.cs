using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondProblemApp.Model
{
    interface FeaturePhone {
        void Call();
        void Music();
    }
    interface SmartPhone
    {
        void Camera();
        void Video();
    }

    internal class AndroidPhone : FeaturePhone, SmartPhone
    {
        public void Call()
        {
            Console.WriteLine("Calling Feature");
        }
        public void Music()
        {
            Console.WriteLine("Play Music Feature");
        }
        public void Video()
        {
            Console.WriteLine("Play Video Feature");
        }
        public void Camera()
        {
            Console.WriteLine("Camera Feature");
        }
        public void Game()
        {
            Console.WriteLine("Playing Game Feature");
        }

    }
}
