using System;
using System.Collections.Generic;

namespace S10219524_CashCardApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<CashCard> cardList = new List<CashCard>();
            InitCardList(cardList);
            Console.WriteLine("{0,-10}{1}", "Id", "Balance");
            for (int i = 0; i < cardList.Count; i++)
            {
                Console.WriteLine("{0,-10}{1}", cardList[i].Id, cardList[i].Balance);
            }
            Console.Write("\nSearch Id: ");
            string ID = Console.ReadLine();
            if (Search(cardList, ID) == null)
            {
                Console.WriteLine("Card ID not found");
            }
            else
            {
                CashCard card = Search(cardList, ID);
                Console.WriteLine("Balance: " + card.Balance);
                Console.Write("Deduct Amount: ");
                double deduct = Convert.ToDouble(Console.ReadLine());
                if (card.Deduct(deduct))
                {
                    Console.WriteLine("Deducting {0} from {1}...", deduct, card.Balance);                
                    Console.WriteLine("\n" + card.ToString());
                }
                else
                {
                    Console.WriteLine("Deduction failed due to insufficient funds.");
                    Console.WriteLine("Card Balance: "+card.Balance);
                }
            }
        }

        static void InitCardList(List<CashCard> cardList)
        {
            CashCard card1 = new CashCard("001", 25);
            CashCard card2 = new CashCard("002", 25);
            CashCard card3 = new CashCard("003", 30);
            CashCard card4 = new CashCard("004", 30);
            CashCard card5 = new CashCard("005", 50);
            cardList.Add(card1);
            cardList.Add(card2);
            cardList.Add(card3);
            cardList.Add(card4);
            cardList.Add(card5);
        }

        static CashCard Search(List<CashCard> cardList, string id)
        {
            for (int i = 0; i < cardList.Count; i++)
            {
                if (cardList[i].Id == id)
                {
                    return cardList[i];
                }
            }
            return null;
        }
    }
}
