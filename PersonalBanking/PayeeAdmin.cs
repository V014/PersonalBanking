using System;
using System.Windows.Forms;

namespace PersonalBanking
{
    public partial class PayeeAdmin : UserControl
    {
        public PayeeAdmin()
        {
            InitializeComponent();
        }

        private void btn_payee_Click(object sender, EventArgs e)
        {
            LinkAccount link = new LinkAccount();
            link.Show();
        }
    }
}
