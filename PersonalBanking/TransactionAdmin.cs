using System;
using System.Windows.Forms;

namespace PersonalBanking
{
    public partial class TransactionAdmin : UserControl
    {
        public TransactionAdmin()
        {
            InitializeComponent();
        }

        private void btn_transfer_Click(object sender, EventArgs e)
        {
            TransferMoneyAdmin transfer = new TransferMoneyAdmin();
            transfer.Show();
        }

        private void btn_deposit_Click(object sender, EventArgs e)
        {
            Deposit deposit = new Deposit();
            deposit.Show();
        }
    }
}
