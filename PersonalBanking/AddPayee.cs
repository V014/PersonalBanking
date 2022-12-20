using System;
using System.Drawing;
using System.Windows.Forms;

namespace PersonalBanking
{
    public partial class AddPayee : Form
    {
        Connection con = new Connection();
        string date = DateTime.Now.ToString("g");
        Home home = new Home();
<<<<<<< HEAD
=======
        string id = Utils.GetUserID();
>>>>>>> ea55cebfc6252257567cdd1f590ab73666373841
        public AddPayee()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
<<<<<<< HEAD
                string name = txt_name.Text;
                string firstAccount = txt_firstAccount.Text;
                string secondAccount = txt_secondAccount.Text;
                string query = $"INSERT INTO payee VALUES(NULL, {name}, '{firstAccount}', '{secondAccount}', '{date}')";

                con.ExecuteQuery(query);
                lbl_title.Text = "Payee Added!";
=======
                // get the account number of current customer
                string customerAccount = con.ReadString($"SELECT accountNumber FROM account WHERE id = {id}");
                string name = txt_name.Text;
                string payeeAccount = txt_accountNumber.Text;
                con.ExecuteQuery($"INSERT INTO payee (name, customerAccount, payeeAccount, date) VALUES('{name}', '{customerAccount}', '{payeeAccount}', '{date}')");

                // display results
                lbl_title.Text = "Done ✔";
>>>>>>> ea55cebfc6252257567cdd1f590ab73666373841
                panel_top.BackColor = Color.MediumSeaGreen;
                home.loadPayees();
            }
            catch (Exception)
            {
<<<<<<< HEAD
                lbl_title.Text = "System Error";
=======
                lbl_title.Text = "System Error!";
>>>>>>> ea55cebfc6252257567cdd1f590ab73666373841
                panel_top.BackColor = Color.Crimson;
            }
        }
    }
}
