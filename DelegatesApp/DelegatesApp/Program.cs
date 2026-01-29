namespace DelegatesApp
{
    internal class Program
    {
        // 1. Declaration
        public delegate void LogHandler(string message);

        public class Logger
        {
            public void LogToConsole(string message)
            {
                Console.WriteLine($"Console Log: {message}");
            }

            public void LogToFile(string message)
            {
                Console.WriteLine($"File log: {message}");
            }
        }

        static void Main(string[] args)
        {
            Logger logger = new Logger();

            // Creating multicast delegate
            LogHandler logHandler = logger.LogToConsole;
            // Add another method to delegate
            logHandler += logger.LogToFile;


            // invoking a multicast delegate
            logHandler("Logging...");

            foreach (LogHandler handler in logHandler.GetInvocationList())
            {
                try
                {
                    handler("Event occured with error handling");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception caught: {ex.Message}");
                }

            }

            // Remove method from delegate
            if(IsMethodInDelegate(logHandler, logger.LogToFile))
            {
                logHandler -= logger.LogToConsole;
                Console.WriteLine("LogToFile method removed");
            }
            else
            {
                Console.WriteLine("LogToFile method not found");
            }

            if(logHandler != null)
            {
                InvokeSafely(logHandler, "Logging safely...");
            }


            Console.ReadKey();  

        }

        static void InvokeSafely(LogHandler logHandler, string message)
        {
            LogHandler tempLogHandler = logHandler;
            if (tempLogHandler != null)
            {
                tempLogHandler(message);
            }
        }

        static bool IsMethodInDelegate(LogHandler logHandler, LogHandler method)
        {
            if(logHandler == null)
            {
                return false;
            }

            foreach (var d in logHandler.GetInvocationList())
            {
                if(d == (Delegate)method)
                {
                    return true;
                }    
            }
            return false;
        }

        static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
