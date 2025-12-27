// See https://aka.ms/new-console-template for more information

using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Enter a number!");

double num1 = 0;

string userInput  = Console.ReadLine();

num1 = double.Parse(userInput);

Console.WriteLine("Enter another number!");

double num2 = 0;

string userInput2 = Console.ReadLine();

num2 = double.Parse(userInput2);

double sum = num1 + num2;
sum = Math.Round(sum, 2);

Console.WriteLine($"{num1} + {num2} = {sum}");
Console.ReadKey();