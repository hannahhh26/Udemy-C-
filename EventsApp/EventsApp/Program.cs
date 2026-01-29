namespace EventsApp
{
    public delegate void Notify(string message);

    public class EventPublisher
    {
        // Use "On" for events
        public event Notify OnNotify;

        public void RaiseEvent(string message)
        {
            OnNotify?.Invoke(message);
        }
    }

    public class EventSubscriber
    {
        public void OnEventRaised(string message)
        {
            Console.WriteLine($"Event recieved: {message}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            EventPublisher publisher = new EventPublisher();
            EventSubscriber subsriber = new EventSubscriber();
            publisher.OnNotify += subsriber.OnEventRaised;

            publisher.RaiseEvent("test"); 

            Console.ReadKey();
        }
    }
}
