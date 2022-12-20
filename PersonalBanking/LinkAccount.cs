using System;
using System.Drawing;
using System.Windows.Forms;

namespace PersonalBanking
{
    public partial class LinkAccount : Form
    {
        Connection con = new Connection();
        string date = DateTime.Now.ToString("g");
        public LinkAccount()
        {
            InitializeComponent();
        }

        private void btn_link_Click(object sender, EventArgs e)
        {
            string firstAccount = txt_firstAccount.Text;
            string secondAccount = txt_secondAccount.Text;

<<<<<<< HEAD
            string queryCheck = $"SELECT id FROM payee WHERE firstAccount = {firstAccount} AND secondAccount = {secondAccount}";
=======
            string queryCheck = $"SELECT id FROM payee WHERE customerAccount = {firstAccount} AND payeeAccount = {secondAccount}";
>>>>>>> ea55cebfc6252257567cdd1f590ab73666373841
            string id = con.ReadString(queryCheck);

            try
            {
<<<<<<< HEAD
                if (id == "")
                {
                    string queryLink = $"INSERT INTO payee VALUES(NULL, {firstAccount}, {secondAccount}, '{date}')";
                    con.ExecuteQuery(queryLink);
                    lbl_title.Text = "Accounts Linked!";
=======
                if (string.IsNullOrEmpty(id))
                {
                    string queryLink = $"INSERT INTO payee VALUES(NULL, {firstAccount}, {secondAccount}, '{date}')";
                    con.ExecuteQuery(queryLink);
                    lbl_title.Text = "Done ✔";
>>>>>>> ea55cebfc6252257567cdd1f590ab73666373841
                    panel_top.BackColor = Color.MediumSeaGreen;
                }
                else
                {
                    lbl_title.Text = "Already Linked!";
                    panel_top.BackColor = Color.Orange;
                }
            }
            catch (Exception)
            {
                lbl_title.Text = "System Error!";
                panel_top.BackColor = Color.Crimson;
            }
            
        }
    }
}
