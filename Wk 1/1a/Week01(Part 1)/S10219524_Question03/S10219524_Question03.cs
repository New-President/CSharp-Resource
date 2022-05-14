using System;

namespace S10219524_Question03
{
    class S10219524_Question03
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            double number = Convert.ToDouble(Console.ReadLine());
            int count = 1;
            while (count <= 12)
            {
                if (count<10)
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
