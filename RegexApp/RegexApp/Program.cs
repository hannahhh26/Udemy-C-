using System.Text.RegularExpressions;

namespace RegexApp
{
    internal class Program
    {
        public static void ExtractPattners(string input)
        {
            Regex regex = new Regex(@"[a-zA-Z0-9]+?@\w+?\.\w+");
            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //string pattern = @"\d";
            //Regex regex = new Regex(pattern);

            //string text = "Hi there, my number is 1234";

            //MatchCollection matches = regex.Matches(text);

            //Console.WriteLine($"{matches.Count} hits found: \n {text}");

            //foreach (Match hit in matches)
            //{
            //    GroupCollection group = hit.Groups;
            //    Console.WriteLine($"{group[0].Value} found at {group[0].Index}");
            //}
            ExtractPattners("Contact us at support@example.com");

            

            Console.ReadKey();

        }
    }
}
