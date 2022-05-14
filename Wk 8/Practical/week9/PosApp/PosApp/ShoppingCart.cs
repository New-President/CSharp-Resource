using System;
using System.Collections.Generic;
using System.Text;

namespace PosApp
{
    internal class ShoppingCart
    {
        public List<CartItem> itemList { get; set; } = new List<CartItem>();
        public ShoppingCart() { }
        public void AddItem(CartItem item)
        {
            itemList.Add(item);
        }
        public List<CartItem> GetItemList()
        {
            return itemList;
        }
        public bool RemoveItem(int q)
        {
            try
            {
                itemList.RemoveAt(q - 1);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void ClearCart()
        {
            itemList.Clear();
        }
        public int Size()
        {
            return itemList.Count;
        }
        public bool IsEmpty()
        {
            if (itemList.Count == 0)
            {
                return true;
            }
            return false;
        }
    }
}
