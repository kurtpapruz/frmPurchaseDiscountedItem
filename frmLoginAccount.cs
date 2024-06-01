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
    public partial class frmLoginAccount : Form
    {
        public frmLoginAccount()
        {
            InitializeComponent();
        }

        private void frmLoginAccount_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Cashier user = new Cashier("Papruz, Kurt Russel B.", "Cashier", UserNameBox.Text, PasswordBox.Text);
            MessageBox.Show("Welcome, " + "Papruz, Kurt Russel " + "of " + "Cashier!");

            if (user.validateLogin(UserNameBox.Text, PasswordBox.Text))
            {
                this.Hide();
                Form1 purchasedDiscount = new Form1();
                purchasedDiscount.Show();


            }

        }
    }
}
