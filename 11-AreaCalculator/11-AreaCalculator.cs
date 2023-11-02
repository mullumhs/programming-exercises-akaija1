using System;

/*
===============================================================================
PROJECT 11: AREA CALCULATOR
===============================================================================
Objective:
- Enhance understanding of selection, user input, and maths operations by calculating areas of different shapes based on user choices.

Main Tasks:
1. Create a menu that asks the user to choose between calculating the area of a rectangle or triangle.
2. Prompt the user for their choice and store it in a variable.
3. Using selection, complete the program to calculate the area of either rectangles or triangles
4. Handle invalid menu choices with a warning message.
5. Create a "Press any key to exit..." message at the end of the program.

Questions:
1. What is the difference between Console.Write() and Console.WriteLine()?
2. How is the area of each shape calculated? What mathematical operations are used?

Extension Tasks:
1. Extend the program to calculate the area of other shapes and add them to the menu. E.g. Circle, 
m.

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
- Mathematical Functions in C#: https://www.ictdemy.com/csharp/basics/mathematical-functions-in-csharp-net-math-library
===============================================================================
*/

namespace ProgrammingExercisesIST
{
    class Project_11_AreaCalculator
    {
        static void Main(string[] args)
        {
            // Your code goes below here
            Console.WriteLine("Choose an Option:");

            Console.WriteLine("1. Area of Circle");

            Console.WriteLine("2. Area of Rectangle");

            Console.WriteLine("3. Area of Triangle");
            
            int choice  = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("Enter the radius:");
                double radius = Convert.ToDouble(Console.ReadLine());
                double area = Math.PI * Math.Pow(radius, 2);
                Console.WriteLine($"The are of this circle is {area}");
                
            }

            else if (choice == 2)
            {
                Console.Write("Enter Width:");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the Height");
                int height = Convert.ToInt32(Console.ReadLine());
                int area = width * height;
                Console.WriteLine($"The are of this rectangle is {area}");

                ;

            }

            else if (choice == 3)
            {
                Console.Write("Enter Length:");
                int Length = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Height");
                int height = Convert.ToInt32(Console.ReadLine());
                double area = Length * height / 2;
                Console.WriteLine($"The are of this Triangle is {area}");


                


            }


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