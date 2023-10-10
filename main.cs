using System;

namespace CalculatorBMI
{
    class Program
    {
        static double GetValidDoubleInput(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string userInput = Console.ReadLine();

                if (double.TryParse(userInput, out double result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }

        static void Main(string[] args)
        {
            try
            {
                double weight = GetValidDoubleInput("Enter your body weight in kilograms: ");
                double height = GetValidDoubleInput("Specify your height in centimeters: ");

                double heightM = height / 100;

                // Calculation of BMI
                double bmi = weight / (heightM * heightM);

                if (bmi < 16)
                {
                    Console.WriteLine("Your BMI indicates starvation.");
                }
                else if (bmi >= 16 && bmi <= 16.99)
                {
                    Console.WriteLine("Your BMI indicates emaciation.");
                }
                else if (bmi >= 17 && bmi <= 18.49)
                {
                    Console.WriteLine("Your BMI indicates underweight.");
                }
                else if (bmi >= 18.5 && bmi <= 24.99)
                {
                    Console.WriteLine("Your BMI indicates correct.");
                }
                else if (bmi >= 25 && bmi <= 29.99)
                {
                    Console.WriteLine("Your BMI indicates overweight.");
                }
                else if (bmi >= 30 && bmi <= 34.99)
                {
                    Console.WriteLine("Your BMI indicates Level I obesity.");
                }
                else if (bmi >= 35 && bmi <= 39.99)
                {
                    Console.WriteLine("Your BMI indicates Level II obesity.");
                }
                else
                {
                    Console.WriteLine("Your BMI indicates extreme obesity.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}
