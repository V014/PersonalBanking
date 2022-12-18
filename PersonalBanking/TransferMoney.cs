using System;
using System.Drawing;
using System.Windows.Forms;

namespace PersonalBanking
{
    public partial class TransferMoney : Form
    {
        Connection con = new Connection();
        HomeAdmin home = new HomeAdmin();
        string date = DateTime.Now.ToString("g");
        public TransferMoney()
        {
            InitializeComponent();
        }

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
            
        }
    }
}
