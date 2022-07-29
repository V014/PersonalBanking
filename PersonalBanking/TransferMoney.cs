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
            string accountNumber = txt_accountNumber.Text;
            string amount = txt_amount.Text;

            if(!string.IsNullOrEmpty(accountNumber) && !string.IsNullOrEmpty(amount))
            {
                try
                {
                    // Insert a transaction record of deposit
                    con.ExecuteQuery($"INSERT INTO transactions (firstAccount, secondAccount, Amount, Date, type) VALUES ('{id}', '{accountNumber}', '{amount}', '{date}', 'Transfer')");
                    // update the balance of the recieving customer
                    con.ExecuteQuery($"UPDATE account SET Balance = Balance + '{amount}' WHERE accountNumber = '{accountNumber}'");
                    // update the balance of the customer
                    con.ExecuteQuery($"UPDATE account SET Balance = Balance - '{amount}' WHERE id = '{id}'");
                    // get balance
                    string balance = con.ReadString($"SELECT balance FROM account WHERE customerID = {id}");
                    // display results
                    lbl_title.Text = "Done ✔";
                    panel_top.BackColor = Color.MediumSeaGreen;
                    home.lbl_balance.Text = balance;
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
