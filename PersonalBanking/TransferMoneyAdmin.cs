using System;
using System.Drawing;
using System.Windows.Forms;

namespace PersonalBanking
{
    public partial class TransferMoneyAdmin : Form
    {
        Connection con = new Connection();
        HomeAdmin home = new HomeAdmin();
        string date = DateTime.Now.ToString("g");
        public TransferMoneyAdmin()
        {
            InitializeComponent();
        }

        private void btn_transfer_Click(object sender, EventArgs e)
        {
            string firstAccount = txt_firstAccount.Text;
            string secondAccount = txt_SecondAccount.Text;
            string amount = txt_amount.Text;

            // Check that none of the fields are empty
            if (!string.IsNullOrEmpty(firstAccount) && !string.IsNullOrEmpty(secondAccount) && !string.IsNullOrEmpty(amount))
            {
                // Is user depositing money into an account they own
                bool isOwner = Utils.IsOwner(firstAccount);
                // What is the type of the account being deposited into
                string type = con.ReadString($"SELECT accountType FROM account WHERE accountNumber = {firstAccount}");

                if (isOwner)
                {
                    // Insert a transaction record of deposit
                    con.ExecuteQuery($"INSERT INTO transactions (firstAccount, secondAccount, Amount, Date, type) VALUES ('{firstAccount}', '{secondAccount}', '{amount}', '{date}', 'Deposit')");
                    // update the balance of the recieving customer
                    con.ExecuteQuery($"UPDATE account SET Balance = Balance + '{amount}' WHERE accountNumber = '{secondAccount}'");
                    // update recieving account
                    con.ExecuteQuery($"UPDATE account SET Balance = Balance - '{amount}' WHERE accountNumber = '{firstAccount}'");

                    // Account type is savings account perform extra checks for whether entitled to interest
                    if (type == "Savings Account")
                    {
                        string threshhold = con.ReadString("SELECT COUNT(*) FROM transactions WHERE firstAccount = secondAccount AND Amount > 1000");
                        // collect last interest
                        string interest = con.ReadString($"SELECT percentage FROM interest WHERE accountID =  '{firstAccount}'");

                        // if there has been more than 3 deposits and its over a threashold of MK1000
                        if (int.Parse(threshhold) > 3 && string.IsNullOrEmpty(interest))
                        {
                            // set interest to 8 percent
                            con.ExecuteQuery($"INSERT INTO Interest (accountID, percentage) VALUES ('{firstAccount}', '{8}')");
                        }
                    }
                }
                else
                {
                    // The user is making a deposit to an account they do not own, handle that case
                    // Insert a transaction record
                    con.ExecuteQuery($"INSERT INTO transactions (firstAccount, secondAccount, Amount, Date, type) VALUES ('{firstAccount}','{secondAccount}', '{amount}', '{date}', 'Transfer')");
                    // Add amount to the receivers account and deduct from the givers account
                    con.ExecuteQuery($"UPDATE account SET Balance = Balance + '{amount}' WHERE accountNumber = '{secondAccount}'");
                    // update recieving account
                    con.ExecuteQuery($"UPDATE account SET Balance = Balance - '{amount}' WHERE accountNumber = '{firstAccount}'");
                }

                // display response
                lbl_title.Text = "Done ✔";
                panel_top.BackColor = Color.MediumSeaGreen;
                home.loadTransactions();
            }
            else
            {
                lbl_title.Text = "Empty fields";
                panel_top.BackColor = Color.Crimson;
            }
        }
    }
}
