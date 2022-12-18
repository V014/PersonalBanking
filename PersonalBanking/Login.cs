using System;
using System.Drawing;
using System.Windows.Forms;

namespace PersonalBanking
{
    public partial class Login : Form
    {
        Connection con = new Connection();
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string accountNumber = txt_accountNumber.Text;
            string password = txt_password.Text;
            string queryAccount = $"SELECT ID FROM account WHERE accountNumber = {accountNumber} AND password = '{password}'";
            string result = con.ReadString(queryAccount);
            if (result != "")
            {
                string query = $"UPDATE account SET status = 'online' WHERE ID = {result}";
                con.ExecuteQuery(query);
                Home home = new Home();
                home.Show();
                this.Hide();
            }
            else
            {
                lbl_title.Text = "Incorrect Password";
                panel_top.BackColor = Color.Crimson;
            }
        }

        private void lbl_admin_Click(object sender, EventArgs e)
        {
            LoginAdmin admin = new LoginAdmin();
            admin.Show();
            this.Hide();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
