using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalBanking
{
    public partial class Customer : UserControl
    {
        Connection con = new Connection();
        HomeAdmin home = new HomeAdmin();
        public Customer()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddCustomer customer = new AddCustomer();
            customer.Show();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            CloseAccount closeForm = new CloseAccount();
            closeForm.Show();
        }

        private void btn_link_Click(object sender, EventArgs e)
        {
            LinkAccount account = new LinkAccount();
            account.Show();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            home.loadCustomers();
        }
    }
}
