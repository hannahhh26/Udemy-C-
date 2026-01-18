namespace ListsApp
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Product> products = new List<Product>
            {
                new Product {Name = "Apple", Price = 0.80},
                new Product {Name = "Banana", Price = 0.30},
                new Product {Name = "Cherry", Price = 3.80}
            };

            products.Add(new Product { Name = "Berries", Price = 2.99 });

            List<Product> cheapProducts = products.Where(p => p.Price < 1.0).ToList();

            Console.WriteLine("Avaiable products: ");

            foreach (Product product in products)
            {
                Console.WriteLine($"Product name: {product.Name} for £{product.Price}");
            }

            // Declare a list when you know what to put inside
            List<string> colors =
                [
                    "red",
                    "blue",
                    "green",
                ];

            foreach (var item in colors)
            {
                Console.WriteLine($"{item} ");
            }

            List<int> numbers = new List<int> { 10, 5, 15, 3, 9, 25, 18};

            numbers.Sort();
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            // This will return a list of numbers that are 10 and higher
            List<int> higherEqualTen = numbers.FindAll(x => x >= 10);

            foreach (int number in higherEqualTen)
            {
                Console.WriteLine(number);
            }

            // Define the predicate to check if a number is greater than 10
            Predicate<int> isGreaterThanTen = x => x >= 10;
            List<int> higherEqualTen2 = numbers.FindAll(isGreaterThanTen);

            bool hasLargeNumber = numbers.Any(x => x > 20);

            if(hasLargeNumber)
            {
                Console.WriteLine("Has large number");
            }
            else
            {
                Console.WriteLine("No large number");
            }

                Console.ReadKey();
        }
    }
}
