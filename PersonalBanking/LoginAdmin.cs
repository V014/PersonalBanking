using System;
using System.Drawing;
using System.Windows.Forms;

namespace PersonalBanking
{
    public partial class LoginAdmin : Form
    {
        Connection con = new Connection();
        public LoginAdmin()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;
            string queryAccount = $"SELECT ID FROM Admin WHERE Username = '{username}' AND Password = '{password}'";
            string result = con.ReadString(queryAccount);
            if (result != "")
            {
                string query = $"UPDATE admin SET status = 'online' WHERE ID = {result}";
                con.ExecuteQuery(query);
                HomeAdmin home = new HomeAdmin();
                home.Show();
                this.Hide();
            }
            else
            {
                lbl_title.Text = "Incorrect Password";
                panel_top.BackColor = Color.Crimson;
            }
        }

        private void lbl_customer_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void LoginAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
