using System.Reflection.Metadata;
using System.Threading.Channels;

namespace Test
{
    // Define the delegate that will be used for the event
    public delegate void StockPriceChangedHandler(string message);

    // Define the Stock class which includes the event system
    public class Stock
    {
        // Declare the event using the delegate
        public event StockPriceChangedHandler OnStockPriceChanged;
        // Private field to store the stock price
        private decimal _price;
        // Private field to store the threshold
        private decimal _threshold;

        public decimal Price
        {
            get { return _price; }
            set
            {
                _price = value;
                if (_price > _threshold)
                {
                    RaiseStockPriceChangedEvent("The stock price is above threshold");
                }
            }
        }

        public decimal Threshold { get { return _threshold; }
            set 
            {
                _threshold = value;
            } 
        }

        // Method to raise the stock price changed event
        protected virtual void RaiseStockPriceChangedEvent(string message)
        {
            // Invoke the event
            //TODO
            OnStockPriceChanged?.Invoke(message);
        }
    }

    // Define the subscriber class which reacts to the event
    public class StockAlert
    {
        // Method that handles the event and prints a message to the console
        //TODO
        public void OnStockPriceChanged(string message)
        {
            Console.WriteLine($"Alert: {message}");
        }
    }

    // Program class to simulate the stock price changes and test the event system
    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Stock and StockAlert
            //TODO
            Stock stock = new Stock();
            StockAlert alert = new StockAlert();

            // Subscribe to the stock price changed event
            //TODO
            stock.OnStockPriceChanged += alert.OnStockPriceChanged;

            // Set the alert threshold
            //TODO
            stock.Threshold = 120;

            // Simulate stock price changes
            //TODO
            stock.Price = 120;
            stock.Price = 150;
            stock.Price = 112;

            // Wait for user input to close the console
            //TODO
            Console.ReadKey();
        }
    }
}

