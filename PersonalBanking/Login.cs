using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            string accountID = txt_username.Text;
            string password = txt_password.Text;
            string queryAccount = "SELECT ID FROM customer WHERE AccountID = '" + accountID + "' AND Password = '"+ password +"'";
            string result = con.ReadString(queryAccount);
            if (result != "")
            {
                string query = $"UPDATE customer SET status = 'online' WHERE ID = {result}";
                con.ExecuteQuery(query);
                Home home = new Home();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect password");
            }
        }
    }
}
