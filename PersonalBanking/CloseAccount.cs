using System;
using System.Drawing;
using System.Windows.Forms;

namespace PersonalBanking
{
    public partial class CloseAccount : Form
    {
        Connection con = new Connection();
        HomeAdmin home = new HomeAdmin();
        public CloseAccount()
        {
            InitializeComponent();
        }

        private void btn_closeAccount_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Closing the account will set it as inactive and will still appear in the database but not accessible.", "Close Account?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string account = txt_accountID.Text;
                    string queryClose = $"UPDATE customer SET  WHERE accountID = {account}";

                    con.ExecuteQuery(queryClose);
                    home.loadCustomers();
                }
            }
            catch(Exception)
            {
                lbl_title.Text = "System Error";
                panel_top.BackColor = Color.Crimson;
            }
            
        }
    }
}
