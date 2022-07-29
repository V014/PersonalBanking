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
        string id = Utils.GetUserID();
        public AddPayee()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txt_name.Text;
                string accountNumber = txt_accountNumber.Text;
                con.ExecuteQuery($"INSERT INTO payee (name, customerAccount, payeeAccount, date) VALUES('{name}', '{id}', '{accountNumber}', '{date}')");

                lbl_title.Text = "Done ✔";
                panel_top.BackColor = Color.MediumSeaGreen;
                this.Close();
                home.loadPayees();
            }
            catch (Exception)
            {
                lbl_title.Text = "System Error!";
                panel_top.BackColor = Color.Crimson;
            }
        }
    }
}
