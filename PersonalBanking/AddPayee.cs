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
        public AddPayee()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txt_name.Text;
                string firstAccount = txt_firstAccount.Text;
                string secondAccount = txt_secondAccount.Text;
                string query = $"INSERT INTO payee VALUES(NULL, {name}, '{firstAccount}', '{secondAccount}', '{date}')";

                con.ExecuteQuery(query);
                lbl_title.Text = "Payee Added!";
                panel_top.BackColor = Color.MediumSeaGreen;
                home.loadPayees();
            }
            catch (Exception)
            {
                lbl_title.Text = "System Error";
                panel_top.BackColor = Color.Crimson;
            }
        }
    }
}
