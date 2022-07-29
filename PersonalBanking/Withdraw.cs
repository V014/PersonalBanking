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
        string id = Utils.GetUserID();
        public Withdraw()
        {
            InitializeComponent();
        }

        private void btn_withdraw_Click(object sender, EventArgs e)
        {
            // hold the user input in variables
            string password = txt_password.Text;
            string amount = txt_amount.Text;

            // Check that the account and amount are supplied and that the user is withdrawing
            // from an account they own
            if (!string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(amount))
            {
                string accountNo = con.ReadString($"SELECT accountNumber FROM account WHERE id = {id} AND password = {password}");
                if (!string.IsNullOrEmpty(accountNo))
                {
                    try
                    {
                        string transactionQuery = $"INSERT INTO transactions(firstAccount, Amount, Date, type) VALUES('{accountNo}', '{amount}', '{date}', 'Withdrawal')";
                        string withdrawQuery = $"UPDATE account SET balance = balance - '{amount}' WHERE accountNumber = '{accountNo}'";

                        con.ExecuteQuery(transactionQuery);
                        con.ExecuteQuery(withdrawQuery);

                        lbl_title.Text = "Done ✔";
                        panel_top.BackColor = Color.MediumSeaGreen;
                        home.loadTransactions();
                        home.refresh();
                    }
                    catch (Exception)
                    {
                        lbl_title.Text = "System error!";
                        panel_top.BackColor = Color.Crimson;
                    }
                    
                }
                else
                {
                    lbl_title.Text = "Try again ✖";
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
