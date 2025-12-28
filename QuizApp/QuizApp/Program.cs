// See https://aka.ms/new-console-template for more information

using System.Security.Cryptography.X509Certificates;

string question1 = "What is the capital of Germany?";
string answer1 = "berlin";

string question2 = "What is 2 + 2";
string answer2 = "4";

string question3 = "What colour do you get when mixing blue and yellow";
string answer3 = "green";

int score = 0;

Console.WriteLine(question1);
string userAnswer1 = Console.ReadLine();
if  (userAnswer1.Trim().ToLower() == answer1)
{
    Console.WriteLine("Correct!");
    score += 1;
}
else
{
    Console.WriteLine($"Wrong, correct answer is {answer1}");
}

Console.WriteLine(question2);
string userAnswer2 = Console.ReadLine();
if (userAnswer2 == answer2)
{
    Console.WriteLine("Correct!");
    score += 1;
}
else
{
    Console.WriteLine($"Wrong, correct answer is {answer2}");
}

Console.WriteLine(question3);
string userAnswer3= Console.ReadLine();
if (userAnswer3.Trim().ToLower() == answer2)
{
    Console.WriteLine("Correct!");
    score += 1;
}
else
{
    Console.WriteLine($"Wrong, correct answer is {answer3}");
}

Console.WriteLine($"Quiz completed! Your final score is {score}/3");
if (score == 3)
{
    Console.WriteLine("You got them all correct");
}
else if (score > 0)
{
    Console.WriteLine("You did alright");
}
else
{
    Console.WriteLine("You got them all wrong");
}
    Console.ReadKey();