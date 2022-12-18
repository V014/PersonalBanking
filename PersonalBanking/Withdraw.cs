using System;
using System.Drawing;
using System.Windows.Forms;

namespace PersonalBanking
{
    public partial class Withdraw : Form
    {
        Connection con = new Connection();
        Home home = new Home();
        string date = DateTime.Now.ToString("g");

        public Withdraw()
        {
            InitializeComponent();
        }

        private void btn_withdraw_Click(object sender, EventArgs e)
        {
            // hold the user input in variables
            string accountNo = txt_account.Text;
            string amount = txt_amount.Text;

            // Check that the account and amount are supplied and that the user is withdrawing
            // from an account they own
            if (!string.IsNullOrEmpty(accountNo) && !string.IsNullOrEmpty(amount) && Utils.IsOwner(accountNo))
            {
                string transactionQuery = $"INSERT INTO transactions(firstAccount, secondAccount, Amount, Date, type) VALUES('{accountNo}', '{accountNo}', '{amount}', '{date}', 'Withdrawal')";
                string withdrawQuery = $"UPDATE account SET balance = balance - '{amount}' WHERE accountNumber = '{accountNo}'";
                con.ExecuteQuery(transactionQuery);
                con.ExecuteQuery(withdrawQuery);

                home.loadTransactions();
                home.refresh();
                this.Close();
            }
            else
            {
                lbl_title.Text = "Empty fields";
                panel_top.BackColor = Color.Crimson;
            }
        }
    }
}
