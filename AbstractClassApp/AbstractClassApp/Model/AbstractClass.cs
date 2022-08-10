
namespace AbstractClassApp.Model
{
    abstract class AbstractClass
    {

        // Non abstract method
        public int AddTwoNumbers(int Num1, int Num2)
        {
            return Num1 + Num2;
        }

        // An abstract method which overridden in the derived class
        public abstract int MultiplyTwoNumbers(int Num1, int Num2);

    }

}

