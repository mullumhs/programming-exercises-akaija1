using System;

/*
===============================================================================
PROJECT 13: METHODS
===============================================================================
Objective:
- Understand and practice creating and calling methods in C#.

Main Tasks:
1. Create a method called "SayHello" to print the message "Hello World".
2. Create a method called "Exit" to print the message "Press any key to exit..." and wait for user input.

Questions:
1. What is a method?
2. What does the 'void' keyword mean?
3. What does it mean to 'call' a method?

Extension Tasks:
1. Try creating extra methods that do whatever you like.
2. Try calling the methods multiple times.
3. Try calling methods from within another method.

Additional Resources:
- Methods: https://www.tutorialspoint.com/csharp/csharp_methods.htm
- Methods: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods
===============================================================================
*/

namespace ProgrammingExercisesIST
{
    class Project_13_Methods
    {
        static void Main(string[] args)
        {
            // Call the methods here
            Main1();
            
            int method = Convert.ToInt32(Console.ReadLine());

            if (method == 1)
            {
                sayhello();
            
            }
            else if (method == 2) 
            {
                calculator();
                
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    circle();
                }
            
                else if (choice == 2)
                {
                    rectangle();
                }

                else if (choice == 3)
                {
                    triangle();
                }


                else if (choice == 4)
                {
                    trapezium();
                }

                Exit();
            }
            else if (method == 3)
            {
                Exit();
            }
        
        
        
        
        }

        // Write your methods here
        static void Main1()
        {
            Console.WriteLine("1.SayHello");

            Console.WriteLine("2.Calculator");

            Console.WriteLine("3.Exit");
        }
        static void sayhello()
        {
            Console.WriteLine("Hello World");
            Console.ReadLine();
        }
        static void calculator() 
        {
            Console.WriteLine("Choose an Option:");

            Console.WriteLine("1. Area of Circle");

            Console.WriteLine("2. Area of Rectangle");

            Console.WriteLine("3. Area of Triangle");

            Console.WriteLine("4. Area of a Trapezium");
        }
        static void Exit() 
        {
            Console.WriteLine("Press Any Key to Exit");
            Console.ReadKey();
        }
        static void circle()
        {
            Console.Write("Enter the radius:");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"The are of this circle is {area}");
        }

        static void rectangle()
        {
            Console.Write("Enter Width:");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Height");
            int height = Convert.ToInt32(Console.ReadLine());
            int area = width * height;
            Console.WriteLine($"The are of this rectangle is {area}");
        }

        static void triangle()
        {
            Console.Write("Enter Length:");
            int Length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Height");
            int height = Convert.ToInt32(Console.ReadLine());
            double area = Length * height / 2;
            Console.WriteLine($"The are of this Triangle is {area}");
        }

        static void trapezium()
        {
            Console.Write("Enter the Top:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Length:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Height:");
            int Height = Convert.ToInt32(Console.ReadLine());
            double trap = (a + b) * Height;
            double area = trap / 2;
            Console.WriteLine($"The are of this Trapezium is {area}");
        }








    }

}

/*
===============================================================================
FEEDBACK AREA: Paste your AI feedback here before submission:
===============================================================================



===============================================================================
*/