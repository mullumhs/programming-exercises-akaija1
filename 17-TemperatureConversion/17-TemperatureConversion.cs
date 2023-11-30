using System;
using System.Runtime.Remoting.Messaging;

/*
===============================================================================
PROJECT 17: TEMPERATURE CONVERSION
===============================================================================
Objective:
- Utilise functions to create a program that converts temperatures between Celsius and Fahrenheit based on user input.

Example Output:
- This is how your program should behave:

    What would you like to do?
    1. Celsius to Fahrenheit
    2. Fahrenheit to Celsius
    1
    Enter temperature in Celsius: 0
    That is 32 Fahrenheit

Pseudocode:
    BEGIN Main
        choice = MainMenu()
        IF choice = 1 THEN
            result = CelsiusToFahrenheit()
            PRINT result
        ELSE IF choice = 2 THEN
            result = FahrenheitToCelsius()
            PRINT result
        ELSE
            PRINT "Invalid Choice!"
        END IF
    END Main

    BEGIN CelsiusToFahrenheit
        c = GetTemperature("Celsius")
        f = (c * 9/5) + 32
        RETURN f
    END CelsiusToFahrenheit 

    BEGIN FahrenheitToCelsius
        f = GetTemperature("Fahrenheit")
        c = (f - 32) * 5/9
        RETURN c
    END FahrenheitToCelsius

    BEGIN GetTemperature(unit)
        PRINT "Enter temperature in " + unit
        INPUT temp
        RETURN temp
    END GetTemperature

Main Tasks:
1. Write a function to convert Celsius to Fahrenheit.
2. Write a function to convert Fahrenheit to Celsius.
3. Implement a menu for the user to choose which conversion they want to perform.
4. Display the result of the conversion based on the user's choice.

Questions:
1. What did you find challenging about implementing an entire program yourself?

Extension Tasks:
1. Add an option in the menu for the user to exit the program.
2. Enhance the program to handle invalid input gracefully without crashing.
3. Research and implement a function to convert temperature to and from Kelvin.
===============================================================================
*/

namespace ProgrammingExercisesIST
{
    class Project_17_TemperatureConversion
    {
        static void Main(string[] args)
        {
            // Write your code here
            string choice = MainMenu();

            choices(choice);




            WaitForKeyPress();
        }


        static void choices(string choice)
        {
            if (choice == "1")
            {
                double cel = conCtoF();

                ConvertionF(cel);






            }

            else if (choice == "2")
            {
                double cal = ConFtoC();

                ConvertionC(cal);




            }






        }


        static double conCtoF()
        {
            Console.WriteLine("Type in the Temperature (in Celsius) to convert");

            double Cel = Convert.ToDouble(Console.ReadLine());

            return Cel;


        }

        static void ConvertionF(double cel)
        {
            double Fair = (cel * 9/5) + 32;

            Console.WriteLine($"{Fair} Fahrenheit");



        }

        static double ConFtoC() 
        {
            Console.WriteLine("Type in the Temperature (in Fahrenheit) to convert");

            double cal = Convert.ToDouble(Console.ReadLine());

            return cal;

        }


        static void ConvertionC(double cal)
        {

            double Fair = (cal - 32) * 5 / 9;
            
            Console.WriteLine($"{Fair} Celsius");
        }


















        private static string MainMenu()
        {
            Console.Clear();
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Celsius to Fahrenheit");
            Console.WriteLine("2. Fahrenheit to Celsius");
            string choice = Console.ReadLine();
            return choice;
        }
        private static void WaitForKeyPress()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
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
