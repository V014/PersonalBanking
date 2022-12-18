using System;
using System.Drawing;
using System.Windows.Forms;

namespace PersonalBanking
{
    public partial class AddCustomer : Form
    {
        Connection con = new Connection();
        HomeAdmin home = new HomeAdmin();
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string fname = txt_fname.Text;
            string lname = txt_lname.Text;
            string dob = txt_dob.Text;
            string contact = txt_contact.Text;
            string nationality = txt_nationality.Text;
            string accountType = txt_accountType.Text;
            string password = txt_password.Text;
            string customerID = txt_customerID.Text;
            string date = DateTime.Now.ToString("g");
            try
            {
                string queryExist = $"SELECT ID FROM account WHERE customerID = {customerID} AND accountType = '{accountType}'";
                string result = con.ReadString(queryExist);
                if(result == "")
                {
                    string query = $"INSERT INTO customer VALUES(NULL, '{fname}', '{lname}', '{dob}', '{contact}', '{nationality}', '{password}', '{date}', 'offline', 'Active')";
                    con.ExecuteQuery(query);
                    string queryAccount = $"Insert INTO account VALUES(NULL, '{customerID}','{accountType}', NULL)";
                    con.ExecuteQuery(queryAccount);
                    this.Close();
                    home.loadCustomers();
                }
                else
                {
                    lbl_title.Text = "Duplicate Account Type";
                    panel_top.BackColor = Color.Crimson;
                }
            }
            catch (Exception)
            {
                lbl_title.Text = "System error";
                panel_top.BackColor = Color.Crimson;
            }
        }
        private void txt_contact_KeyPress(object sender, KeyPressEventArgs e)
        {
            int asciiCode = Convert.ToInt32(e.KeyChar);
            if ((asciiCode != 8))
            {
                if ((asciiCode >= 48 && asciiCode <= 57))
                {
                    e.Handled = false;
                }
                else
                {
                    MessageBox.Show("Numbers Only Please!", "Error: Number Only", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    e.Handled = true;
                }
            }
        }
        private void txt_accountID_KeyPress(object sender, KeyPressEventArgs e)
        {
            int asciiCode = Convert.ToInt32(e.KeyChar);
            if ((asciiCode != 8))
            {
                if ((asciiCode >= 48 && asciiCode <= 57))
                {
                    e.Handled = false;
                }
                else
                {
                    MessageBox.Show("Numbers Only Please!", "Error: Number Only", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    e.Handled = true;
                }
            }
        }
    }
}
