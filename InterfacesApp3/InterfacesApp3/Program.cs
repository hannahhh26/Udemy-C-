using System.Diagnostics;

namespace InterfacesApp3
{
    public interface ILogger
    {
        void Log(string message);
    }

    public class FileLogger: ILogger
    {
        public void Log(string message) 
        {
            string directoryPath = @"C:\Logs";
            string filePath = Path.Combine(directoryPath, "log.txt");

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            File.AppendAllText(filePath, message + "\n");
        }
    }

    public class Application
    {
        private readonly ILogger _logger;

        public Application(ILogger logger)
        {
            _logger = logger;
        }

        public void DoWork()
        {
            _logger.Log("Work started!");
            // DO ALL THE WORK
            _logger.Log("Work finished!");
        }
    }

    public class DatabaseLogger : ILogger
    {
        public void Log(string message)
        {
            // Implement logic to log message to a database
            Console.WriteLine($"Logging to database. {message}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ILogger fileLogger = new FileLogger();
            Application app = new Application(fileLogger);
            app.DoWork();

            ILogger dbLogger = new DatabaseLogger();
            app = new Application(dbLogger);   
            app.DoWork();

            Console.ReadKey();
        }
    }
}
