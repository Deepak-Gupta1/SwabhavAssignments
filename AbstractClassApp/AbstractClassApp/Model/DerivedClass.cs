using System;
namespace AbstractClassApp.Model
{
    internal class DerivedClass : AbstractClass
    {
        // implementing the abstract method 'MultiplyTwoNumbers' using override keyword,
        public override int MultiplyTwoNumbers(int Num1, int Num2)
        {
            return Num1 * Num2;
        }
    }
}
