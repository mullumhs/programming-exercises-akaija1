using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

/*
===============================================================================
PROJECT 10: NUMBER OPERATIONS 2
===============================================================================
Objective:
- Enhance understanding of user input, selection, and performing mathematical operations based on user choices.

Main Tasks:
1. Prompt the user to enter values for variables 'X' and 'Y'.
2. Ask the user to choose a mathematical operation (Add or Subtract), and store the choice in a string variable.
3. Utilise selection statements to perform the chosen operation and output the result.

Questions:
1. What is the difference between Console.ReadLine() and Console.ReadKey()?
2. Why is the choice stored as a string instead of an integer?

Extension Tasks:
1. Research online to learn how to perform exponentiation, e.g., X to the power of Y.
2. Research online to learn how to use the 'ToString()' function to round the answer to two decimal places.

Example:
- Below is an example of the program's output:

    Please enter a number for X:
    7
    Please enter a number for Y:
    3

    What would you like to do:
    1. Addition
    2. Subtraction

    1 

    The answer is: 10

    Press any key to exit...

Additional Resources:
- Selection Statements: https://www.tutorialspoint.com/csharp/csharp_decision_making.htm
- if-else Statement: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/if-else
- Console.ReadKey: https://www.dotnetperls.com/console-readkey
- Mathematical Functions in C#: https://www.ictdemy.com/csharp/basics/mathematical-functions-in-csharp-net-math-library
===============================================================================
*/

namespace ProgrammingExercisesIST
{
    class Project_10_NumberOperations2
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please enter a number for X:");
            double x = Convert.ToDouble(Console.ReadLine());


            
            Console.WriteLine("Please enter a number for Y:");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("what operation would you like");

            Console.WriteLine("1. For Subraction");

            Console.WriteLine("2. For Add");

            Console.WriteLine("3. For power");

            Console.WriteLine("4. For Divide");

            int operation = (Console.ReadLine());
            
            if (operation == 1)
            {
                Console.WriteLine($"{x} - {y} = {x - y} ");

            }

            else if (operation == 2)
            {
                Console.WriteLine($"{x} + {y} = {x + y} ");

            }


            else if (operation == 3)
            {
             
                double res;
                res = Math.Pow(x, y);
                Console.WriteLine("Math.Pow(X,Y) = " + res);
                res = Math.Pow(y, x);
                Console.WriteLine("Math.Pow(Y,X) = " + res);
            }

            else if (operation == 4)
            {
                Console.WriteLine($"{x}/{y} = {ToString(x / y)} ");
                Console.WriteLine($"{x}/{y} = {x / y} ");

            }
            // Wait for any key before exiting
            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
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