using System;
using System.Windows.Forms;

namespace PersonalBanking
{
    public partial class SendMoney : Form
    {
        Connection con = new Connection();
        string date = DateTime.Now.ToString("g");
        string id = Utils.GetUserID();
        public SendMoney()
        {
            InitializeComponent();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            string accountNumber = txt_SecondAccount.Text;
            string amount = txt_amount.Text;
        }
    }
}
