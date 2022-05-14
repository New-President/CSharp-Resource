using System;
using System.Collections.Generic;

namespace PosApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> productList = new List<Product>();
            productList.Add(new Product("1001", "Apple Iphone", 1088));
            productList.Add(new Product("1005", "HTC Sensation", 888));
            productList.Add(new Product("1013","LG Optimus 2X",788));
            productList.Add(new Product("1022", "Motorola Atrix", 958));
            productList.Add(new Product("1027","Samasung Galaxy",988));
            ShoppingCart cart = new ShoppingCart();
            while(true)
            {
                Console.Write(@"---------------- M E N U -----------------
[1] List all products and prices
[2] Add item to cart
[3] View cart items
[4] Remove item from cart
[5] Clear cart items
[0] Exit
------------------------------------------
Enter your option: ");
                string option = Console.ReadLine();
                if (option == "0")
                {
                    break;
                }
                else if (option == "1")
                {
                    DisplayProduct(productList);
                    Console.WriteLine();
                }
                else if (option == "2")
                {
                    DisplayProduct(productList);
                    Console.WriteLine();
                    Console.Write("ItemNo: ");
                    int itemno = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Quanity: ");
                    int quantity = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < productList.Count; i++)
                    {
                        if (i == itemno - 1)
                        {
                            cart.AddItem(new CartItem(productList[i].Code, productList[i].Name, productList[i].Price, quantity));
                        }
                    }
                }
                else if (option == "3")
                {
                    if (cart.IsEmpty())
                    {
                        Console.WriteLine("Your Cart is empty.\n");
                    }
                    else
                    {
                        Console.WriteLine();
                        double grandtotal = 0;
                        List<CartItem> itemList = cart.GetItemList();
                        Console.WriteLine("{0,-7} {1,-5} {2,-15} {3,-10} {4,-20}", "ItemNo", "Code", "Name", "Quantity", "Price($)");
                        for (int i = 0; i < itemList.Count; i++)
                        {
                            double subtotal = itemList[i].Qty * itemList[i].Price;
                            Console.WriteLine("{0,-7} {1,-5} {2,-15} {3,-10} {4,-20:0.00}", "[" + (i + 1) + "]", itemList[i].Code, itemList[i].Name, itemList[i].Qty, subtotal);
                            grandtotal += subtotal;
                        }
                        Console.WriteLine("Grand Total: ${0:0.00}\n", grandtotal);
                    }
                }
                else if (option == "4")
                {
                    if (cart.IsEmpty())
                    {
                        Console.WriteLine("Your Cart is empty.\n");
                        continue;
                    }
                    else
                    {
                        List<CartItem> itemList = cart.GetItemList();
                        Console.WriteLine("{0,-7} {1,-5} {2,-15} {3,-10} {4,-20}", "ItemNo", "Code", "Name", "Quantity", "Price($)");
                        for (int i = 0; i < itemList.Count; i++)
                        {
                            double subtotal = itemList[i].Qty * itemList[i].Price;
                            Console.WriteLine("{0,-7} {1,-5} {2,-15} {3,-10} {4,-20:0.00}", "[" + (i + 1) + "]", itemList[i].Code, itemList[i].Name, itemList[i].Qty, subtotal);
                        }
                        Console.WriteLine();
                    }
                    Console.Write("ItemNo to remove: ");
                    int itemno = Convert.ToInt32(Console.ReadLine());
                    if (cart.RemoveItem(itemno))
                    {
                        Console.WriteLine("Item removed successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid ItemNo!\n");
                    }
                }
                else if (option == "5")
                {
                    cart.ClearCart();
                }
            }
        }
        static void DisplayProduct(List<Product> productList)
        {
            Console.WriteLine();
            Console.WriteLine("{0,-7} {1,-5} {2,-20} {3,-20}", "ItemNo", "Code", "Name", "Price($)");
            for (int i = 0; i < productList.Count; i++)
            {
                Console.WriteLine("{0,-7} {1,-5} {2,-20} {3,-20:0.00}", "["+(i+1)+"]", productList[i].Code, productList[i].Name, productList[i].Price);
            }
        }
    }
}
