using System;

/*
===============================================================================
PROJECT 12: BETTER AREA CALCULATOR
===============================================================================
Objective:
- Learn how to refactor code into more manageable chunks using methods, improving readability and reusability of the code.

Main Tasks:
1. Copy and paste your program from the previous lesson into this one.
2. Write methods for each of the main functions of the program. E.g. ShowMenu, CalculateRectangle, CalculateTriangle, etc.
3. Move the corresponding code into each method.
4. Call the methods from the Main method.

Questions:
1. What is the purpose of splitting the code into smaller chunks (methods)?
2. Why is it important to give a warning message to the user in the else statement?

Extension Tasks:
1. Add a trapezium option to the program. It should also be a separate method.

Example:
- Below is an example of the program's output:

    Choose an Option:
    1. Area of Circle
    2. Area of Rectangle
    3. Area of Triangle

    2

    Enter Width: 3
    Enter Height: 4

    The area of the rectangle is 12

    "Press any key to exit...

Additional Resources:
- Methods: https://www.w3schools.com/cs/cs_methods.php
===============================================================================
*/

namespace ProgrammingExercisesIST
{
    class Project_12_BetterAreaCalculator
    {
        static void Main(string[] args)
        {
            // Your code goes below here

            start();

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

            exit();






        }
        static void start()
        {
            Console.WriteLine("Choose an Option:");

            Console.WriteLine("1. Area of Circle");

            Console.WriteLine("2. Area of Rectangle");

            Console.WriteLine("3. Area of Triangle");
            
            Console.WriteLine("4. Area of a Trapezium");
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
            double trap = (a +b) * Height ;
            double area = trap / 2;
            Console.WriteLine($"The are of this Trapezium is {area}");
        }

        static void exit()
        {
            Console.WriteLine("Press Any Key to Exit");
            Console.ReadKey();
        }



    }

}

/*
===============================================================================
FEEDBACK AREA: Paste your AI feedback here before submission:
===============================================================================



===============================================================================
*/