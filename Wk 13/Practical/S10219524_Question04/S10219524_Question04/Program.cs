using System;

namespace S10219524_Question04
{
    class S10219524_Question04
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("\n" + @"------------- MENU --------------
[1] Calculate Body Mass Index
[2] Calculate Discount
[3] Display Multiplication Table
[0] Exit
-------------------------------- -
Enter your option: ");
                string option = Console.ReadLine();
                if (option == "1")
                {
                    CalculateBMI();
                }
                else if (option == "2")
                {
                    CalculateDiscount();
                }
                else if (option == "3")
                {
                    MultiplicationTable();
                }
                else if (option == "0")
                {
                    Console.WriteLine("Bye");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option! Please try again.");
                }
            }
        }
        static void CalculateBMI()
        {
            Console.Write("\nBMI Calculation\nEnter your weight (kg): ");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your height (m): ");
            double height = Convert.ToDouble(Console.ReadLine());
            double bmi = weight / (height * height);
            Console.WriteLine("Your body mass index is " + bmi);
            string HC = "";
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
            Console.WriteLine("You are " + HC + ".");
        }
        static void CalculateDiscount()
        {
            double percent, discount;
            Console.Write("\nDiscount Calculation\nEnter amount   ($) : ");
            double amount = Convert.ToDouble(Console.ReadLine());
            if (amount <= 100)
            {
                percent = 0;
            }
            else if (amount > 100 && amount <= 500)
            {
                percent = 5;
            }
            else if (amount > 500 && amount <= 1000)
            {
                percent = 10;
            }
            else
            {
                percent = 20;
            }
            discount = amount * (percent / 100);
            Console.WriteLine("Discount given (%) : " + percent);
            Console.WriteLine("Discount amount($) : " + Math.Round(discount, 2));
        }
        static void MultiplicationTable()
        {
            Console.Write("\nMultiplication Table\nEnter a number : ");
            double number = Convert.ToDouble(Console.ReadLine());
            int count = 1;
            while (count <= 12)
            {
                if (count < 10)
                {
                    Console.Write(count);
                    Console.WriteLine("       " + (count * number));
                    count += 1;
                }
                else
                {
                    Console.Write(count);
                    Console.WriteLine("      " + (count * number));
                    count += 1;
                }
            }
        }
    }
}
