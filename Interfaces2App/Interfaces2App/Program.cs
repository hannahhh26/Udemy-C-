namespace Interfaces2App
{
    public interface IPaymentProcessor
    {
        void ProcessPayment(decimal amount);
    }

    public class CreditCardProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing credit card payment of {amount}");
            // Implement credit card payment logic
        }
    }

    public class PaypalProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing paypal payment of {amount}");
            // Implement credit card payment logic
        }
    }

    public class PaymentService
    {
        private readonly IPaymentProcessor _processor;

        public PaymentService( IPaymentProcessor processor )
        {
            _processor = processor;
        }

        public void ProcessOrderPayment(decimal amount)
        {
            _processor.ProcessPayment(amount);
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            IPaymentProcessor creditCardProcessor = new CreditCardProcessor();
            PaymentService paymentService = new PaymentService(creditCardProcessor);
            paymentService.ProcessOrderPayment(100.34m);

            IPaymentProcessor paypalProcessor = new PaypalProcessor();
            paymentService = new PaymentService(paypalProcessor);
            paymentService.ProcessOrderPayment(200.23m);

            Console.ReadKey();
        }
    }
}
