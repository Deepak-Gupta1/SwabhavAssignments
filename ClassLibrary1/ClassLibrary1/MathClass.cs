namespace ClassLibrary1
{
    public class MathClass
    {
        public double Calculate(double num1, double num2, string op)
        {
            double result = 0;
            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = (double)num1 / num2;
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
