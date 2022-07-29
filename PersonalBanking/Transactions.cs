using System;
using System.Windows.Forms;

namespace PersonalBanking
{
    public partial class Transactions : UserControl
    {
        public Transactions()
        {
            InitializeComponent();
        }

        private void btn_transfer_Click(object sender, EventArgs e)
        {
            TransferMoney transfer = new TransferMoney();
            transfer.Show();
        }

        private void btn_deposit_Click(object sender, EventArgs e)
        {
            Deposit deposit = new Deposit();
            deposit.Show();
        }

        private void btn_withdraw_Click(object sender, EventArgs e)
        {
            Withdraw withdraw = new Withdraw();
            withdraw.Show();
        }
    }
}
