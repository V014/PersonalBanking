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
            string customerNumber = txt_customerNumber.Text;
            string date = DateTime.Now.ToString("g");

            // check to see if account type already exists
            string queryExist = $"SELECT ID FROM account WHERE customerID = {customerNumber} AND accountType = '{accountType}'";
            string result = con.ReadString(queryExist);

            // if the account doesnt exit
            if(string.IsNullOrEmpty(result))
            {
                try
                {
                    // make an insert into the customer table
                    con.ExecuteQuery($"INSERT INTO customer VALUES(NULL, '{fname}', '{lname}', '{dob}', '{contact}', '{nationality}', '{date}')");

                    // Retrieve the id of the last entered record into the customer table
                    string customerID = con.ReadString("SELECT id FROM customer ORDER BY id DESC LIMIT 1");

                    // make an insert into the account table
                    con.ExecuteQuery($"INSERT INTO account (customerID, accountNumber, accountType, balance, password, status, activity, dateCreated) VALUES('{customerID}', '{customerNumber}','{accountType}', '500', '{password}', 'offline', 'active', '{date}')");
                    // display response
                    lbl_title.Text = "Done ✔";
                    panel_top.BackColor = Color.MediumSeaGreen;
                    home.loadCustomers();
                }
                catch (Exception)
                {
                    lbl_title.Text = "System error!";
                    panel_top.BackColor = Color.Crimson;
                }
            }
            // if the account type already exists
            else
            {
                lbl_title.Text = "Duplicate Account Type";
                panel_top.BackColor = Color.Crimson;
            }
        }
        // reject words in numerical textfields
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
