using System;
using System.Collections.Generic;
using System.Text;

namespace PosApp
{
    internal class CartItem : Product
    {
        public int Qty { get; set; }
        public CartItem() { }
        public CartItem(string c, string n, double p, int q) : base(c,n,p)
        {
            Qty = q;
        }
        public override string ToString()
        {
            return base.ToString() + "\tQuantity: " + Qty;
        }
    }
}
