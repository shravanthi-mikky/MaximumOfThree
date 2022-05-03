// See https://aka.ms/new-console-template for more information
using MaxOfThree;

Console.WriteLine("Program to find maximum of three!");

//Finding maximum of three float values

while(true)
{
    Console.WriteLine("Please choose the option :\n1)Maximum of Integers \n2)Maximum of three Floating values\n3)Maximum of Strings ");
    int option = Convert.ToInt16(Console.ReadLine());   
    switch(option)
    {
        case 1:
            Console.WriteLine("Please enter three Integer values :");
            int num1 = Convert.ToInt16(Console.ReadLine());
            int num2 = Convert.ToInt16(Console.ReadLine());
            int num3 = Convert.ToInt16(Console.ReadLine());
            UsingInt first = new();
            int result = first.MaximumOfThree(num1, num2, num3);
            Console.WriteLine("The Maximum of the given numbers is :" + result);
            break;
        case 2:
            Console.WriteLine("Please enter three Float values :");
            double num4 = Convert.ToDouble(Console.ReadLine());
            double num5 = Convert.ToDouble(Console.ReadLine());
            double num6 = Convert.ToDouble(Console.ReadLine());
            MaxOfDouble maxOfDouble = new();
            double result2 = maxOfDouble.MaximumOfThree(num4, num5, num6);
            Console.WriteLine("The Maximum of the given numbers is :" + result2);
            break;
        case 3:
            Console.WriteLine("Please enter three strings :");
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();
            MaxOf3Strings MaximumOf3 = new MaxOf3Strings();
            string result4 = MaximumOf3.MaximumOfThre(a, b, c);
            Console.WriteLine("The result of MaxOf3Strings :" + result4);
            break;
        default:
            Console.WriteLine("Please choose correct option!");
            break;
    }
}
