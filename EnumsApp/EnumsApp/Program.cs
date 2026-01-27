namespace EnumsApp
{
    internal class Program
    {
        enum Day { Mo, Tu, We, Th, Fr, Sa, Su};

        static void Main(string[] args)
        {
            Day fr = Day.Fr;
            Day su = Day.Su;

            Day a = Day.Fr;

            Console.WriteLine(fr==a);
            Console.WriteLine((int)Day.Mo);
            Console.ReadKey();
        }

        
    }
}
