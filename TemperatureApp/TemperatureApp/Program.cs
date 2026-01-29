namespace TemperatureApp
{
    // public delegate void TemperatureChangeHandler(string message);

    // Common practice to end class name with class your inheriting from
    public class TemperatureChangedEventArgs : EventArgs
    {
        // Property holding temperature
        public int Temperature { get; }

        // Constructor
        public TemperatureChangedEventArgs(int temperature)
        {
            Temperature = temperature;
        }
    }

    public class TemperatureMonitor
    {
        public event EventHandler<TemperatureChangedEventArgs> TemperatureChanged;

        // public event TemperatureChangeHandler OnTemperatureChanged;

        private int _temperature;

        public int Temperature
        {
            get { return _temperature; }
            set
            {
                if (_temperature != value)
                {
                    _temperature = value;
                    // Raise event
                    OnTemperatureChanged(new TemperatureChangedEventArgs(_temperature));
                }
            }
        }

        protected virtual void OnTemperatureChanged(TemperatureChangedEventArgs e)
        {
            // Letting every subsriber know!
            TemperatureChanged?.Invoke(this, e);
        }

    }

    // Subsriber
    public class TemperatureAlert
    {
        public void OnTemperatureChanged(object sender, TemperatureChangedEventArgs e)
        {
            Console.WriteLine($"Alert: temperature is {e.Temperature} sender is: {sender}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            TemperatureMonitor monitor = new TemperatureMonitor();
            TemperatureAlert alert = new TemperatureAlert();
            monitor.TemperatureChanged += alert.OnTemperatureChanged;

            monitor.Temperature = 20;

            Console.WriteLine("Enter the temperature");
            monitor.Temperature = int.Parse(Console.ReadLine());

            Console.ReadKey();
        }
    }
}
