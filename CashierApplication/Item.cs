using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApplication
{
    internal abstract class Item
    {
        protected double item_price;
        protected double total_price;
        protected int item_quantity;
        protected string item_name;

        public Item(string name, double price, int quantity)
        {
            this.item_name = name;
            this.item_price = price;
            this.item_quantity = quantity;
        }

        public abstract  double getTotalPrice();
        public abstract void setPayment(double amount);
    }
}
