using System;

class Program
{
    static void Main()
    {
        int input, int1, int2, result;
        do
        {
            Console.WriteLine("");            
            Console.WriteLine("Enter the action to be perform");
            Console.WriteLine("Press 1 for Addition");
            Console.WriteLine("Press 2 for Substraction");
            Console.WriteLine("Press 3 for Multiplication");
            Console.WriteLine("Press 4 for Division");
            Console.WriteLine("Press 5 for Exit");
            Console.WriteLine("");

            input = int.Parse(Console.ReadLine());
            
            switch (input)
            {
                case 1:
                    Console.WriteLine("Enter 1st input"); 
                    int1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter 2st input"); 
                    int2 = int.Parse(Console.ReadLine());

                    result = int1 + int2;
                    Console.WriteLine("The result is " + result);
                    break;

                case 2:
                    Console.WriteLine("Enter 1st input"); 
                    int1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter 2st input"); 
                    int2 = int.Parse(Console.ReadLine());

                    result = int1 - int2;
                    Console.WriteLine("The result is " + result);    
                    break;

                case 3:
                    Console.WriteLine("Enter 1st input"); 
                    int1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter 2st input"); 
                    int2 = int.Parse(Console.ReadLine());

                    result = int1 * int2;
                    Console.WriteLine("The result is " + result);
                    break;

                case 4:
                    Console.WriteLine("Enter 1st input"); 
                    int1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter 2st input"); 
                    int2 = int.Parse(Console.ReadLine());

                    result = int1 / int2;
                    Console.WriteLine("The result is " + result);
                    break;

                case 5:
                    Console.WriteLine("Thank You!"); 
                    break;

                default: 
                    Console.WriteLine("Input Invalid, Try Again!");
                    break;
            }

        } while (input != 5);
        Console.ReadKey();
    }    
}