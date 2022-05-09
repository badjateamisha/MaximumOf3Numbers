// See https://aka.ms/new-console-template for more information
using MaximumOfThree;


Console.WriteLine("Welcome to Maximum of Three using generics!");

while (true)
{

    Console.WriteLine("Choose the Program to be executed :\n1)using INT\n2)using Float\n3)usingString\n4)using generic class\n5)using generic class&Method\n6)using array");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            Console.WriteLine("Please enter the values of integers x, y and z:");
            int x = Convert.ToInt16(Console.ReadLine());
            int y = Convert.ToInt16(Console.ReadLine());
            int z = Convert.ToInt16(Console.ReadLine());
            UsingInt usingInt = new UsingInt();
            int result = usingInt.Maximum(x, y, z);
            Console.WriteLine("The Maximum of three integers is :" + result);
            Console.WriteLine("\n");
            break;
        case 2:
            Console.WriteLine("Please enter the values of floats a, b and c:");
            double a = Convert.ToInt16(Console.ReadLine());
            double b = Convert.ToInt16(Console.ReadLine());
            double c = Convert.ToInt16(Console.ReadLine());
            UsingFloat Usingfloat = new UsingFloat();
            double result1 = Usingfloat.Maximumfloat(a, b, c);
            Console.WriteLine("The Maximum of three integers is :" + result1);
            Console.WriteLine("\n");
            break;
    }
}