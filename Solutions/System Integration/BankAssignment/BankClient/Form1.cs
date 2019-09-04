using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankClient
{
    public partial class Form1 : Form
    {

        BankService bankService = new BankService();

        public Form1()
        {
            InitializeComponent();
        }

        private void checkBalance_button_Click(object sender, EventArgs e)
        {
            fundsValue.Text = bankService.CheckBalance(accountNoTextbox.Text, 0);
        }

        private void DepositButton_Click(object sender, EventArgs e)
        {
            bankService.AddFunds(accountNoTextbox.Text, fundsInput.Text);
            fundsValue.Text = bankService.CheckBalance(accountNoTextbox.Text, 0);
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            bankService.WithdrawFunds(accountNoTextbox.Text, fundsInput.Text);
            fundsValue.Text = bankService.CheckBalance(accountNoTextbox.Text, 0);
        }
    }
}
