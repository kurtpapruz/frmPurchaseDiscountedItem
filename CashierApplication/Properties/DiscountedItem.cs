using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApplication.Properties
{
    internal class DiscountedItem : Item
    {
        private double item_discount;
        private double discounted_price;
        private double payment_amount;
        private double change;

        public DiscountedItem(string name, double price, int quantity, double discount) : base(name, price, quantity)
        {
            this.item_name = name;
            this.item_price = price;
            this.item_quantity = quantity;
            this.discounted_price = discount;

        }
        public override double getTotalPrice()
        {
            item_discount = discounted_price * 0.01;
            discounted_price = item_price - (item_price * item_discount);
            total_price = item_quantity * discounted_price;
            return total_price;
        }
        public override void setPayment(double amount)
        {
            payment_amount = amount;

        }
        public double getChange()
        {
            change = payment_amount - total_price;
            return change;
        }
    }
}
