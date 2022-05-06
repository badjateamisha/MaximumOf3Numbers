// See https://aka.ms/new-console-template for more information
using MaximumOfThree;
Console.WriteLine("Welcome to Maximum of Three using generics!");

Console.WriteLine("Please enter the values of integers x, y and z:");
int x = Convert.ToInt16(Console.ReadLine());
int y = Convert.ToInt16(Console.ReadLine());
int z = Convert.ToInt16(Console.ReadLine());
UsingInt usingInt = new UsingInt();
int result = usingInt.Maximum(x, y, z);
Console.WriteLine("The Maximum of three integers is :" + result);

