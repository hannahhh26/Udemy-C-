namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer myCustomer = new Customer();
            Customer myCustomer2 = new Customer("John");


            myCustomer.GetDetails();
            myCustomer2.GetDetails();

            Console.ReadKey();
        }
    }
}
