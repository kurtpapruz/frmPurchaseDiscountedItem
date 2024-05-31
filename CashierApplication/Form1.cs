using CashierApplication.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private DiscountedItem DisItem;

        private void ComputeButton_Click(object sender, EventArgs e)
        {
            DisItem = new DiscountedItem(ItemName.Text, Convert.ToDouble(PriceBox.Text), Convert.ToInt16(QuantiBox.Text), Convert.ToInt16(DiscountBox.Text));
            totalAmount.Text = "Total Amount: "+ DisItem.getTotalPrice().ToString();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            DisItem.setPayment(Convert.ToDouble(PaymentReceived.Text));
            Change.Text = "Change: " + DisItem.getChange().ToString();
        }

    }
}
