using System;
using System.Drawing;
using System.Windows.Forms;

namespace PersonalBanking
{
    public partial class TransferMoney : Form
    {
        Connection con = new Connection();
<<<<<<< HEAD
        HomeAdmin home = new HomeAdmin();
        string date = DateTime.Now.ToString("g");
=======
        string date = DateTime.Now.ToString("g");
        string id = Utils.GetUserID();
        Home home = new Home();
>>>>>>> ea55cebfc6252257567cdd1f590ab73666373841
        public TransferMoney()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
        private void btn_transfer_Click(object sender, EventArgs e)
        {
            try
            {
                string firstAccount = txt_firstAccount.Text;
                string secondAccount = txt_SecondAccount.Text;
                string amount = txt_amount.Text;

                if (firstAccount == secondAccount)
                {
                    string queryTransfer = $"INSERT INTO transactions (firstAccount, secondAccount, Amount, Date) VALUES ('{firstAccount}', '{secondAccount}', '{amount}', '{date}')";
                    string queryDeposit = $"UPDATE account SET Balance = Balance + '{amount}' WHERE accountNumber = '{firstAccount}'";

                    con.ExecuteQuery(queryTransfer);
                    con.ExecuteQuery(queryDeposit);

                    // if the first account and the second account are the same, set it as a deposit
                    string queryReceiveInterest = "SELECT COUNT(*) FROM transactions WHERE firstAccount = secondAccount AND Amount > 1000";
                    string queryHasInterest = $"SELECT AccountID FROM Interest WHERE AccountID =  '{secondAccount}'";
                    string result = con.ReadString(queryReceiveInterest);
                    string interestResult = con.ReadString(queryHasInterest);

                    // if there has been more than 3 deposits and its over a threashold of MK1000
                    if (int.Parse(result) > 3 && string.IsNullOrEmpty(interestResult))
                    {
                        // set interest to 8 percent
                        con.ExecuteQuery($"INSERT INTO Interest (AccountID, Percentage) VALUES ('{secondAccount}', '{8}')");

                    }
                    else
                    {
                        lbl_title.Text = "Traansfer Failed";
                        panel_top.BackColor = Color.Crimson;
                    } 
                }
                else
                {
                    // check balance
                    // update the transactions table
                    string queryTransfer = $"INSERT INTO transactions VALUES(NULL, {firstAccount}, {secondAccount}, {amount}, '{date}')";
                    con.ExecuteQuery(queryTransfer);
                    // decuct money from customer
                    string queryDeduct = $"UPDATE account SET Balance = Balance - '{amount}' WHERE accountNumber = '{firstAccount}'";
                    con.ExecuteQuery(queryDeduct);
                    // add money to the payee account
                    string queryAdd = $"UPDATE account SET Balance = Balance + '{amount}' WHERE accountNumber = '{secondAccount}'";
                    con.ExecuteQuery(queryAdd);
                }
                home.loadTransactions();
                this.Close();
            }
            catch (Exception)
            {
                lbl_title.Text = "System Error";
                panel_top.BackColor = Color.Crimson;
            }
            
=======
        private void btn_send_Click(object sender, EventArgs e)
        {
            string secondAccount = txt_accountNumber.Text;
            string amount = txt_amount.Text;

            if(!string.IsNullOrEmpty(secondAccount) && !string.IsNullOrEmpty(amount))
            {
                try
                {
                    // get the account number of current customer
                    string fisrtAccount = con.ReadString($"SELECT accountNumber FROM account WHERE id = {id}");
                    // Insert a transaction record of deposit
                    con.ExecuteQuery($"INSERT INTO transactions (firstAccount, secondAccount, Amount, Date, type) VALUES ('{fisrtAccount}', '{secondAccount}', '{amount}', '{date}', 'Transfer')");
                    // update the balance of the recieving customer
                    con.ExecuteQuery($"UPDATE account SET Balance = Balance + '{amount}' WHERE accountNumber = '{secondAccount}'");
                    // update the balance of the customer
                    con.ExecuteQuery($"UPDATE account SET Balance = Balance - '{amount}' WHERE id = '{fisrtAccount}'");
                    // get balance
                    string balance = con.ReadString($"SELECT balance FROM account WHERE customerID = {fisrtAccount}");
                    // display results
                    lbl_title.Text = "Done ✔";
                    panel_top.BackColor = Color.MediumSeaGreen;
                    home.lbl_balance.Text = balance;
                    home.loadTransactions();
                }
                catch (Exception)
                {
                    lbl_title.Text = "System error!";
                    panel_top.BackColor = Color.Crimson;
                }
            }
            else
            {
                lbl_title.Text = "Incomplete form!";
                panel_top.BackColor = Color.Crimson;
            }
>>>>>>> ea55cebfc6252257567cdd1f590ab73666373841
        }
    }
}
