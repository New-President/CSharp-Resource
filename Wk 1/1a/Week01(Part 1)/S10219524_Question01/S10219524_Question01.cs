using System;

namespace S10219524_Question01
{
    class S10219524_Question01
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your weight (kg): ");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your height (m): ");
            double height = Convert.ToDouble(Console.ReadLine());
            double bmi = weight / (height * height);
            Console.WriteLine("Your body mass index is " + bmi.ToString("0.00"));
            string HC;
            if (bmi < 18.5)
            {
                HC = "Under weight";
            }
            else if (bmi >= 18.5 && bmi < 23)
            {
                HC = "Normal weight";
            }
            else if (bmi >= 23 && bmi < 27.5)
            {
                HC = "Over weight";
            }
            else
            {
                HC = "Obese";
            }
            Console.WriteLine("You are " + HC +".");
        }
    }
}
