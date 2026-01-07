namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer myCustomer = new Customer();
            Customer myCustomer2 = new Customer("John");
            Console.WriteLine();

            myCustomer.GetDetails();
            myCustomer2.GetDetails();

            Console.ReadKey();
        }
    }
}
