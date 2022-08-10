using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceApp.Model
{
    public interface IterfaceAnimal
    {
        void animalSound(); // interface method (does not have a body)
        void animalEat();
    }
    internal class Dogs : IterfaceAnimal
    {
        public void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The Dogs says: bow boww");
        }
        public void animalEat() {
            Console.WriteLine("The Dogs eat: pedigree");

        }
    }
}
