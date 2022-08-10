namespace BusinessLayer
{
    public class TaxCalculator
    {
        private Common.ILoggerStrategy _logger;

        public TaxCalculator(Common.ILoggerStrategy ILogger)
        {
            _logger = ILogger;
        }
       
        public int Calculate(int value1 ,int value2)
        {
            int result = -1;
            try
            {
                result = value1 / value2;
            }
            catch (Exception ex)
            {
               
            }
            return result;
        }


    }
}