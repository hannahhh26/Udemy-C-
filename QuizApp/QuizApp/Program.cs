// See https://aka.ms/new-console-template for more information

using System.Security.Cryptography.X509Certificates;

string question1 = "What is the capital of Germany?";
string answer1 = "Berlin";

string question2 = "What is 2 + 2";
string answer2 = "4";

string question3 = "What colour do you get when mixing blue and yellow";
string answer3 = "Green";

int score = 0;

Console.WriteLine(question1);
string userAnswer1 = Console.ReadLine();
if  (userAnswer1 == answer1)
{
    Console.WriteLine("Correct!");
    score += 1;
}
else
{
    Console.WriteLine($"Wrong, correct answer is {answer1}");
}

Console.ReadKey();