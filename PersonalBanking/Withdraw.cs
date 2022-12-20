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
<<<<<<< HEAD

=======
        string id = Utils.GetUserID();
>>>>>>> ea55cebfc6252257567cdd1f590ab73666373841
        public Withdraw()
        {
            InitializeComponent();
        }

        private void btn_withdraw_Click(object sender, EventArgs e)
        {
            // hold the user input in variables
<<<<<<< HEAD
            string accountNo = txt_account.Text;
=======
            string password = txt_password.Text;
>>>>>>> ea55cebfc6252257567cdd1f590ab73666373841
            string amount = txt_amount.Text;

            // Check that the account and amount are supplied and that the user is withdrawing
            // from an account they own
<<<<<<< HEAD
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
=======
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
>>>>>>> ea55cebfc6252257567cdd1f590ab73666373841
                panel_top.BackColor = Color.Crimson;
            }
        }
    }
}
