using System;
using System.Drawing;
using System.Windows.Forms;

namespace PersonalBanking
{
    public partial class TransferMoney : Form
    {
        Connection con = new Connection();
        string date = DateTime.Now.ToString("g");
        string id = Utils.GetUserID();
        Home home = new Home();
        public TransferMoney()
        {
            InitializeComponent();
        }

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
        }
    }
}
