// See https://aka.ms/new-console-template for more information
using MaxOfThree;

Console.WriteLine("Program to find maximum of three! \nPlease enter three numbers :");
int num1 = Convert.ToInt16(Console.ReadLine());
int num2 = Convert.ToInt16(Console.ReadLine());
int num3 = Convert.ToInt16(Console.ReadLine());
UsingInt first = new();
int result = first.MaximumOfThree(num1,num2,num3);
Console.WriteLine("The Maximum of the given numbers is :"+result);
