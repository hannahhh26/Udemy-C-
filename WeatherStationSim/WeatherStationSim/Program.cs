using System.Runtime.ExceptionServices;

namespace WeatherStationSim
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of days to simulate:");
            int days = int.Parse(Console.ReadLine());

            int[] temperature = new int[days];
            string[] conditions = { "Sunny", "Rainy", "Cloudy", "Snowy" };
            string[] weatherConditions = new string[days];

            Random random = new Random();

            for (int i = 0; i < days; i++)
            {
                temperature[i] = random.Next(-10, 40);
                weatherConditions[i] = conditions[random.Next(conditions.Length)];
            }

            Console.WriteLine($"Max temp: {temperature.Max()}");
            Console.WriteLine($"Min temp: {temperature.Min()}");

            double averageTemp = AverageTemp(temperature);
            Console.WriteLine($"Average temp: {averageTemp}");
            Console.ReadKey();

        }

        static string MostCommonCondition(string[] conditions)
        {
            int count = 0;
            string mostCommon = conditions[0];

            for (int i = 0; i < conditions.Length; i++)
            {
                int tempCount = 0;
                for (int j = 0; j < conditions.Length; j++)
                {
                    if (conditions[j] == conditions[i])
                    {
                        tempCount++;

                    }
                }
                if (tempCount > count)
                {
                    mostCommon = conditions[i];
                }
            }
            return mostCommon;
        }

        static double AverageTemp(int[] temperature)
        {
            double sum = 0;
            foreach (int temp in temperature)
            {
                sum += temp;
            }
            double average = sum / temperature.Length;
            return average;
        }
    }


}
