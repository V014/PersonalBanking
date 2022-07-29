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

            string queryCheck = $"SELECT id FROM payee WHERE firstAccount = {firstAccount} AND secondAccount = {secondAccount}";
            string id = con.ReadString(queryCheck);

            try
            {
                if (string.IsNullOrEmpty(id))
                {
                    string queryLink = $"INSERT INTO payee VALUES(NULL, {firstAccount}, {secondAccount}, '{date}')";
                    con.ExecuteQuery(queryLink);
                    lbl_title.Text = "Done ✔";
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
