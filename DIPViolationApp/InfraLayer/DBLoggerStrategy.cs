namespace InfraLayer
{
    public class DBLoggerStrategy : Common.ILoggerStrategy
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}