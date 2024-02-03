namespace BookStore.Services
{
    public interface ILoggingService
    {
        void Log(string message);
    }
    public class ConsoleLoggingService : ILoggingService
    {
        public void Log(string message) 
        { 
            Console.WriteLine(message); 
        }

    }
}
