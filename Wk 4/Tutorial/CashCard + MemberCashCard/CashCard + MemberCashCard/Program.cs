using System;

namespace CashCard___MemberCashCard
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // create a cashcard
            CashCard myCashCard = new CashCard("101", 10);
            Console.WriteLine("My cashcard: {0}", myCashCard);

            // top up $10 to the card
            Console.WriteLine("\nAttempting top up to card...");
            myCashCard.TopUp(10);
            Console.WriteLine("My cashcard: {0}", myCashCard);

            // deduct $11 from the card
            Console.WriteLine("\nAttempting to deduct from card...");
            bool success = myCashCard.Deduct(11);
            if (success)
            {
                Console.WriteLine("$11 deducted successfully.");
            }
            else
            {
                Console.WriteLine("Unable to deduct $11.");
            }
            Console.WriteLine("My cashcard: {0}", myCashCard);
            // create member cashcard
            MemberCashCard myMC = new MemberCashCard("201", 10);
            Console.WriteLine("\nMy member cashcard: {0}", myMC);

            // top up $10 to the card
            Console.WriteLine("\nAttempting top up to member card...");
            myMC.TopUp(10);
            Console.WriteLine("My member cashcard: {0}", myMC);

            // deduct $11 from the card
            Console.WriteLine("\nAttempting to deduct from member card...");
            success = myMC.Deduct(11);
            if (success)
            {
                Console.WriteLine("$11 deducted successfully.");
            }
            else
            {
                Console.WriteLine("Unable to deduct $11.");
            }
            Console.WriteLine("My member cashcard: {0}", myMC);
        }
    }
}
